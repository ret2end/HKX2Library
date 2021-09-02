using System.Collections.Generic;

namespace HKX2
{
    public class hkaiOverlapManagerSection : IHavokObject
    {
        public hkSetIntFloatPair m_facePriorities;
        public List<hkaiOverlapManagerSectionGeneratorData> m_generatorData;

        public int m_numOriginalFaces;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            br.ReadUInt64();
            m_numOriginalFaces = br.ReadInt32();
            br.ReadUInt32();
            m_generatorData = des.ReadClassPointerArray<hkaiOverlapManagerSectionGeneratorData>(br);
            br.ReadUInt64();
            br.ReadUInt64();
            m_facePriorities = new hkSetIntFloatPair();
            m_facePriorities.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt64(0);
            bw.WriteInt32(m_numOriginalFaces);
            bw.WriteUInt32(0);
            s.WriteClassPointerArray(bw, m_generatorData);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            m_facePriorities.Write(s, bw);
        }
    }
}