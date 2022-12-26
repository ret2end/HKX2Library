using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSerializedSubTrack1nInfo Signatire: 0x10155a size: 40 flags: FLAGS_NONE

    // m_sectorIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_offsetInSector m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    
    public class hkpSerializedSubTrack1nInfo : hkpSerializedTrack1nInfo
    {

        public int m_sectorIndex;
        public int m_offsetInSector;

        public override uint Signature => 0x10155a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_sectorIndex = br.ReadInt32();
            m_offsetInSector = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteInt32(m_sectorIndex);
            bw.WriteInt32(m_offsetInSector);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

