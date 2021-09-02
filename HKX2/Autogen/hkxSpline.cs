using System.Collections.Generic;

namespace HKX2
{
    public enum ControlType
    {
        BEZIER_SMOOTH = 0,
        BEZIER_CORNER = 1,
        LINEAR = 2,
        CUSTOM = 3
    }

    public class hkxSpline : hkReferencedObject
    {
        public List<hkxSplineControlPoint> m_controlPoints;
        public bool m_isClosed;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_controlPoints = des.ReadClassArray<hkxSplineControlPoint>(br);
            m_isClosed = br.ReadBoolean();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_controlPoints);
            bw.WriteBoolean(m_isClosed);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}