using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbCharacterData Signatire: 0x300d6808 size: 176 flags: FLAGS_NONE

    // m_characterControllerInfo m_class: hkbCharacterDataCharacterControllerInfo Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_modelUpMS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_modelForwardMS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_modelRightMS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_characterPropertyInfos m_class: hkbVariableInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_numBonesPerLod m_class:  Type.TYPE_ARRAY Type.TYPE_INT32 arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_characterPropertyValues m_class: hkbVariableValueSet Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_footIkDriverInfo m_class: hkbFootIkDriverInfo Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 136 flags: FLAGS_NONE enum: 
    // m_handIkDriverInfo m_class: hkbHandIkDriverInfo Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_stringData m_class: hkbCharacterStringData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 152 flags: FLAGS_NONE enum: 
    // m_mirroredSkeletonInfo m_class: hkbMirroredSkeletonInfo Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 160 flags: FLAGS_NONE enum: 
    // m_scale m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 168 flags: FLAGS_NONE enum: 
    // m_numHands m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 172 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_numFloatSlots m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 174 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbCharacterData : hkReferencedObject
    {
        public hkbCharacterDataCharacterControllerInfo m_characterControllerInfo;
        public Vector4 m_modelUpMS;
        public Vector4 m_modelForwardMS;
        public Vector4 m_modelRightMS;
        public List<hkbVariableInfo> m_characterPropertyInfos;
        public List<int> m_numBonesPerLod;
        public hkbVariableValueSet m_characterPropertyValues;
        public hkbFootIkDriverInfo m_footIkDriverInfo;
        public hkbHandIkDriverInfo m_handIkDriverInfo;
        public hkbCharacterStringData m_stringData;
        public hkbMirroredSkeletonInfo m_mirroredSkeletonInfo;
        public float m_scale;
        public short m_numHands;
        public short m_numFloatSlots;

        public override uint Signature => 0x300d6808;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_characterControllerInfo = new hkbCharacterDataCharacterControllerInfo();
            m_characterControllerInfo.Read(des, br);
            br.Position += 8;
            m_modelUpMS = br.ReadVector4();
            m_modelForwardMS = br.ReadVector4();
            m_modelRightMS = br.ReadVector4();
            m_characterPropertyInfos = des.ReadClassArray<hkbVariableInfo>(br);
            m_numBonesPerLod = des.ReadInt32Array(br);
            m_characterPropertyValues = des.ReadClassPointer<hkbVariableValueSet>(br);
            m_footIkDriverInfo = des.ReadClassPointer<hkbFootIkDriverInfo>(br);
            m_handIkDriverInfo = des.ReadClassPointer<hkbHandIkDriverInfo>(br);
            m_stringData = des.ReadClassPointer<hkbCharacterStringData>(br);
            m_mirroredSkeletonInfo = des.ReadClassPointer<hkbMirroredSkeletonInfo>(br);
            m_scale = br.ReadSingle();
            m_numHands = br.ReadInt16();
            m_numFloatSlots = br.ReadInt16();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_characterControllerInfo.Write(s, bw);
            bw.Position += 8;
            bw.WriteVector4(m_modelUpMS);
            bw.WriteVector4(m_modelForwardMS);
            bw.WriteVector4(m_modelRightMS);
            s.WriteClassArray<hkbVariableInfo>(bw, m_characterPropertyInfos);
            s.WriteInt32Array(bw, m_numBonesPerLod);
            s.WriteClassPointer(bw, m_characterPropertyValues);
            s.WriteClassPointer(bw, m_footIkDriverInfo);
            s.WriteClassPointer(bw, m_handIkDriverInfo);
            s.WriteClassPointer(bw, m_stringData);
            s.WriteClassPointer(bw, m_mirroredSkeletonInfo);
            bw.WriteSingle(m_scale);
            bw.WriteInt16(m_numHands);
            bw.WriteInt16(m_numFloatSlots);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkbCharacterDataCharacterControllerInfo>(xe, nameof(m_characterControllerInfo), m_characterControllerInfo);
            xs.WriteVector4(xe, nameof(m_modelUpMS), m_modelUpMS);
            xs.WriteVector4(xe, nameof(m_modelForwardMS), m_modelForwardMS);
            xs.WriteVector4(xe, nameof(m_modelRightMS), m_modelRightMS);
            xs.WriteClassArray<hkbVariableInfo>(xe, nameof(m_characterPropertyInfos), m_characterPropertyInfos);
            xs.WriteNumberArray(xe, nameof(m_numBonesPerLod), m_numBonesPerLod);
            xs.WriteClassPointer(xe, nameof(m_characterPropertyValues), m_characterPropertyValues);
            xs.WriteClassPointer(xe, nameof(m_footIkDriverInfo), m_footIkDriverInfo);
            xs.WriteClassPointer(xe, nameof(m_handIkDriverInfo), m_handIkDriverInfo);
            xs.WriteClassPointer(xe, nameof(m_stringData), m_stringData);
            xs.WriteClassPointer(xe, nameof(m_mirroredSkeletonInfo), m_mirroredSkeletonInfo);
            xs.WriteFloat(xe, nameof(m_scale), m_scale);
            xs.WriteSerializeIgnored(xe, nameof(m_numHands));
            xs.WriteSerializeIgnored(xe, nameof(m_numFloatSlots));
        }
    }
}

