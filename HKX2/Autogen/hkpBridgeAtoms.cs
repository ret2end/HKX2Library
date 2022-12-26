using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpBridgeAtoms Signatire: 0xde152a4d size: 24 flags: FLAGS_NONE

    // m_bridgeAtom m_class: hkpBridgeConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    
    public class hkpBridgeAtoms : IHavokObject
    {

        public hkpBridgeConstraintAtom/*struct void*/ m_bridgeAtom;

        public uint Signature => 0xde152a4d;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_bridgeAtom = new hkpBridgeConstraintAtom();
            m_bridgeAtom.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_bridgeAtom.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

