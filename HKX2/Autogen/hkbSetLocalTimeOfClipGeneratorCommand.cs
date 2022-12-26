using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbSetLocalTimeOfClipGeneratorCommand Signatire: 0xfab12b45 size: 32 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_localTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_nodeId m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    
    public class hkbSetLocalTimeOfClipGeneratorCommand : hkReferencedObject
    {

        public ulong m_characterId;
        public float m_localTime;
        public short m_nodeId;

        public override uint Signature => 0xfab12b45;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_localTime = br.ReadSingle();
            m_nodeId = br.ReadInt16();
            br.Position += 2;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            bw.WriteSingle(m_localTime);
            bw.WriteInt16(m_nodeId);
            bw.Position += 2;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

