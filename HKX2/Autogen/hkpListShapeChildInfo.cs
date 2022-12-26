using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpListShapeChildInfo Signatire: 0x80df0f90 size: 32 flags: FLAGS_NONE

    // m_shape m_class: hkpShape Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags: ALIGN_8|FLAGS_NONE enum: 
    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_shapeSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_numChildShapes m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 16 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpListShapeChildInfo : IHavokObject
    {

        public hkpShape /*pointer struct*/ m_shape;
        public uint m_collisionFilterInfo;
        public int m_shapeSize;
        public int m_numChildShapes;

        public uint Signature => 0x80df0f90;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_shape = des.ReadClassPointer<hkpShape>(br);
            m_collisionFilterInfo = br.ReadUInt32();
            m_shapeSize = br.ReadInt32();
            m_numChildShapes = br.ReadInt32();
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteClassPointer(bw, m_shape);
            bw.WriteUInt32(m_collisionFilterInfo);
            bw.WriteInt32(m_shapeSize);
            bw.WriteInt32(m_numChildShapes);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

