namespace HKX2
{
    public class hkaiPhysics2012BodySilhouetteGenerator : hkaiPhysicsBodySilhouetteGeneratorBase
    {
        public hkpRigidBody m_rigidBody;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_rigidBody = des.ReadClassPointer<hkpRigidBody>(br);
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_rigidBody);
            bw.WriteUInt64(0);
        }
    }
}