using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbClientCharacterState Signatire: 0xa2624c97 size: 272 flags: FLAGS_NONE

    // m_deformableSkinIds m_class:  Type.TYPE_ARRAY Type.TYPE_UINT64 arrSize: 0 offset: 16 flags:  enum: 
    // m_rigidSkinIds m_class:  Type.TYPE_ARRAY Type.TYPE_UINT64 arrSize: 0 offset: 32 flags:  enum: 
    // m_externalEventIds m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 48 flags:  enum: 
    // m_auxiliaryInfo m_class: hkbAuxiliaryNodeInfo Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 64 flags:  enum: 
    // m_activeEventIds m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 80 flags:  enum: 
    // m_activeVariableIds m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 96 flags:  enum: 
    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_instanceName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 120 flags:  enum: 
    // m_templateName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_fullPathToProject m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 136 flags:  enum: 
    // m_behaviorData m_class: hkbBehaviorGraphData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 144 flags:  enum: 
    // m_behaviorInternalState m_class: hkbBehaviorGraphInternalState Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 152 flags:  enum: 
    // m_nodeIdToInternalStateMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 160 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_visible m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 168 flags:  enum: 
    // m_elapsedSimulationTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 172 flags:  enum: 
    // m_skeleton m_class: hkaSkeleton Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 176 flags:  enum: 
    // m_worldFromModel m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 192 flags:  enum: 
    // m_poseModelSpace m_class:  Type.TYPE_ARRAY Type.TYPE_QSTRANSFORM arrSize: 0 offset: 240 flags:  enum: 
    // m_rigidAttachmentTransforms m_class:  Type.TYPE_ARRAY Type.TYPE_QSTRANSFORM arrSize: 0 offset: 256 flags:  enum: 
    
    public class hkbClientCharacterState : hkReferencedObject
    {

        public List<ulong> m_deformableSkinIds;
        public List<ulong> m_rigidSkinIds;
        public List<short> m_externalEventIds;
        public List<hkbAuxiliaryNodeInfo> m_auxiliaryInfo;
        public List<short> m_activeEventIds;
        public List<short> m_activeVariableIds;
        public ulong m_characterId;
        public string m_instanceName;
        public string m_templateName;
        public string m_fullPathToProject;
        public hkbBehaviorGraphData /*pointer struct*/ m_behaviorData;
        public hkbBehaviorGraphInternalState /*pointer struct*/ m_behaviorInternalState;
        public dynamic /* POINTER VOID */ m_nodeIdToInternalStateMap;
        public bool m_visible;
        public float m_elapsedSimulationTime;
        public hkaSkeleton /*pointer struct*/ m_skeleton;
        public Matrix4x4 m_worldFromModel;
        public List<Matrix4x4> m_poseModelSpace;
        public List<Matrix4x4> m_rigidAttachmentTransforms;

        public override uint Signature => 0xa2624c97;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_deformableSkinIds = des.ReadUInt64Array(br);
            m_rigidSkinIds = des.ReadUInt64Array(br);
            m_externalEventIds = des.ReadInt16Array(br);
            m_auxiliaryInfo = des.ReadClassPointerArray<hkbAuxiliaryNodeInfo>(br);
            m_activeEventIds = des.ReadInt16Array(br);
            m_activeVariableIds = des.ReadInt16Array(br);
            m_characterId = br.ReadUInt64();
            m_instanceName = des.ReadStringPointer(br);
            m_templateName = des.ReadStringPointer(br);
            m_fullPathToProject = des.ReadStringPointer(br);
            m_behaviorData = des.ReadClassPointer<hkbBehaviorGraphData>(br);
            m_behaviorInternalState = des.ReadClassPointer<hkbBehaviorGraphInternalState>(br);
            des.ReadEmptyPointer(br);/* m_nodeIdToInternalStateMap POINTER VOID */
            m_visible = br.ReadBoolean();
            br.Position += 3;
            m_elapsedSimulationTime = br.ReadSingle();
            m_skeleton = des.ReadClassPointer<hkaSkeleton>(br);
            br.Position += 8;
            m_worldFromModel = des.ReadQSTransform(br);
            m_poseModelSpace = des.ReadQSTransformArray(br);
            m_rigidAttachmentTransforms = des.ReadQSTransformArray(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteUInt64Array(bw, m_deformableSkinIds);
            s.WriteUInt64Array(bw, m_rigidSkinIds);
            s.WriteInt16Array(bw, m_externalEventIds);
            s.WriteClassPointerArray<hkbAuxiliaryNodeInfo>(bw, m_auxiliaryInfo);
            s.WriteInt16Array(bw, m_activeEventIds);
            s.WriteInt16Array(bw, m_activeVariableIds);
            bw.WriteUInt64(m_characterId);
            s.WriteStringPointer(bw, m_instanceName);
            s.WriteStringPointer(bw, m_templateName);
            s.WriteStringPointer(bw, m_fullPathToProject);
            s.WriteClassPointer(bw, m_behaviorData);
            s.WriteClassPointer(bw, m_behaviorInternalState);
            s.WriteVoidPointer(bw);/* m_nodeIdToInternalStateMap POINTER VOID */
            bw.WriteBoolean(m_visible);
            bw.Position += 3;
            bw.WriteSingle(m_elapsedSimulationTime);
            s.WriteClassPointer(bw, m_skeleton);
            bw.Position += 8;
            s.WriteQSTransform(bw, m_worldFromModel);
            s.WriteQSTransformArray(bw, m_poseModelSpace);
            s.WriteQSTransformArray(bw, m_rigidAttachmentTransforms);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

