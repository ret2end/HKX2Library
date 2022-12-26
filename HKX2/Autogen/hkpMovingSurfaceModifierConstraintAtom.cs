using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpMovingSurfaceModifierConstraintAtom Signatire: 0x79ab517d size: 64 flags: FLAGS_NONE

    // m_velocity m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkpMovingSurfaceModifierConstraintAtom : hkpModifierConstraintAtom
    {

        public Vector4 m_velocity;

        public override uint Signature => 0x79ab517d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_velocity = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_velocity);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

