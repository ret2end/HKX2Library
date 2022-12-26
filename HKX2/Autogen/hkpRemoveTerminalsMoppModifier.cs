using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpRemoveTerminalsMoppModifier Signatire: 0x91367f03 size: 48 flags: FLAGS_NONE

    // m_removeInfo m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 24 flags:  enum: 
    // m_tempShapesToRemove m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 40 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpRemoveTerminalsMoppModifier : hkReferencedObject
    {

        public List<uint> m_removeInfo;
        public dynamic /* POINTER VOID */ m_tempShapesToRemove;

        public override uint Signature => 0x91367f03;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_removeInfo = des.ReadUInt32Array(br);
            des.ReadEmptyPointer(br);/* m_tempShapesToRemove POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            s.WriteUInt32Array(bw, m_removeInfo);
            s.WriteVoidPointer(bw);/* m_tempShapesToRemove POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

