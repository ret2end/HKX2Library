using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpBridgeConstraintAtom Signatire: 0x87a4f31b size: 24 flags: FLAGS_NONE

    // m_buildJacobianFunc m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 8 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_constraintData m_class: hkpConstraintData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpBridgeConstraintAtom : hkpConstraintAtom
    {

        public dynamic /* POINTER VOID */ m_buildJacobianFunc;
        public hkpConstraintData /*pointer struct*/ m_constraintData;

        public override uint Signature => 0x87a4f31b;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 6;
            des.ReadEmptyPointer(br);/* m_buildJacobianFunc POINTER VOID */
            m_constraintData = des.ReadClassPointer<hkpConstraintData>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 6;
            s.WriteVoidPointer(bw);/* m_buildJacobianFunc POINTER VOID */
            s.WriteClassPointer(bw, m_constraintData);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

