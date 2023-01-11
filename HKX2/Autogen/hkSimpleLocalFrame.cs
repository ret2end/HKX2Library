using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkSimpleLocalFrame Signatire: 0xe758f63c size: 128 flags: FLAGS_NONE

    // m_transform m_class:  Type.TYPE_TRANSFORM Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_children m_class: hkLocalFrame Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_parentFrame m_class: hkLocalFrame Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 96 flags: NOT_OWNED|FLAGS_NONE enum: 
    // m_group m_class: hkLocalFrameGroup Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    public partial class hkSimpleLocalFrame : hkLocalFrame
    {
        public Matrix4x4 m_transform { set; get; } = default;
        public IList<hkLocalFrame> m_children { set; get; } = new List<hkLocalFrame>();
        public hkLocalFrame? m_parentFrame { set; get; } = default;
        public hkLocalFrameGroup? m_group { set; get; } = default;
        public string m_name { set; get; } = "";

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
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteTransform(bw, m_transform);
            s.WriteClassPointerArray(bw, m_children);
            s.WriteClassPointer(bw, m_parentFrame);
            s.WriteClassPointer(bw, m_group);
            s.WriteStringPointer(bw, m_name);
            bw.Position += 8;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_transform = xd.ReadTransform(xe, nameof(m_transform));
            m_children = xd.ReadClassPointerArray<hkLocalFrame>(xe, nameof(m_children));
            m_parentFrame = xd.ReadClassPointer<hkLocalFrame>(xe, nameof(m_parentFrame));
            m_group = xd.ReadClassPointer<hkLocalFrameGroup>(xe, nameof(m_group));
            m_name = xd.ReadString(xe, nameof(m_name));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteTransform(xe, nameof(m_transform), m_transform);
            xs.WriteClassPointerArray<hkLocalFrame>(xe, nameof(m_children), m_children);
            xs.WriteClassPointer(xe, nameof(m_parentFrame), m_parentFrame);
            xs.WriteClassPointer(xe, nameof(m_group), m_group);
            xs.WriteString(xe, nameof(m_name), m_name);
        }
    }
}

