using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpAngConstraintAtom Signatire: 0x35bb3cd0 size: 4 flags: FLAGS_NONE

    // m_firstConstrainedAxis m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_numConstrainedAxes m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 3 flags:  enum: 
    
    public class hkpAngConstraintAtom : hkpConstraintAtom
    {

        public byte m_firstConstrainedAxis;
        public byte m_numConstrainedAxes;

        public override uint Signature => 0x35bb3cd0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_firstConstrainedAxis = br.ReadByte();
            m_numConstrainedAxes = br.ReadByte();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteByte(m_firstConstrainedAxis);
            bw.WriteByte(m_numConstrainedAxes);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

