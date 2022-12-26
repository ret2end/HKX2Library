using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbRegisteredGenerator Signatire: 0x58b1d082 size: 96 flags: FLAGS_NONE

    // m_generator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags:  enum: 
    // m_relativePosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_relativeDirection m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    
    public class hkbRegisteredGenerator : hkbBindable
    {

        public hkbGenerator /*pointer struct*/ m_generator;
        public Vector4 m_relativePosition;
        public Vector4 m_relativeDirection;

        public override uint Signature => 0x58b1d082;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_generator = des.ReadClassPointer<hkbGenerator>(br);
            br.Position += 8;
            m_relativePosition = br.ReadVector4();
            m_relativeDirection = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_generator);
            bw.Position += 8;
            bw.WriteVector4(m_relativePosition);
            bw.WriteVector4(m_relativeDirection);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

