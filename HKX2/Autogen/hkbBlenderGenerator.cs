using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbBlenderGenerator Signatire: 0x22df7147 size: 160 flags: FLAGS_NONE

    // m_referencePoseWeightThreshold m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_blendParameter m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 76 flags: FLAGS_NONE enum: 
    // m_minCyclicBlendParameter m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_maxCyclicBlendParameter m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags: FLAGS_NONE enum: 
    // m_indexOfSyncMasterChild m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_flags m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 90 flags: FLAGS_NONE enum: 
    // m_subtractLastChild m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 92 flags: FLAGS_NONE enum: 
    // m_children m_class: hkbBlenderGeneratorChild Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_childrenInternalStates m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 112 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_sortedChildren m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 128 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_endIntervalWeight m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 144 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_numActiveChildren m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 148 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_beginIntervalIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 152 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_endIntervalIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 154 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_initSync m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 156 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_doSubtractiveBlend m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 157 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbBlenderGenerator : hkbGenerator
    {
        public float m_referencePoseWeightThreshold;
        public float m_blendParameter;
        public float m_minCyclicBlendParameter;
        public float m_maxCyclicBlendParameter;
        public short m_indexOfSyncMasterChild;
        public short m_flags;
        public bool m_subtractLastChild;
        public List<hkbBlenderGeneratorChild> m_children;
        public List<dynamic> m_childrenInternalStates;
        public List<dynamic> m_sortedChildren;
        public float m_endIntervalWeight;
        public int m_numActiveChildren;
        public short m_beginIntervalIndex;
        public short m_endIntervalIndex;
        public bool m_initSync;
        public bool m_doSubtractiveBlend;

        public override uint Signature => 0x22df7147;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_referencePoseWeightThreshold = br.ReadSingle();
            m_blendParameter = br.ReadSingle();
            m_minCyclicBlendParameter = br.ReadSingle();
            m_maxCyclicBlendParameter = br.ReadSingle();
            m_indexOfSyncMasterChild = br.ReadInt16();
            m_flags = br.ReadInt16();
            m_subtractLastChild = br.ReadBoolean();
            br.Position += 3;
            m_children = des.ReadClassPointerArray<hkbBlenderGeneratorChild>(br);
            des.ReadEmptyArray(br);
            des.ReadEmptyArray(br);
            m_endIntervalWeight = br.ReadSingle();
            m_numActiveChildren = br.ReadInt32();
            m_beginIntervalIndex = br.ReadInt16();
            m_endIntervalIndex = br.ReadInt16();
            m_initSync = br.ReadBoolean();
            m_doSubtractiveBlend = br.ReadBoolean();
            br.Position += 2;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_referencePoseWeightThreshold);
            bw.WriteSingle(m_blendParameter);
            bw.WriteSingle(m_minCyclicBlendParameter);
            bw.WriteSingle(m_maxCyclicBlendParameter);
            bw.WriteInt16(m_indexOfSyncMasterChild);
            bw.WriteInt16(m_flags);
            bw.WriteBoolean(m_subtractLastChild);
            bw.Position += 3;
            s.WriteClassPointerArray<hkbBlenderGeneratorChild>(bw, m_children);
            s.WriteVoidArray(bw);
            s.WriteVoidArray(bw);
            bw.WriteSingle(m_endIntervalWeight);
            bw.WriteInt32(m_numActiveChildren);
            bw.WriteInt16(m_beginIntervalIndex);
            bw.WriteInt16(m_endIntervalIndex);
            bw.WriteBoolean(m_initSync);
            bw.WriteBoolean(m_doSubtractiveBlend);
            bw.Position += 2;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloat(xe, nameof(m_referencePoseWeightThreshold), m_referencePoseWeightThreshold);
            xs.WriteFloat(xe, nameof(m_blendParameter), m_blendParameter);
            xs.WriteFloat(xe, nameof(m_minCyclicBlendParameter), m_minCyclicBlendParameter);
            xs.WriteFloat(xe, nameof(m_maxCyclicBlendParameter), m_maxCyclicBlendParameter);
            xs.WriteNumber(xe, nameof(m_indexOfSyncMasterChild), m_indexOfSyncMasterChild);
            xs.WriteNumber(xe, nameof(m_flags), m_flags);
            xs.WriteBoolean(xe, nameof(m_subtractLastChild), m_subtractLastChild);
            xs.WriteClassPointerArray<hkbBlenderGeneratorChild>(xe, nameof(m_children), m_children);
            xs.WriteSerializeIgnored(xe, nameof(m_childrenInternalStates));
            xs.WriteSerializeIgnored(xe, nameof(m_sortedChildren));
            xs.WriteSerializeIgnored(xe, nameof(m_endIntervalWeight));
            xs.WriteSerializeIgnored(xe, nameof(m_numActiveChildren));
            xs.WriteSerializeIgnored(xe, nameof(m_beginIntervalIndex));
            xs.WriteSerializeIgnored(xe, nameof(m_endIntervalIndex));
            xs.WriteSerializeIgnored(xe, nameof(m_initSync));
            xs.WriteSerializeIgnored(xe, nameof(m_doSubtractiveBlend));
        }
    }
}

