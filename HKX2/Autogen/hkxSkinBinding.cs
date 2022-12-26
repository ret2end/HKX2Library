using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxSkinBinding Signatire: 0x5a93f338 size: 128 flags: FLAGS_NONE

    // m_mesh m_class: hkxMesh Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_nodeNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 24 flags:  enum: 
    // m_bindPose m_class:  Type.TYPE_ARRAY Type.TYPE_MATRIX4 arrSize: 0 offset: 40 flags:  enum: 
    // m_initSkinTransform m_class:  Type.TYPE_MATRIX4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkxSkinBinding : hkReferencedObject
    {

        public hkxMesh /*pointer struct*/ m_mesh;
        public List<string> m_nodeNames;
        public List<Matrix4x4> m_bindPose;
        public Matrix4x4 m_initSkinTransform;

        public override uint Signature => 0x5a93f338;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_mesh = des.ReadClassPointer<hkxMesh>(br);
            m_nodeNames = des.ReadStringPointerArray(br);
            m_bindPose = des.ReadMatrix4Array(br);
            br.Position += 8;
            m_initSkinTransform = des.ReadMatrix4(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_mesh);
            s.WriteStringPointerArray(bw, m_nodeNames);
            s.WriteMatrix4Array(bw, m_bindPose);
            bw.Position += 8;
            s.WriteMatrix4(bw, m_initSkinTransform);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

