using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpGenericConstraintData Signatire: 0xfa824640 size: 128 flags: FLAGS_NONE

    // m_atoms m_class: hkpBridgeAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_scheme m_class: hkpGenericConstraintDataScheme Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    
    public class hkpGenericConstraintData : hkpConstraintData
    {

        public hkpBridgeAtoms/*struct void*/ m_atoms;
        public hkpGenericConstraintDataScheme/*struct void*/ m_scheme;

        public override uint Signature => 0xfa824640;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des,br);
            m_scheme = new hkpGenericConstraintDataScheme();
            m_scheme.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_atoms.Write(s, bw);
            m_scheme.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

