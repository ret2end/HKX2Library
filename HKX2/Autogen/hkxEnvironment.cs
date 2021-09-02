using System.Collections.Generic;

namespace HKX2
{
    public class hkxEnvironment : hkReferencedObject
    {
        public List<hkxEnvironmentVariable> m_variables;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_variables = des.ReadClassArray<hkxEnvironmentVariable>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_variables);
        }
    }
}