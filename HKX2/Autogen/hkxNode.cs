using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkxNode Signatire: 0x5a218502 size: 112 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_object m_class: hkReferencedObject Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_keyFrames m_class:  Type.TYPE_ARRAY Type.TYPE_MATRIX4 arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_children m_class: hkxNode Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_annotations m_class: hkxNodeAnnotationData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_userProperties m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_selected m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    public partial class hkxNode : hkxAttributeHolder
    {
        public string m_name { set; get; } = "";
        public hkReferencedObject? m_object { set; get; } = default;
        public IList<Matrix4x4> m_keyFrames { set; get; } = new List<Matrix4x4>();
        public IList<hkxNode> m_children { set; get; } = new List<hkxNode>();
        public IList<hkxNodeAnnotationData> m_annotations { set; get; } = new List<hkxNodeAnnotationData>();
        public string m_userProperties { set; get; } = "";
        public bool m_selected { set; get; } = default;

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
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_object);
            s.WriteMatrix4Array(bw, m_keyFrames);
            s.WriteClassPointerArray(bw, m_children);
            s.WriteClassArray(bw, m_annotations);
            s.WriteStringPointer(bw, m_userProperties);
            bw.WriteBoolean(m_selected);
            bw.Position += 7;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_name = xd.ReadString(xe, nameof(m_name));
            m_object = xd.ReadClassPointer<hkReferencedObject>(xe, nameof(m_object));
            m_keyFrames = xd.ReadMatrix4Array(xe, nameof(m_keyFrames));
            m_children = xd.ReadClassPointerArray<hkxNode>(xe, nameof(m_children));
            m_annotations = xd.ReadClassArray<hkxNodeAnnotationData>(xe, nameof(m_annotations));
            m_userProperties = xd.ReadString(xe, nameof(m_userProperties));
            m_selected = xd.ReadBoolean(xe, nameof(m_selected));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteClassPointer(xe, nameof(m_object), m_object);
            xs.WriteMatrix4Array(xe, nameof(m_keyFrames), m_keyFrames);
            xs.WriteClassPointerArray<hkxNode>(xe, nameof(m_children), m_children);
            xs.WriteClassArray<hkxNodeAnnotationData>(xe, nameof(m_annotations), m_annotations);
            xs.WriteString(xe, nameof(m_userProperties), m_userProperties);
            xs.WriteBoolean(xe, nameof(m_selected), m_selected);
        }
    }
}

