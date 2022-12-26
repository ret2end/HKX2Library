using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkSimpleLocalFrame Signatire: 0xe758f63c size: 128 flags: FLAGS_NONE

    // m_transform m_class:  Type.TYPE_TRANSFORM Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_children m_class: hkLocalFrame Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 80 flags:  enum: 
    // m_parentFrame m_class: hkLocalFrame Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 96 flags: ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_group m_class: hkLocalFrameGroup Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 104 flags:  enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    
    public class hkSimpleLocalFrame : hkLocalFrame
    {

        public Matrix4x4 m_transform;
        public List<hkLocalFrame> m_children;
        public hkLocalFrame /*pointer struct*/ m_parentFrame;
        public hkLocalFrameGroup /*pointer struct*/ m_group;
        public string m_name;

        public override uint Signature => 0xe758f63c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_transform = des.ReadTransform(br);
            m_children = des.ReadClassPointerArray<hkLocalFrame>(br);
            m_parentFrame = des.ReadClassPointer<hkLocalFrame>(br);
            m_group = des.ReadClassPointer<hkLocalFrameGroup>(br);
            m_name = des.ReadStringPointer(br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteTransform(bw, m_transform);
            s.WriteClassPointerArray<hkLocalFrame>(bw, m_children);
            s.WriteClassPointer(bw, m_parentFrame);
            s.WriteClassPointer(bw, m_group);
            s.WriteStringPointer(bw, m_name);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

