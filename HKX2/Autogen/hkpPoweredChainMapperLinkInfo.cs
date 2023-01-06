using System.Xml.Linq;

namespace HKX2
{
    // hkpPoweredChainMapperLinkInfo Signatire: 0xcf071a1b size: 16 flags: FLAGS_NONE

    // m_firstTargetIdx m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_numTargets m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_limitConstraint m_class: hkpConstraintInstance Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkpPoweredChainMapperLinkInfo : IHavokObject
    {
        public int m_firstTargetIdx;
        public int m_numTargets;
        public hkpConstraintInstance m_limitConstraint;

        public virtual uint Signature => 0xcf071a1b;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_firstTargetIdx = br.ReadInt32();
            m_numTargets = br.ReadInt32();
            m_limitConstraint = des.ReadClassPointer<hkpConstraintInstance>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_firstTargetIdx);
            bw.WriteInt32(m_numTargets);
            s.WriteClassPointer(bw, m_limitConstraint);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_firstTargetIdx = xd.ReadInt32(xe, nameof(m_firstTargetIdx));
            m_numTargets = xd.ReadInt32(xe, nameof(m_numTargets));
            m_limitConstraint = xd.ReadClassPointer<hkpConstraintInstance>(xe, nameof(m_limitConstraint));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_firstTargetIdx), m_firstTargetIdx);
            xs.WriteNumber(xe, nameof(m_numTargets), m_numTargets);
            xs.WriteClassPointer(xe, nameof(m_limitConstraint), m_limitConstraint);
        }
    }
}

