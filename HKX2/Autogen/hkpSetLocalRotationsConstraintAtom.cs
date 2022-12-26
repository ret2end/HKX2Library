using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSetLocalRotationsConstraintAtom Signatire: 0xf81db8e size: 112 flags: FLAGS_NONE

    // m_rotationA m_class:  Type.TYPE_ROTATION Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_rotationB m_class:  Type.TYPE_ROTATION Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkpSetLocalRotationsConstraintAtom : hkpConstraintAtom
    {

        public Matrix4x4 m_rotationA;
        public Matrix4x4 m_rotationB;

        public override uint Signature => 0xf81db8e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 14;
            m_rotationA = des.ReadMatrix3(br); //TYPE_ROTATION
            m_rotationB = des.ReadMatrix3(br); //TYPE_ROTATION

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 14;
            s.WriteMatrix3(bw, m_rotationA);
            s.WriteMatrix3(bw, m_rotationB);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

