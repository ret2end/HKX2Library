using System.Numerics;

namespace HKX2
{
    public class hkpDisplayBindingDataRigidBody : hkReferencedObject
    {
        public hkReferencedObject m_displayObjectPtr;

        public hkpRigidBody m_rigidBody;
        public Matrix4x4 m_rigidBodyFromDisplayObjectTransform;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_rigidBody = des.ReadClassPointer<hkpRigidBody>(br);
            m_displayObjectPtr = des.ReadClassPointer<hkReferencedObject>(br);
            m_rigidBodyFromDisplayObjectTransform = des.ReadMatrix4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_rigidBody);
            s.WriteClassPointer(bw, m_displayObjectPtr);
            s.WriteMatrix4(bw, m_rigidBodyFromDisplayObjectTransform);
        }
    }
}