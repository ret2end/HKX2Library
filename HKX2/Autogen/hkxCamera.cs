using System.Numerics;

namespace HKX2
{
    public class hkxCamera : hkReferencedObject
    {
        public float m_far;
        public Vector4 m_focus;
        public float m_fov;

        public Vector4 m_from;
        public bool m_leftHanded;
        public float m_near;
        public Vector4 m_up;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_from = des.ReadVector4(br);
            m_focus = des.ReadVector4(br);
            m_up = des.ReadVector4(br);
            m_fov = br.ReadSingle();
            m_far = br.ReadSingle();
            m_near = br.ReadSingle();
            m_leftHanded = br.ReadBoolean();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVector4(bw, m_from);
            s.WriteVector4(bw, m_focus);
            s.WriteVector4(bw, m_up);
            bw.WriteSingle(m_fov);
            bw.WriteSingle(m_far);
            bw.WriteSingle(m_near);
            bw.WriteBoolean(m_leftHanded);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}