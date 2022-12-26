using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpTransformShape Signatire: 0x787ef513 size: 144 flags: FLAGS_NONE

    // m_childShape m_class: hkpSingleShapeContainer Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_childShapeSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 48 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_rotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_transform m_class:  Type.TYPE_TRANSFORM Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    
    public class hkpTransformShape : hkpShape
    {

        public hkpSingleShapeContainer/*struct void*/ m_childShape;
        public int m_childShapeSize;
        public Quaternion m_rotation;
        public Matrix4x4 m_transform;

        public override uint Signature => 0x787ef513;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_childShape = new hkpSingleShapeContainer();
            m_childShape.Read(des,br);
            m_childShapeSize = br.ReadInt32();
            br.Position += 12;
            m_rotation = des.ReadQuaternion(br);
            m_transform = des.ReadTransform(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_childShape.Write(s, bw);
            bw.WriteInt32(m_childShapeSize);
            bw.Position += 12;
            s.WriteQuaternion(bw, m_rotation);
            s.WriteTransform(bw, m_transform);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

