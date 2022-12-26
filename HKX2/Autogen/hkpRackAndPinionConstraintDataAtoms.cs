using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpRackAndPinionConstraintDataAtoms Signatire: 0xa58a9659 size: 160 flags: FLAGS_NONE

    // m_transforms m_class: hkpSetLocalTransformsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_rackAndPinion m_class: hkpRackAndPinionConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    
    public class hkpRackAndPinionConstraintDataAtoms : IHavokObject
    {

        public hkpSetLocalTransformsConstraintAtom/*struct void*/ m_transforms;
        public hkpRackAndPinionConstraintAtom/*struct void*/ m_rackAndPinion;

        public uint Signature => 0xa58a9659;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des,br);
            m_rackAndPinion = new hkpRackAndPinionConstraintAtom();
            m_rackAndPinion.Read(des,br);
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_transforms.Write(s, bw);
            m_rackAndPinion.Write(s, bw);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

