using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbBehaviorGraph Signatire: 0xb1218f86 size: 304 flags: FLAGS_NONE

    // m_variableMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 72 flags: FLAGS_NONE enum: VariableMode
    // m_uniqueIdPool m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 80 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_idToStateMachineTemplateMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 96 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_mirroredExternalIdMap m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 104 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_pseudoRandomGenerator m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 120 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_rootGenerator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_data m_class: hkbBehaviorGraphData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 136 flags: FLAGS_NONE enum: 
    // m_rootGeneratorClone m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 144 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_activeNodes m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 152 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_activeNodeTemplateToIndexMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 160 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_activeNodesChildrenIndices m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 168 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_globalTransitionData m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 176 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_eventIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 184 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_attributeIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 192 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_variableIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 200 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_characterPropertyIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 208 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_variableValueSet m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 216 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_nodeTemplateToCloneMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 224 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_nodeCloneToTemplateMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 232 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_stateListenerTemplateToCloneMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 240 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_nodePartitionInfo m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 248 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_numIntermediateOutputs m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 256 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_jobs m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 264 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_allPartitionMemory m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 280 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_numStaticNodes m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 296 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_nextUniqueId m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 298 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_isActive m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 300 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_isLinked m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 301 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_updateActiveNodes m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 302 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_stateOrTransitionChanged m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 303 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbBehaviorGraph : hkbGenerator
    {
        public sbyte m_variableMode;
        public List<dynamic> m_uniqueIdPool;
        public dynamic m_idToStateMachineTemplateMap;
        public List<dynamic> m_mirroredExternalIdMap;
        public dynamic m_pseudoRandomGenerator;
        public hkbGenerator m_rootGenerator;
        public hkbBehaviorGraphData m_data;
        public dynamic m_rootGeneratorClone;
        public dynamic m_activeNodes;
        public dynamic m_activeNodeTemplateToIndexMap;
        public dynamic m_activeNodesChildrenIndices;
        public dynamic m_globalTransitionData;
        public dynamic m_eventIdMap;
        public dynamic m_attributeIdMap;
        public dynamic m_variableIdMap;
        public dynamic m_characterPropertyIdMap;
        public dynamic m_variableValueSet;
        public dynamic m_nodeTemplateToCloneMap;
        public dynamic m_nodeCloneToTemplateMap;
        public dynamic m_stateListenerTemplateToCloneMap;
        public dynamic m_nodePartitionInfo;
        public int m_numIntermediateOutputs;
        public List<dynamic> m_jobs;
        public List<dynamic> m_allPartitionMemory;
        public short m_numStaticNodes;
        public short m_nextUniqueId;
        public bool m_isActive;
        public bool m_isLinked;
        public bool m_updateActiveNodes;
        public bool m_stateOrTransitionChanged;

        public override uint Signature => 0xb1218f86;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_variableMode = br.ReadSByte();
            br.Position += 7;
            des.ReadEmptyArray(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyArray(br);
            des.ReadEmptyPointer(br);
            m_rootGenerator = des.ReadClassPointer<hkbGenerator>(br);
            m_data = des.ReadClassPointer<hkbBehaviorGraphData>(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            m_numIntermediateOutputs = br.ReadInt32();
            br.Position += 4;
            des.ReadEmptyArray(br);
            des.ReadEmptyArray(br);
            m_numStaticNodes = br.ReadInt16();
            m_nextUniqueId = br.ReadInt16();
            m_isActive = br.ReadBoolean();
            m_isLinked = br.ReadBoolean();
            m_updateActiveNodes = br.ReadBoolean();
            m_stateOrTransitionChanged = br.ReadBoolean();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteSByte(bw, m_variableMode);
            bw.Position += 7;
            s.WriteVoidArray(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidArray(bw);
            s.WriteVoidPointer(bw);
            s.WriteClassPointer(bw, m_rootGenerator);
            s.WriteClassPointer(bw, m_data);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            bw.WriteInt32(m_numIntermediateOutputs);
            bw.Position += 4;
            s.WriteVoidArray(bw);
            s.WriteVoidArray(bw);
            bw.WriteInt16(m_numStaticNodes);
            bw.WriteInt16(m_nextUniqueId);
            bw.WriteBoolean(m_isActive);
            bw.WriteBoolean(m_isLinked);
            bw.WriteBoolean(m_updateActiveNodes);
            bw.WriteBoolean(m_stateOrTransitionChanged);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteEnum<VariableMode, sbyte>(xe, nameof(m_variableMode), m_variableMode);
            xs.WriteSerializeIgnored(xe, nameof(m_uniqueIdPool));
            xs.WriteSerializeIgnored(xe, nameof(m_idToStateMachineTemplateMap));
            xs.WriteSerializeIgnored(xe, nameof(m_mirroredExternalIdMap));
            xs.WriteSerializeIgnored(xe, nameof(m_pseudoRandomGenerator));
            xs.WriteClassPointer(xe, nameof(m_rootGenerator), m_rootGenerator);
            xs.WriteClassPointer(xe, nameof(m_data), m_data);
            xs.WriteSerializeIgnored(xe, nameof(m_rootGeneratorClone));
            xs.WriteSerializeIgnored(xe, nameof(m_activeNodes));
            xs.WriteSerializeIgnored(xe, nameof(m_activeNodeTemplateToIndexMap));
            xs.WriteSerializeIgnored(xe, nameof(m_activeNodesChildrenIndices));
            xs.WriteSerializeIgnored(xe, nameof(m_globalTransitionData));
            xs.WriteSerializeIgnored(xe, nameof(m_eventIdMap));
            xs.WriteSerializeIgnored(xe, nameof(m_attributeIdMap));
            xs.WriteSerializeIgnored(xe, nameof(m_variableIdMap));
            xs.WriteSerializeIgnored(xe, nameof(m_characterPropertyIdMap));
            xs.WriteSerializeIgnored(xe, nameof(m_variableValueSet));
            xs.WriteSerializeIgnored(xe, nameof(m_nodeTemplateToCloneMap));
            xs.WriteSerializeIgnored(xe, nameof(m_nodeCloneToTemplateMap));
            xs.WriteSerializeIgnored(xe, nameof(m_stateListenerTemplateToCloneMap));
            xs.WriteSerializeIgnored(xe, nameof(m_nodePartitionInfo));
            xs.WriteSerializeIgnored(xe, nameof(m_numIntermediateOutputs));
            xs.WriteSerializeIgnored(xe, nameof(m_jobs));
            xs.WriteSerializeIgnored(xe, nameof(m_allPartitionMemory));
            xs.WriteSerializeIgnored(xe, nameof(m_numStaticNodes));
            xs.WriteSerializeIgnored(xe, nameof(m_nextUniqueId));
            xs.WriteSerializeIgnored(xe, nameof(m_isActive));
            xs.WriteSerializeIgnored(xe, nameof(m_isLinked));
            xs.WriteSerializeIgnored(xe, nameof(m_updateActiveNodes));
            xs.WriteSerializeIgnored(xe, nameof(m_stateOrTransitionChanged));
        }
    }
}

