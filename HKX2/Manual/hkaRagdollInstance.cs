using System.Collections.Generic;

namespace HKX2
{
    public class hkaRagdollInstance : hkReferencedObject
    {
        public List<int> m_boneToRigidBodyMap;
        public List<hkpConstraintInstance> m_constraints;

        public List<hkpRigidBody> m_rigidBodies;
        public hkaSkeleton m_skeleton;
        public override uint Signature => 0x5448F464;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_rigidBodies = des.ReadClassPointerArray<hkpRigidBody>(br);
            m_constraints = des.ReadClassPointerArray<hkpConstraintInstance>(br);
            m_boneToRigidBodyMap = des.ReadInt32Array(br);
            m_skeleton = des.ReadClassPointer<hkaSkeleton>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_rigidBodies);
            s.WriteClassPointerArray(bw, m_constraints);
            s.WriteInt32Array(bw, m_boneToRigidBodyMap);
            s.WriteClassPointer(bw, m_skeleton);
        }
    }
}