using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpShapeCollection Signatire: 0xe8c3991d size: 48 flags: FLAGS_NONE

    // m_disableWelding m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_collectionType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 41 flags:  enum: CollectionType
    
    public class hkpShapeCollection : hkpShape
    {

        public bool m_disableWelding;
        public byte m_collectionType;

        public override uint Signature => 0xe8c3991d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_disableWelding = br.ReadBoolean();
            m_collectionType = br.ReadByte();
            br.Position += 6;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            bw.WriteBoolean(m_disableWelding);
            s.WriteByte(bw, m_collectionType);
            bw.Position += 6;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

