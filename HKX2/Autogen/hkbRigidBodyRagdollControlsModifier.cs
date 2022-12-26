using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbRigidBodyRagdollControlsModifier Signatire: 0xaa87d1eb size: 160 flags: FLAGS_NONE

    // m_controlData m_class: hkbRigidBodyRagdollControlData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_bones m_class: hkbBoneIndexArray Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 144 flags:  enum: 
    
    public class hkbRigidBodyRagdollControlsModifier : hkbModifier
    {

        public hkbRigidBodyRagdollControlData/*struct void*/ m_controlData;
        public hkbBoneIndexArray /*pointer struct*/ m_bones;

        public override uint Signature => 0xaa87d1eb;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_controlData = new hkbRigidBodyRagdollControlData();
            m_controlData.Read(des,br);
            m_bones = des.ReadClassPointer<hkbBoneIndexArray>(br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_controlData.Write(s, bw);
            s.WriteClassPointer(bw, m_bones);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

