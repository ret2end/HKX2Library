using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPointToPlaneConstraintDataAtoms Signatire: 0x749bc260 size: 160 flags: FLAGS_NONE

    // m_transforms m_class: hkpSetLocalTransformsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_lin m_class: hkpLinConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    
    public class hkpPointToPlaneConstraintDataAtoms : IHavokObject
    {

        public hkpSetLocalTransformsConstraintAtom/*struct void*/ m_transforms;
        public hkpLinConstraintAtom/*struct void*/ m_lin;

        public uint Signature => 0x749bc260;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des,br);
            m_lin = new hkpLinConstraintAtom();
            m_lin.Read(des,br);
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_transforms.Write(s, bw);
            m_lin.Write(s, bw);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

