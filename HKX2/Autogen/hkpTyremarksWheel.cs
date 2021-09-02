using System.Collections.Generic;

namespace HKX2
{
    public class hkpTyremarksWheel : hkReferencedObject
    {
        public int m_currentPosition;
        public int m_numPoints;
        public List<hkpTyremarkPoint> m_tyremarkPoints;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_currentPosition = br.ReadInt32();
            m_numPoints = br.ReadInt32();
            br.ReadUInt32();
            m_tyremarkPoints = des.ReadClassArray<hkpTyremarkPoint>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(m_currentPosition);
            bw.WriteInt32(m_numPoints);
            bw.WriteUInt32(0);
            s.WriteClassArray(bw, m_tyremarkPoints);
        }
    }
}