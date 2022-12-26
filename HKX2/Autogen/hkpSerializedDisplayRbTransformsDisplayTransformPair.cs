using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSerializedDisplayRbTransformsDisplayTransformPair Signatire: 0x94ac5bec size: 80 flags: FLAGS_NONE

    // m_rb m_class: hkpRigidBody Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags:  enum: 
    // m_localToDisplay m_class:  Type.TYPE_TRANSFORM Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkpSerializedDisplayRbTransformsDisplayTransformPair : IHavokObject
    {

        public hkpRigidBody /*pointer struct*/ m_rb;
        public Matrix4x4 m_localToDisplay;

        public uint Signature => 0x94ac5bec;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_rb = des.ReadClassPointer<hkpRigidBody>(br);
            br.Position += 8;
            m_localToDisplay = des.ReadTransform(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteClassPointer(bw, m_rb);
            bw.Position += 8;
            s.WriteTransform(bw, m_localToDisplay);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

