using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxNode Signatire: 0x5a218502 size: 112 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_object m_class: hkReferencedObject Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 40 flags:  enum: 
    // m_keyFrames m_class:  Type.TYPE_ARRAY Type.TYPE_MATRIX4 arrSize: 0 offset: 48 flags:  enum: 
    // m_children m_class: hkxNode Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 64 flags:  enum: 
    // m_annotations m_class: hkxNodeAnnotationData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 80 flags:  enum: 
    // m_userProperties m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_selected m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    
    public class hkxNode : hkxAttributeHolder
    {

        public string m_name;
        public hkReferencedObject /*pointer struct*/ m_object;
        public List<Matrix4x4> m_keyFrames;
        public List<hkxNode> m_children;
        public List<hkxNodeAnnotationData> m_annotations;
        public string m_userProperties;
        public bool m_selected;

        public override uint Signature => 0x5a218502;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_object = des.ReadClassPointer<hkReferencedObject>(br);
            m_keyFrames = des.ReadMatrix4Array(br);
            m_children = des.ReadClassPointerArray<hkxNode>(br);
            m_annotations = des.ReadClassArray<hkxNodeAnnotationData>(br);
            m_userProperties = des.ReadStringPointer(br);
            m_selected = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_object);
            s.WriteMatrix4Array(bw, m_keyFrames);
            s.WriteClassPointerArray<hkxNode>(bw, m_children);
            s.WriteClassArray<hkxNodeAnnotationData>(bw, m_annotations);
            s.WriteStringPointer(bw, m_userProperties);
            bw.WriteBoolean(m_selected);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

