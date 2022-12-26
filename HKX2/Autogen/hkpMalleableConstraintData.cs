using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpMalleableConstraintData Signatire: 0x6748b2cf size: 64 flags: FLAGS_NONE

    // m_constraintData m_class: hkpConstraintData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags:  enum: 
    // m_atoms m_class: hkpBridgeAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_strength m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    
    public class hkpMalleableConstraintData : hkpConstraintData
    {

        public hkpConstraintData /*pointer struct*/ m_constraintData;
        public hkpBridgeAtoms/*struct void*/ m_atoms;
        public float m_strength;

        public override uint Signature => 0x6748b2cf;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_constraintData = des.ReadClassPointer<hkpConstraintData>(br);
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des,br);
            m_strength = br.ReadSingle();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_constraintData);
            m_atoms.Write(s, bw);
            bw.WriteSingle(m_strength);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

