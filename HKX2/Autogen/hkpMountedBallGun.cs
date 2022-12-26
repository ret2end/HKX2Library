using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpMountedBallGun Signatire: 0x6791ffce size: 128 flags: FLAGS_NONE

    // m_position m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    
    public class hkpMountedBallGun : hkpBallGun
    {

        public Vector4 m_position;

        public override uint Signature => 0x6791ffce;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_position = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_position);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

