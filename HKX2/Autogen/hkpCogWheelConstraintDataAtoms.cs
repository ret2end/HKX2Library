using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCogWheelConstraintDataAtoms Signatire: 0xf855ba44 size: 160 flags: FLAGS_NONE

    // m_transforms m_class: hkpSetLocalTransformsConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_cogWheels m_class: hkpCogWheelConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    
    public class hkpCogWheelConstraintDataAtoms : IHavokObject
    {

        public hkpSetLocalTransformsConstraintAtom/*struct void*/ m_transforms;
        public hkpCogWheelConstraintAtom/*struct void*/ m_cogWheels;

        public uint Signature => 0xf855ba44;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des,br);
            m_cogWheels = new hkpCogWheelConstraintAtom();
            m_cogWheels.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_transforms.Write(s, bw);
            m_cogWheels.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

