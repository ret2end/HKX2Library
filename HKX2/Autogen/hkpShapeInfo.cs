using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpShapeInfo Signatire: 0xea7f1d08 size: 128 flags: FLAGS_NONE

    // m_shape m_class: hkpShape Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_isHierarchicalCompound m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_hkdShapesCollected m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 25 flags:  enum: 
    // m_childShapeNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 32 flags:  enum: 
    // m_childTransforms m_class:  Type.TYPE_ARRAY Type.TYPE_TRANSFORM arrSize: 0 offset: 48 flags:  enum: 
    // m_transform m_class:  Type.TYPE_TRANSFORM Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkpShapeInfo : hkReferencedObject
    {

        public hkpShape /*pointer struct*/ m_shape;
        public bool m_isHierarchicalCompound;
        public bool m_hkdShapesCollected;
        public List<string> m_childShapeNames;
        public List<Matrix4x4> m_childTransforms;
        public Matrix4x4 m_transform;

        public override uint Signature => 0xea7f1d08;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_shape = des.ReadClassPointer<hkpShape>(br);
            m_isHierarchicalCompound = br.ReadBoolean();
            m_hkdShapesCollected = br.ReadBoolean();
            br.Position += 6;
            m_childShapeNames = des.ReadStringPointerArray(br);
            m_childTransforms = des.ReadTransformArray(br);
            m_transform = des.ReadTransform(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_shape);
            bw.WriteBoolean(m_isHierarchicalCompound);
            bw.WriteBoolean(m_hkdShapesCollected);
            bw.Position += 6;
            s.WriteStringPointerArray(bw, m_childShapeNames);
            s.WriteTransformArray(bw, m_childTransforms);
            s.WriteTransform(bw, m_transform);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

