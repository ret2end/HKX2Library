using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbCharacterSteppedInfo Signatire: 0x2eda84f8 size: 112 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_deltaTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_worldFromModel m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_poseModelSpace m_class:  Type.TYPE_ARRAY Type.TYPE_QSTRANSFORM arrSize: 0 offset: 80 flags:  enum: 
    // m_rigidAttachmentTransforms m_class:  Type.TYPE_ARRAY Type.TYPE_QSTRANSFORM arrSize: 0 offset: 96 flags:  enum: 
    
    public class hkbCharacterSteppedInfo : hkReferencedObject
    {

        public ulong m_characterId;
        public float m_deltaTime;
        public Matrix4x4 m_worldFromModel;
        public List<Matrix4x4> m_poseModelSpace;
        public List<Matrix4x4> m_rigidAttachmentTransforms;

        public override uint Signature => 0x2eda84f8;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_deltaTime = br.ReadSingle();
            br.Position += 4;
            m_worldFromModel = des.ReadQSTransform(br);
            m_poseModelSpace = des.ReadQSTransformArray(br);
            m_rigidAttachmentTransforms = des.ReadQSTransformArray(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            bw.WriteSingle(m_deltaTime);
            bw.Position += 4;
            s.WriteQSTransform(bw, m_worldFromModel);
            s.WriteQSTransformArray(bw, m_poseModelSpace);
            s.WriteQSTransformArray(bw, m_rigidAttachmentTransforms);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

