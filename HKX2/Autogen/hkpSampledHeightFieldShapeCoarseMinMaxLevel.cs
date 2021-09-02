using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkpSampledHeightFieldShapeCoarseMinMaxLevel : IHavokObject
    {
        public List<Vector4> m_minMaxData;
        public int m_xRes;
        public int m_zRes;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_minMaxData = des.ReadVector4Array(br);
            m_xRes = br.ReadInt32();
            m_zRes = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4Array(bw, m_minMaxData);
            bw.WriteInt32(m_xRes);
            bw.WriteInt32(m_zRes);
        }
    }
}