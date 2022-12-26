using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBehaviorGraph Signatire: 0xb1218f86 size: 304 flags: FLAGS_NONE

    // m_variableMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 72 flags:  enum: VariableMode
    // m_uniqueIdPool m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 80 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_idToStateMachineTemplateMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 96 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_mirroredExternalIdMap m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 104 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_pseudoRandomGenerator m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 120 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_rootGenerator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 128 flags:  enum: 
    // m_data m_class: hkbBehaviorGraphData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 136 flags:  enum: 
    // m_rootGeneratorClone m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 144 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_activeNodes m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 152 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_activeNodeTemplateToIndexMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 160 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_activeNodesChildrenIndices m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 168 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_globalTransitionData m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 176 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_eventIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 184 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_attributeIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 192 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_variableIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 200 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_characterPropertyIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 208 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_variableValueSet m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 216 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_nodeTemplateToCloneMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 224 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_nodeCloneToTemplateMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 232 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_stateListenerTemplateToCloneMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 240 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_nodePartitionInfo m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 248 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_numIntermediateOutputs m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 256 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_jobs m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 264 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_allPartitionMemory m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 280 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_numStaticNodes m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 296 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_nextUniqueId m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 298 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_isActive m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 300 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_isLinked m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 301 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_updateActiveNodes m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 302 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_stateOrTransitionChanged m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 303 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbBehaviorGraph : hkbGenerator
    {

        public sbyte m_variableMode;
        public List<ulong> m_uniqueIdPool;
        public dynamic /* POINTER VOID */ m_idToStateMachineTemplateMap;
        public List<ulong> m_mirroredExternalIdMap;
        public dynamic /* POINTER VOID */ m_pseudoRandomGenerator;
        public hkbGenerator /*pointer struct*/ m_rootGenerator;
        public hkbBehaviorGraphData /*pointer struct*/ m_data;
        public dynamic /* POINTER VOID */ m_rootGeneratorClone;
        public dynamic /* POINTER VOID */ m_activeNodes;
        public dynamic /* POINTER VOID */ m_activeNodeTemplateToIndexMap;
        public dynamic /* POINTER VOID */ m_activeNodesChildrenIndices;
        public dynamic /* POINTER VOID */ m_globalTransitionData;
        public dynamic /* POINTER VOID */ m_eventIdMap;
        public dynamic /* POINTER VOID */ m_attributeIdMap;
        public dynamic /* POINTER VOID */ m_variableIdMap;
        public dynamic /* POINTER VOID */ m_characterPropertyIdMap;
        public dynamic /* POINTER VOID */ m_variableValueSet;
        public dynamic /* POINTER VOID */ m_nodeTemplateToCloneMap;
        public dynamic /* POINTER VOID */ m_nodeCloneToTemplateMap;
        public dynamic /* POINTER VOID */ m_stateListenerTemplateToCloneMap;
        public dynamic /* POINTER VOID */ m_nodePartitionInfo;
        public int m_numIntermediateOutputs;
        //public List<> m_jobs;
        //public List<> m_allPartitionMemory;
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
            des.ReadEmptyArray(br); //m_uniqueIdPool
            des.ReadEmptyPointer(br);/* m_idToStateMachineTemplateMap POINTER VOID */
            des.ReadEmptyArray(br); //m_mirroredExternalIdMap
            des.ReadEmptyPointer(br);/* m_pseudoRandomGenerator POINTER VOID */
            m_rootGenerator = des.ReadClassPointer<hkbGenerator>(br);
            m_data = des.ReadClassPointer<hkbBehaviorGraphData>(br);
            des.ReadEmptyPointer(br);/* m_rootGeneratorClone POINTER VOID */
            des.ReadEmptyPointer(br);/* m_activeNodes POINTER VOID */
            des.ReadEmptyPointer(br);/* m_activeNodeTemplateToIndexMap POINTER VOID */
            des.ReadEmptyPointer(br);/* m_activeNodesChildrenIndices POINTER VOID */
            des.ReadEmptyPointer(br);/* m_globalTransitionData POINTER VOID */
            des.ReadEmptyPointer(br);/* m_eventIdMap POINTER VOID */
            des.ReadEmptyPointer(br);/* m_attributeIdMap POINTER VOID */
            des.ReadEmptyPointer(br);/* m_variableIdMap POINTER VOID */
            des.ReadEmptyPointer(br);/* m_characterPropertyIdMap POINTER VOID */
            des.ReadEmptyPointer(br);/* m_variableValueSet POINTER VOID */
            des.ReadEmptyPointer(br);/* m_nodeTemplateToCloneMap POINTER VOID */
            des.ReadEmptyPointer(br);/* m_nodeCloneToTemplateMap POINTER VOID */
            des.ReadEmptyPointer(br);/* m_stateListenerTemplateToCloneMap POINTER VOID */
            des.ReadEmptyPointer(br);/* m_nodePartitionInfo POINTER VOID */
            m_numIntermediateOutputs = br.ReadInt32();
            br.Position += 4;
            //m_jobs = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);
            //m_allPartitionMemory = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);
            m_numStaticNodes = br.ReadInt16();
            m_nextUniqueId = br.ReadInt16();
            m_isActive = br.ReadBoolean();
            m_isLinked = br.ReadBoolean();
            m_updateActiveNodes = br.ReadBoolean();
            m_stateOrTransitionChanged = br.ReadBoolean();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteSByte(bw, m_variableMode);
            bw.Position += 7;
            s.WriteVoidArray(bw); // m_uniqueIdPool
            s.WriteVoidPointer(bw);/* m_idToStateMachineTemplateMap POINTER VOID */
            s.WriteVoidArray(bw); // m_mirroredExternalIdMap
            s.WriteVoidPointer(bw);/* m_pseudoRandomGenerator POINTER VOID */
            s.WriteClassPointer(bw, m_rootGenerator);
            s.WriteClassPointer(bw, m_data);
            s.WriteVoidPointer(bw);/* m_rootGeneratorClone POINTER VOID */
            s.WriteVoidPointer(bw);/* m_activeNodes POINTER VOID */
            s.WriteVoidPointer(bw);/* m_activeNodeTemplateToIndexMap POINTER VOID */
            s.WriteVoidPointer(bw);/* m_activeNodesChildrenIndices POINTER VOID */
            s.WriteVoidPointer(bw);/* m_globalTransitionData POINTER VOID */
            s.WriteVoidPointer(bw);/* m_eventIdMap POINTER VOID */
            s.WriteVoidPointer(bw);/* m_attributeIdMap POINTER VOID */
            s.WriteVoidPointer(bw);/* m_variableIdMap POINTER VOID */
            s.WriteVoidPointer(bw);/* m_characterPropertyIdMap POINTER VOID */
            s.WriteVoidPointer(bw);/* m_variableValueSet POINTER VOID */
            s.WriteVoidPointer(bw);/* m_nodeTemplateToCloneMap POINTER VOID */
            s.WriteVoidPointer(bw);/* m_nodeCloneToTemplateMap POINTER VOID */
            s.WriteVoidPointer(bw);/* m_stateListenerTemplateToCloneMap POINTER VOID */
            s.WriteVoidPointer(bw);/* m_nodePartitionInfo POINTER VOID */
            bw.WriteInt32(m_numIntermediateOutputs);
            bw.Position += 4;
            //s.WriteClassPointerArray<>(bw, m_jobs);
            s.WriteVoidArray(bw);
            //s.WriteClassPointerArray<>(bw, m_allPartitionMemory);
            s.WriteVoidArray(bw);
            bw.WriteInt16(m_numStaticNodes);
            bw.WriteInt16(m_nextUniqueId);
            bw.WriteBoolean(m_isActive);
            bw.WriteBoolean(m_isLinked);
            bw.WriteBoolean(m_updateActiveNodes);
            bw.WriteBoolean(m_stateOrTransitionChanged);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

