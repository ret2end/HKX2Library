using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConstraintMotor Signatire: 0x6a44c317 size: 24 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 16 flags:  enum: MotorType
    
    public class hkpConstraintMotor : hkReferencedObject
    {

        public sbyte m_type;

        public override uint Signature => 0x6a44c317;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_type = br.ReadSByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteSByte(bw, m_type);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

