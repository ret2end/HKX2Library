using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCdBody Signatire: 0x54a4b841 size: 32 flags: FLAGS_NONE

    // m_shape m_class: hkpShape Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags:  enum: 
    // m_shapeKey m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_motion m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_parent m_class: hkpCdBody Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpCdBody : IHavokObject
    {

        public hkpShape /*pointer struct*/ m_shape;
        public uint m_shapeKey;
        public dynamic /* POINTER VOID */ m_motion;
        public hkpCdBody /*pointer struct*/ m_parent;

        public virtual uint Signature => 0x54a4b841;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_shape = des.ReadClassPointer<hkpShape>(br);
            m_shapeKey = br.ReadUInt32();
            br.Position += 4;
            des.ReadEmptyPointer(br);/* m_motion POINTER VOID */
            m_parent = des.ReadClassPointer<hkpCdBody>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteClassPointer(bw, m_shape);
            bw.WriteUInt32(m_shapeKey);
            bw.Position += 4;
            s.WriteVoidPointer(bw);/* m_motion POINTER VOID */
            s.WriteClassPointer(bw, m_parent);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

