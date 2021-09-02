namespace HKX2
{
    public class hkaiPhysics2012BodyObstacleGenerator : hkaiObstacleGenerator
    {
        public hkpRigidBody m_rigidBody;

        public float m_velocityThreshold;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_velocityThreshold = br.ReadSingle();
            br.ReadUInt32();
            m_rigidBody = des.ReadClassPointer<hkpRigidBody>(br);
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_velocityThreshold);
            bw.WriteUInt32(0);
            s.WriteClassPointer(bw, m_rigidBody);
            bw.WriteUInt64(0);
        }
    }
}