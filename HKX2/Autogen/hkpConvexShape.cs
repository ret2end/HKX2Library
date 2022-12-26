using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConvexShape Signatire: 0xf8f74f85 size: 40 flags: FLAGS_NONE

    // m_radius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkpConvexShape : hkpSphereRepShape
    {

        public float m_radius;

        public override uint Signature => 0xf8f74f85;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_radius = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_radius);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

