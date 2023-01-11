using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbVariableValueSet Signatire: 0x27812d8d size: 64 flags: FLAGS_NONE

    // m_wordVariableValues m_class: hkbVariableValue Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_quadVariableValues m_class:  Type.TYPE_ARRAY Type.TYPE_VECTOR4 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_variantVariableValues m_class: hkReferencedObject Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    public partial class hkbVariableValueSet : hkReferencedObject
    {
        public IList<hkbVariableValue> m_wordVariableValues { set; get; } = new List<hkbVariableValue>();
        public IList<Vector4> m_quadVariableValues { set; get; } = new List<Vector4>();
        public IList<hkReferencedObject> m_variantVariableValues { set; get; } = new List<hkReferencedObject>();

        public override uint Signature => 0x27812d8d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_wordVariableValues = des.ReadClassArray<hkbVariableValue>(br);
            m_quadVariableValues = des.ReadVector4Array(br);
            m_variantVariableValues = des.ReadClassPointerArray<hkReferencedObject>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_wordVariableValues);
            s.WriteVector4Array(bw, m_quadVariableValues);
            s.WriteClassPointerArray(bw, m_variantVariableValues);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_wordVariableValues = xd.ReadClassArray<hkbVariableValue>(xe, nameof(m_wordVariableValues));
            m_quadVariableValues = xd.ReadVector4Array(xe, nameof(m_quadVariableValues));
            m_variantVariableValues = xd.ReadClassPointerArray<hkReferencedObject>(xe, nameof(m_variantVariableValues));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbVariableValue>(xe, nameof(m_wordVariableValues), m_wordVariableValues);
            xs.WriteVector4Array(xe, nameof(m_quadVariableValues), m_quadVariableValues);
            xs.WriteClassPointerArray<hkReferencedObject>(xe, nameof(m_variantVariableValues), m_variantVariableValues);
        }
    }
}

