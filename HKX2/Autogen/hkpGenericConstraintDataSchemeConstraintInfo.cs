using System.Xml.Linq;

namespace HKX2
{
    // hkpGenericConstraintDataSchemeConstraintInfo Signatire: 0xd6421f19 size: 16 flags: FLAGS_NONE

    // m_maxSizeOfSchema m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_sizeOfSchemas m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_numSolverResults m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_numSolverElemTemps m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    public partial class hkpGenericConstraintDataSchemeConstraintInfo : IHavokObject
    {
        public int m_maxSizeOfSchema;
        public int m_sizeOfSchemas;
        public int m_numSolverResults;
        public int m_numSolverElemTemps;

        public virtual uint Signature => 0xd6421f19;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_maxSizeOfSchema = br.ReadInt32();
            m_sizeOfSchemas = br.ReadInt32();
            m_numSolverResults = br.ReadInt32();
            m_numSolverElemTemps = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_maxSizeOfSchema);
            bw.WriteInt32(m_sizeOfSchemas);
            bw.WriteInt32(m_numSolverResults);
            bw.WriteInt32(m_numSolverElemTemps);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_maxSizeOfSchema), m_maxSizeOfSchema);
            xs.WriteNumber(xe, nameof(m_sizeOfSchemas), m_sizeOfSchemas);
            xs.WriteNumber(xe, nameof(m_numSolverResults), m_numSolverResults);
            xs.WriteNumber(xe, nameof(m_numSolverElemTemps), m_numSolverElemTemps);
        }
    }
}

