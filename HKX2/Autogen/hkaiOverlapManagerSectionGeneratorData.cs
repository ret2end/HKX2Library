using System.Collections.Generic;

namespace HKX2
{
    public class hkaiOverlapManagerSectionGeneratorData : hkReferencedObject
    {
        public hkaiSilhouetteGeneratorSectionContext m_context;
        public List<int> m_overlappedFaces;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_context = new hkaiSilhouetteGeneratorSectionContext();
            m_context.Read(des, br);
            m_overlappedFaces = des.ReadInt32Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_context.Write(s, bw);
            s.WriteInt32Array(bw, m_overlappedFaces);
        }
    }
}