using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkAlignSceneToNodeOptions Signatire: 0x207cb01 size: 40 flags: FLAGS_NONE

    // m_invert m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_transformPositionX m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 17 flags: FLAGS_NONE enum: 
    // m_transformPositionY m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 18 flags: FLAGS_NONE enum: 
    // m_transformPositionZ m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 19 flags: FLAGS_NONE enum: 
    // m_transformRotation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 20 flags: FLAGS_NONE enum: 
    // m_transformScale m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 21 flags: FLAGS_NONE enum: 
    // m_transformSkew m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 22 flags: FLAGS_NONE enum: 
    // m_keyframe m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_nodeName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkAlignSceneToNodeOptions : hkReferencedObject
    {
        public bool m_invert { set; get; } = default;
        public bool m_transformPositionX { set; get; } = default;
        public bool m_transformPositionY { set; get; } = default;
        public bool m_transformPositionZ { set; get; } = default;
        public bool m_transformRotation { set; get; } = default;
        public bool m_transformScale { set; get; } = default;
        public bool m_transformSkew { set; get; } = default;
        public int m_keyframe { set; get; } = default;
        public string m_nodeName { set; get; } = "";

        public override uint Signature => 0x207cb01;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_invert = br.ReadBoolean();
            m_transformPositionX = br.ReadBoolean();
            m_transformPositionY = br.ReadBoolean();
            m_transformPositionZ = br.ReadBoolean();
            m_transformRotation = br.ReadBoolean();
            m_transformScale = br.ReadBoolean();
            m_transformSkew = br.ReadBoolean();
            br.Position += 1;
            m_keyframe = br.ReadInt32();
            br.Position += 4;
            m_nodeName = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteBoolean(m_invert);
            bw.WriteBoolean(m_transformPositionX);
            bw.WriteBoolean(m_transformPositionY);
            bw.WriteBoolean(m_transformPositionZ);
            bw.WriteBoolean(m_transformRotation);
            bw.WriteBoolean(m_transformScale);
            bw.WriteBoolean(m_transformSkew);
            bw.Position += 1;
            bw.WriteInt32(m_keyframe);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_nodeName);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_invert = xd.ReadBoolean(xe, nameof(m_invert));
            m_transformPositionX = xd.ReadBoolean(xe, nameof(m_transformPositionX));
            m_transformPositionY = xd.ReadBoolean(xe, nameof(m_transformPositionY));
            m_transformPositionZ = xd.ReadBoolean(xe, nameof(m_transformPositionZ));
            m_transformRotation = xd.ReadBoolean(xe, nameof(m_transformRotation));
            m_transformScale = xd.ReadBoolean(xe, nameof(m_transformScale));
            m_transformSkew = xd.ReadBoolean(xe, nameof(m_transformSkew));
            m_keyframe = xd.ReadInt32(xe, nameof(m_keyframe));
            m_nodeName = xd.ReadString(xe, nameof(m_nodeName));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteBoolean(xe, nameof(m_invert), m_invert);
            xs.WriteBoolean(xe, nameof(m_transformPositionX), m_transformPositionX);
            xs.WriteBoolean(xe, nameof(m_transformPositionY), m_transformPositionY);
            xs.WriteBoolean(xe, nameof(m_transformPositionZ), m_transformPositionZ);
            xs.WriteBoolean(xe, nameof(m_transformRotation), m_transformRotation);
            xs.WriteBoolean(xe, nameof(m_transformScale), m_transformScale);
            xs.WriteBoolean(xe, nameof(m_transformSkew), m_transformSkew);
            xs.WriteNumber(xe, nameof(m_keyframe), m_keyframe);
            xs.WriteString(xe, nameof(m_nodeName), m_nodeName);
        }
    }
}

