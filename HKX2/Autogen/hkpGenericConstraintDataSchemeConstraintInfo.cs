using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpGenericConstraintDataSchemeConstraintInfo Signatire: 0xd6421f19 size: 16 flags: FLAGS_NONE

    // m_maxSizeOfSchema m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_sizeOfSchemas m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_numSolverResults m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_numSolverElemTemps m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    
    public class hkpGenericConstraintDataSchemeConstraintInfo : IHavokObject
    {

        public int m_maxSizeOfSchema;
        public int m_sizeOfSchemas;
        public int m_numSolverResults;
        public int m_numSolverElemTemps;

        public uint Signature => 0xd6421f19;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_maxSizeOfSchema = br.ReadInt32();
            m_sizeOfSchemas = br.ReadInt32();
            m_numSolverResults = br.ReadInt32();
            m_numSolverElemTemps = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt32(m_maxSizeOfSchema);
            bw.WriteInt32(m_sizeOfSchemas);
            bw.WriteInt32(m_numSolverResults);
            bw.WriteInt32(m_numSolverElemTemps);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

