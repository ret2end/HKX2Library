using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Xml;
using System.Xml.Linq;

namespace HKX2
{
    public class XmlDeserializer
    {
        public XDocument _xdoc;
        private HKXHeader _header;
        // store deserialized
        private Dictionary<string, IHavokObject> _objectsNameMap;
        private Dictionary<string, XElement> _nameXEleMap;

        public IHavokObject Deserialize(Stream stream, HKXHeader header)
        {
            _xdoc = XDocument.Load(stream, LoadOptions.SetLineInfo);
            _header = header;
            _objectsNameMap = new Dictionary<string, IHavokObject>();

            _nameXEleMap = new Dictionary<string, XElement>();

            var hksection = _xdoc.Element("hkpackfile").Element("hksection");

            // collect nodes
            foreach (var item in hksection.Elements())
            {
                var name = item.Attribute("name").Value;
                _nameXEleMap.Add(name, item);
            }

            var testnode = _nameXEleMap.Where(item => item.Value.Attribute("class").Value == "hkRootLevelContainer").First().Value;
            var rootrefName = testnode.Attribute("name").Value;
            var testobj = ConstructVirtualClass(testnode);
            _objectsNameMap.Add(rootrefName, testobj);

            testobj.ReadXml(this, testnode);

            var hkRootLevelContainer = _objectsNameMap.Where(item => item.Value.Signature == 0x2772c11e).First().Value;

            return hkRootLevelContainer;
        }

        private IHavokObject ConstructVirtualClass(XElement xElement)
        {
            var name = xElement.Attribute("name").Value;

            if (_objectsNameMap.TryGetValue(name, out IHavokObject value))
            {
                return value;
            }

            var hkClassName = xElement.Attribute("class").Value;
            var hkClass = System.Type.GetType($@"HKX2.{hkClassName}");
            if (hkClass is null) throw new Exception($@"Havok class type '{hkClassName}' not found!");

            var ret = (IHavokObject)Activator.CreateInstance(hkClass);
            if (ret is null) throw new Exception($@"Failed to Activator.CreateInstance({hkClass})");

            return ret;
        }
        private XElement GetPropertyElement(XElement element, string name)
        {
            if (name.StartsWith("m_"))
            {
                name = name[2..];
            }
            var eles = element.Elements("hkparam").Where(e => e.Attribute("name").Value == name);
            if (!eles.Any())
            {
                return null;
            }
            return eles.First();
        }
        public T ReadClass<T>(XElement element, string name) where T : IHavokObject, new()
        {
            var ele = GetPropertyElement(element, name)?.Element("hkobject");

            var ret = new T();
            if (ele != null)
            {
                ret.ReadXml(this, ele);
            }

            return ret;
        }

        public List<T> ReadClassArray<T>(XElement element, string name) where T : IHavokObject, new()
        {
            var result = new List<T>();
            var eles = GetPropertyElement(element, name);
            if (eles is null)
                return result;

            if (!int.TryParse(eles.Attribute("numelements")?.Value, out int _))
            {
                throw new Exception($"numelemnets is not vaild number at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");
            }

            foreach (var e in eles.Elements("hkobject"))
            {
                var cls = new T();
                cls.ReadXml(this, e);
                result.Add(cls);
            }
            return result;
        }

        public T[] ReadClassCStyleArray<T>(XElement element, string name, short length) where T : IHavokObject, new()
        {
            var arr = new T[length];
            var eles = GetPropertyElement(element, name);
            if (eles is null)
                return arr;

            if (length != eles.Elements("hkobject").Count())
                throw new Exception($"Content's elements mismatch property requierd. at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {arr.Length}");

            foreach (var (value, i) in eles.Elements("hkobject").Select((v, i) => (v, i)))
            {
                var cls = new T();
                cls.ReadXml(this, value);
                arr[i] = cls;
            }
            return arr;
        }

        public T? ReadClassPointer<T>(XElement element, string name) where T : IHavokObject, new()
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return default;

            var refName = ele.Value;
            if (refName == "null")
                return default;

            if (_objectsNameMap.TryGetValue(refName, out IHavokObject value))
                return (T)value;

            if (!_nameXEleMap.TryGetValue(refName, out XElement refEle))
                throw new Exception($"Reference symbol '{refName}' not found. Make sure it defined somewhere. at Line {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            T ret = (T)ConstructVirtualClass(refEle);
            ret.ReadXml(this, refEle);
            _objectsNameMap.Add(refName, ret);

            return ret;
        }

        public List<T> ReadClassPointerArray<T>(XElement element, string name) where T : IHavokObject, new()
        {
            var result = new List<T>();
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return result;

            if (!int.TryParse(ele.Attribute("numelements")?.Value, out int count))
                throw new Exception($"numelemnets is not vaild number at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            if (count == 0)
                return result;

            var refNames = ele.Value.Split(SplitSpaceList, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            foreach (var refName in refNames)
            {
                if (_objectsNameMap.TryGetValue(refName, out IHavokObject? value))
                {
                    result.Add((T)value);
                    continue;
                }

                if (!_nameXEleMap.TryGetValue(refName, out XElement? refEle))
                    throw new Exception($"Reference symbol '{refName}' not found. Make sure it defined somewhere. at Line {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

                T ret = (T)ConstructVirtualClass(refEle);
                ret.ReadXml(this, refEle);
                _objectsNameMap.Add(refName, ret);

                result.Add(ret);
            }
            return result;
        }

        public T?[] ReadClassPointerCStyleArray<T>(XElement element, string name, short length) where T : IHavokObject, new()
        {
            var arr = new T?[length];
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return arr;

            var refNames = ele.Value.Split(" ", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (refNames.Length != length)
                throw new Exception($"Content's elements mismatch property requierd. at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {arr.Length}");

            foreach (var (refName, i) in refNames.Select((v, i) => (v, i)))
            {
                if (refName == "null")
                {
                    arr[i] = default;
                    continue;
                }

                if (_objectsNameMap.TryGetValue(refName, out IHavokObject? value))
                {
                    arr[i] = (T)value;
                    continue;
                }

                if (!_nameXEleMap.TryGetValue(refName, out XElement? refEle))
                    throw new Exception($"Reference symbol '{refName}' not found. Make sure it defined somewhere. at Line {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

                T ret = (T)ConstructVirtualClass(refEle);
                ret.ReadXml(this, refEle);
                _objectsNameMap.Add(refName, ret);

                arr[i] = ret;
            }
            return arr;
        }

        public string ReadString(XElement element, string name)
        {
            // if ele exist it is empty string.
            // if not exist it is SERIALIZE_IGNORED flag (null)
            var ele = GetPropertyElement(element, name);
            if (ele is null) return null;
            else if (ele.Value == "") return null;
            return ele.Value;
        }

        public bool ReadBoolean(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return false;
            return bool.Parse(ele.Value);
        }

        public byte ReadByte(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null) return 0;
            return byte.Parse(ele.Value);
        }

        public sbyte ReadSByte(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null) return 0;
            return sbyte.Parse(ele.Value);
        }

        public short ReadInt16(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null) return 0;
            return short.Parse(ele.Value);
        }

        public ushort ReadUInt16(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null) return 0;
            return ushort.Parse(ele.Value);
        }

        public uint ReadUInt32(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null) return 0;
            return uint.Parse(ele.Value);
        }

        public int ReadInt32(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null) return 0;
            return int.Parse(ele.Value);
        }

        public ulong ReadUInt64(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null) return 0;
            return ulong.Parse(ele.Value);
        }

        public long ReadInt64(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null) return 0;
            return long.Parse(ele.Value);
        }

        public Half ReadHalf(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return new Half();
            return Half.Parse(ele.Value);
        }

        public float ReadSingle(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return new float();
            return float.Parse(ele.Value);
        }

        private static readonly char[] SplitCharList = { '(', ')', ',', ' ', '\n', '\r', '\t' };
        private string[] normalize(string str)
        {
            return str.Split(SplitCharList, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).Select(x => x == "-1.#IND00" ? "0.0" : x).ToArray();
        }

        public Vector4 ReadVector4(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return new Vector4();

            var vec = normalize(ele.Value).Select(float.Parse).ToArray();
            return new Vector4(vec[0], vec[1], vec[2], vec[3]);
        }

        public Matrix4x4 ReadMatrix3(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return new Matrix4x4();

            var mat3 = normalize(ele.Value).Select(float.Parse).ToArray();
            return new Matrix4x4(mat3[0], mat3[1], mat3[2], 0,
                                 mat3[3], mat3[4], mat3[5], 0,
                                 mat3[6], mat3[7], mat3[8], 0,
                                 0, 0, 0, 1);
        }

        public Matrix4x4 ReadMatrix4(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return new Matrix4x4();

            var mat4 = normalize(ele.Value).Select(float.Parse).ToArray();
            return new Matrix4x4(mat4[0], mat4[1], mat4[2], mat4[3],
                                 mat4[4], mat4[5], mat4[6], mat4[7],
                                 mat4[8], mat4[9], mat4[10], mat4[11],
                                 mat4[12], mat4[13], mat4[14], mat4[15]);
        }

        public Matrix4x4 ReadTransform(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return new Matrix4x4();

            var trans = normalize(ele.Value).Select(float.Parse).ToArray();
            return new Matrix4x4(trans[0], trans[1], trans[2], 0,
                                 trans[3], trans[4], trans[5], 0,
                                 trans[6], trans[7], trans[8], 0,
                                 trans[9], trans[10], trans[11], 1);
        }

        public Matrix4x4 ReadRotation(XElement element, string name)
        {
            return ReadMatrix3(element, name);
        }

        public Matrix4x4 ReadQSTransform(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele == null)
                return new Matrix4x4();

            var qs = normalize(ele.Value).Select(float.Parse).ToArray();
            return new Matrix4x4(qs[0], qs[1], qs[2], 1,
                                 qs[3], qs[4], qs[5], qs[6],
                                 qs[7], qs[8], qs[9], 0,
                                 0, 0, 0, 0);
        }

        public Quaternion ReadQuaternion(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele == null) return new Quaternion();
            var quant = normalize(ele.Value).Select(float.Parse).ToArray();
            return new Quaternion(quant[0], quant[1], quant[2], quant[3]);
        }

        public XElement? ReadBaseArray(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return null;

            if (!int.TryParse(ele.Attribute("numelements")?.Value, out int count))
                throw new Exception($"numelemnets is not vaild number at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            if (count == 0)
                return null;

            return ele;
        }

        public List<string> ReadStringArray(XElement element, string name)
        {
            var ele = ReadBaseArray(element, name);
            if (ele is null)
                return new List<string>();

            return ele.Elements("hkcstring")
                      .Select(ele => ele.Value)
                      .ToList();
        }
        private static readonly char[] SplitSpaceList = { ' ', '\n', '\r', '\t' };
        public List<bool> ReadBooleanArray(XElement element, string name)
        {
            var ele = ReadBaseArray(element, name);
            if (ele is null)
                return new List<bool>();

            return ele.Value.Split(SplitSpaceList, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                            .Select(bool.Parse)
                            .ToList();
        }



        public List<byte> ReadByteArray(XElement element, string name)
        {
            var ele = ReadBaseArray(element, name);
            if (ele is null)
                return new List<byte>();

            return ele.Value.Split(SplitSpaceList, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                            .Select(byte.Parse)
                            .ToList();
        }

        public List<sbyte> ReadSByteArray(XElement element, string name)
        {
            var ele = ReadBaseArray(element, name);
            if (ele is null)
                return new List<sbyte>();

            return ele.Value.Split(SplitSpaceList, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                            .Select(sbyte.Parse)
                            .ToList();
        }

        public List<ushort> ReadUInt16Array(XElement element, string name)
        {
            var ele = ReadBaseArray(element, name);
            if (ele is null)
                return new List<ushort>();

            return ele.Value.Split(SplitSpaceList, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                            .Select(ushort.Parse)
                            .ToList();
        }

        public List<short> ReadInt16Array(XElement element, string name)
        {
            var ele = ReadBaseArray(element, name);
            if (ele is null)
                return new List<short>();

            return ele.Value.Split(SplitSpaceList, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                            .Select(short.Parse)
                            .ToList();
        }

        public List<uint> ReadUInt32Array(XElement element, string name)
        {
            var ele = ReadBaseArray(element, name);
            if (ele is null)
                return new List<uint>();

            return ele.Value.Split(SplitSpaceList, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                            .Select(uint.Parse)
                            .ToList();
        }

        public List<int> ReadInt32Array(XElement element, string name)
        {
            var ele = ReadBaseArray(element, name);
            if (ele is null)
                return new List<int>();

            return ele.Value.Split(SplitSpaceList, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                            .Select(int.Parse)
                            .ToList();
        }

        public List<ulong> ReadUInt64Array(XElement element, string name)
        {
            var ele = ReadBaseArray(element, name);
            if (ele is null)
                return new List<ulong>();

            return ele.Value.Split(SplitSpaceList, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                            .Select(ulong.Parse)
                            .ToList();
        }

        public List<long> ReadInt64Array(XElement element, string name)
        {
            var ele = ReadBaseArray(element, name);
            if (ele is null)
                return new List<long>();

            return ele.Value.Split(SplitSpaceList, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                            .Select(long.Parse)
                            .ToList();
        }
        public List<Half> ReadHalfArray(XElement element, string name)
        {
            var ele = ReadBaseArray(element, name);
            if (ele is null)
                return new List<Half>();

            return ele.Value.Split(SplitSpaceList, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                            .Select(Half.Parse)
                            .ToList();
        }

        public List<float> ReadSingleArray(XElement element, string name)
        {
            var ele = ReadBaseArray(element, name);
            if (ele is null)
                return new List<float>();

            return ele.Value.Split(SplitSpaceList, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                            .Select(float.Parse)
                            .ToList();
        }

        public List<Vector4> ReadVector4Array(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return new List<Vector4>();

            if (!int.TryParse(ele.Attribute("numelements")?.Value, out int count))
                throw new Exception($"numelemnets is not vaild number at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            if (count == 0)
                return new List<Vector4>();

            var vec4arr = normalize(ele.Value).Select(float.Parse).Chunk(4);
            if (vec4arr.Count() != count)
                throw new Exception($"Vector4 element mismatch. at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            return vec4arr.Select(vec => new Vector4(vec[0], vec[1], vec[2], vec[3]))
                          .ToList();
        }

        public List<Matrix4x4> ReadMatrix3Array(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return new List<Matrix4x4>();

            if (!int.TryParse(ele.Attribute("numelements")?.Value, out int count))
                throw new Exception($"numelemnets is not vaild number at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            if (count == 0)
                return new List<Matrix4x4>();

            var mat3Arr = normalize(ele.Value).Select(float.Parse).Chunk(9);
            if (mat3Arr.Count() != count)
                throw new Exception($"Matrix3 element mismatch. at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            return mat3Arr.Select(vec => new Matrix4x4(vec[0], vec[1], vec[2], 0,
                                                       vec[3], vec[4], vec[5], 0,
                                                       vec[6], vec[7], vec[8], 0,
                                                       0, 0, 0, 1)).ToList();
        }

        public List<Matrix4x4> ReadMatrix4Array(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return new List<Matrix4x4>();

            if (!int.TryParse(ele.Attribute("numelements")?.Value, out int count))
                throw new Exception($"numelemnets is not vaild number at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            if (count == 0)
                return new List<Matrix4x4>();

            var mat4Arr = normalize(ele.Value).Select(float.Parse).Chunk(16);
            if (mat4Arr.Count() != count)
                throw new Exception($"Matrix4 element mismatch. at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            return mat4Arr.Select(vec => new Matrix4x4(vec[0], vec[1], vec[2], vec[3],
                                                       vec[4], vec[5], vec[6], vec[7],
                                                       vec[8], vec[9], vec[10], vec[11],
                                                       vec[12], vec[13], vec[14], vec[15])).ToList();
        }

        public List<Matrix4x4> ReadTransformArray(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return new List<Matrix4x4>();

            if (!int.TryParse(ele.Attribute("numelements")?.Value, out int count))
                throw new Exception($"numelemnets is not vaild number at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            if (count == 0)
                return new List<Matrix4x4>();

            var transArr = normalize(ele.Value).Select(float.Parse).Chunk(12);
            if (transArr.Count() != count)
                throw new Exception($"Transform element mismatch. at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            return transArr.Select(trans => new Matrix4x4(trans[0], trans[1], trans[2], 0,
                                                          trans[3], trans[4], trans[5], 0,
                                                          trans[6], trans[7], trans[8], 0,
                                                          trans[9], trans[10], trans[11], 1)).ToList();
        }

        public List<Matrix4x4> ReadRotationArray(XElement element, string name)
        {
            return ReadMatrix3Array(element, name);
        }

        public List<Matrix4x4> ReadQSTransformArray(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele == null)
                return new List<Matrix4x4>();

            if (!int.TryParse(ele.Attribute("numelements")?.Value, out int count))
                throw new Exception($"numelemnets is not vaild number at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            if (count == 0)
                return new List<Matrix4x4>();

            var qsArr = normalize(ele.Value).Select(float.Parse).Chunk(10);
            if (qsArr.Count() != count)
                throw new Exception($"QSTransform element mismatch. at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            return qsArr.Select(qs => new Matrix4x4(qs[0], qs[1], qs[2], 0,
                                                    qs[3], qs[4], qs[5], qs[6],
                                                    qs[7], qs[8], qs[9], 0,
                                                    0, 0, 0, 0)).ToList();
        }

        public List<Quaternion> ReadQuaternionArray(XElement element, string name)
        {
            var ele = GetPropertyElement(element, name);
            if (ele == null)
                return new List<Quaternion>();

            if (!int.TryParse(ele.Attribute("numelements")?.Value, out int count))
                throw new Exception($"numelemnets is not vaild number at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            if (count == 0)
                return new List<Quaternion>();

            var quantArr = normalize(ele.Value).Select(float.Parse).Chunk(4);
            if (quantArr.Count() != count)
                throw new Exception($"Quaternion element missmatch. at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            return quantArr.Select(quant => new Quaternion(quant[0], quant[1], quant[2], quant[3])).ToList();
        }

        public V ReadFlag<TEnum, V>(XElement element, string name) where TEnum : Enum where V : IBinaryInteger<V>
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return (V)(IConvertible)0;
            return ele.Value.Split("|").ToFlagValue<TEnum, V>();
        }

        public TValue ReadEnum<TEnum, TValue>(XElement element, string name) where TEnum : Enum where TValue : IBinaryInteger<TValue>
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return (TValue)(IConvertible)0;
            return ele.Value.ToEnumValue<TEnum, TValue>();
        }

        #region C Style Array

        public XElement? ReadBaseCStyleArray(XElement element, string name, short length)
        {
            var ele = GetPropertyElement(element, name);
            if (ele is null)
                return null;
            return ele;
        }

        public bool[] ReadBooleanCStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new bool[length];

            var eles = ele.Value.Split(SplitSpaceList, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (eles.Length != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {eles.Length}");

            return eles.Select(e => e == "true").ToArray();
        }

        public byte[] ReadByteCStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new byte[length];

            var eles = ele.Value.Split(SplitSpaceList, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (eles.Length != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {eles.Length}");


            return eles.Select(byte.Parse).ToArray();
        }

        public sbyte[] ReadSByteCStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new sbyte[length];

            var eles = ele.Value.Split(SplitSpaceList, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (eles.Length != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {eles.Length}");

            return eles.Select(sbyte.Parse).ToArray();
        }

        public ushort[] ReadUInt16CStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new ushort[length];

            var eles = ele.Value.Split(SplitSpaceList, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (eles.Length != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {eles.Length}");

            return eles.Select(ushort.Parse).ToArray();
        }

        public short[] ReadInt16CStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new short[length];

            var eles = ele.Value.Split(SplitSpaceList, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (eles.Length != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {eles.Length}");

            return eles.Select(short.Parse).ToArray();
        }

        public uint[] ReadUInt32CStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new uint[length];

            var eles = ele.Value.Split(SplitSpaceList, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (eles.Length != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {eles.Length}");


            return eles.Select(uint.Parse).ToArray();
        }

        public int[] ReadInt32CStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new int[length];

            var eles = ele.Value.Split(SplitSpaceList, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (eles.Length != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {eles.Length}");

            return eles.Select(int.Parse).ToArray();
        }

        public ulong[] ReadUInt64CStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new ulong[length];

            var eles = ele.Value.Split(SplitSpaceList, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (eles.Length != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {eles.Length}");


            return eles.Select(ulong.Parse).ToArray();
        }

        public long[] ReadInt64CStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new long[length];

            var eles = ele.Value.Split(SplitSpaceList, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            if (eles.Length != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {eles.Length}");

            return eles.Select(long.Parse).ToArray();
        }

        public Half[] ReadHalfCStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new Half[length];

            var eles = ele.Value.Split(SplitSpaceList, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (eles.Length != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {eles.Length}");

            return eles.Select(Half.Parse).ToArray();
        }

        public float[] ReadSingleCStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new float[length];

            var eles = ele.Value.Split(SplitSpaceList, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (eles.Length != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {eles.Length}");

            return eles.Select(float.Parse).ToArray();
        }

        public Vector4[] ReadVector4CStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new Vector4[length];

            var vec4arr = normalize(ele.Value).Select(float.Parse).Chunk(4);
            if (vec4arr.Count() != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}");

            return vec4arr.Select(vec => new Vector4(vec[0], vec[1], vec[2], vec[3]))
                          .ToArray();
        }

        public Matrix4x4[] ReadMatrix3CStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new Matrix4x4[length];

            var arr = normalize(ele.Value).Select(float.Parse).Chunk(9);
            if (arr.Count() != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {arr.Count()}");

            return arr.Select(vec => new Matrix4x4(vec[0], vec[1], vec[2], 0,
                                                       vec[3], vec[4], vec[5], 0,
                                                       vec[6], vec[7], vec[8], 0,
                                                       0, 0, 0, 1)).ToArray();
        }

        public Matrix4x4[] ReadMatrix4CStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new Matrix4x4[length];

            var arr = normalize(ele.Value).Select(float.Parse).Chunk(16);
            if (arr.Count() != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {arr.Count()}");

            return arr.Select(vec => new Matrix4x4(vec[0], vec[1], vec[2], vec[3],
                                                   vec[4], vec[5], vec[6], vec[7],
                                                   vec[8], vec[9], vec[10], vec[11],
                                                   vec[12], vec[13], vec[14], vec[15])).ToArray(); ;
        }

        public Matrix4x4[] ReadTransformCStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new Matrix4x4[length];

            var arr = normalize(ele.Value).Select(float.Parse).Chunk(12);
            if (arr.Count() != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {arr.Count()}");

            return arr.Select(trans => new Matrix4x4(trans[0], trans[1], trans[2], 0,
                                                          trans[3], trans[4], trans[5], 0,
                                                          trans[6], trans[7], trans[8], 0,
                                                          trans[9], trans[10], trans[11], 1)).ToArray();
        }

        public Matrix4x4[] ReadRotationCStyleArray(XElement element, string name, short length)
        {
            return ReadMatrix3CStyleArray(element, name, length);
        }

        public Matrix4x4[] ReadQSTransformCStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new Matrix4x4[length];

            var arr = normalize(ele.Value).Select(float.Parse).Chunk(10);
            if (arr.Count() != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {arr.Count()}");

            return arr.Select(qs => new Matrix4x4(qs[0], qs[1], qs[2], 0,
                                                    qs[3], qs[4], qs[5], qs[6],
                                                    qs[7], qs[8], qs[9], 0,
                                                    0, 0, 0, 0)).ToArray();
        }

        public Quaternion[] ReadQuaternionCStyleArray(XElement element, string name, short length)
        {
            var ele = ReadBaseCStyleArray(element, name, length);
            if (ele is null)
                return new Quaternion[length];

            var arr = normalize(ele.Value).Select(float.Parse).Chunk(4);
            if (arr.Count() != length)
                throw new Exception($"Content's elements mismatch property require {length} at Line: {((IXmlLineInfo)element)?.LineNumber ?? -1}, Property: {name}, require: {length} got: {arr.Count()}");

            return arr.Select(quant => new Quaternion(quant[0], quant[1], quant[2], quant[3])).ToArray();
        }


        #endregion
    }
}
