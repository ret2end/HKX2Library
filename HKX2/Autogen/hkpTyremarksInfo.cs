using System.Collections.Generic;

namespace HKX2
{
    public class hkpTyremarksInfo : hkReferencedObject
    {
        public float m_maxTyremarkEnergy;

        public float m_minTyremarkEnergy;
        public List<hkpTyremarksWheel> m_tyremarksWheel;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_minTyremarkEnergy = br.ReadSingle();
            m_maxTyremarkEnergy = br.ReadSingle();
            br.ReadUInt32();
            m_tyremarksWheel = des.ReadClassPointerArray<hkpTyremarksWheel>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_minTyremarkEnergy);
            bw.WriteSingle(m_maxTyremarkEnergy);
            bw.WriteUInt32(0);
            s.WriteClassPointerArray(bw, m_tyremarksWheel);
        }
    }
}