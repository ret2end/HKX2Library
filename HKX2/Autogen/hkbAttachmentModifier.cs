using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbAttachmentModifier Signatire: 0xcc0aab32 size: 200 flags: FLAGS_NONE

    // m_sendToAttacherOnAttach m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_sendToAttacheeOnAttach m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_sendToAttacherOnDetach m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_sendToAttacheeOnDetach m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_attachmentSetup m_class: hkbAttachmentSetup Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_attacherHandle m_class: hkbHandle Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 152 flags: FLAGS_NONE enum: 
    // m_attacheeHandle m_class: hkbHandle Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 160 flags: FLAGS_NONE enum: 
    // m_attacheeLayer m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 168 flags: FLAGS_NONE enum: 
    // m_attacheeRB m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 176 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_oldMotionType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 184 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_oldFilterInfo m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 188 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_attachment m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 192 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbAttachmentModifier : hkbModifier
    {
        public hkbEventProperty m_sendToAttacherOnAttach { set; get; } = new();
        public hkbEventProperty m_sendToAttacheeOnAttach { set; get; } = new();
        public hkbEventProperty m_sendToAttacherOnDetach { set; get; } = new();
        public hkbEventProperty m_sendToAttacheeOnDetach { set; get; } = new();
        public hkbAttachmentSetup? m_attachmentSetup { set; get; } = default;
        public hkbHandle? m_attacherHandle { set; get; } = default;
        public hkbHandle? m_attacheeHandle { set; get; } = default;
        public int m_attacheeLayer { set; get; } = default;
        private object? m_attacheeRB { set; get; } = default;
        private byte m_oldMotionType { set; get; } = default;
        private int m_oldFilterInfo { set; get; } = default;
        private object? m_attachment { set; get; } = default;

        public override uint Signature => 0xcc0aab32;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_sendToAttacherOnAttach.Read(des, br);
            m_sendToAttacheeOnAttach.Read(des, br);
            m_sendToAttacherOnDetach.Read(des, br);
            m_sendToAttacheeOnDetach.Read(des, br);
            m_attachmentSetup = des.ReadClassPointer<hkbAttachmentSetup>(br);
            m_attacherHandle = des.ReadClassPointer<hkbHandle>(br);
            m_attacheeHandle = des.ReadClassPointer<hkbHandle>(br);
            m_attacheeLayer = br.ReadInt32();
            br.Position += 4;
            des.ReadEmptyPointer(br);
            m_oldMotionType = br.ReadByte();
            br.Position += 3;
            m_oldFilterInfo = br.ReadInt32();
            des.ReadEmptyPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_sendToAttacherOnAttach.Write(s, bw);
            m_sendToAttacheeOnAttach.Write(s, bw);
            m_sendToAttacherOnDetach.Write(s, bw);
            m_sendToAttacheeOnDetach.Write(s, bw);
            s.WriteClassPointer(bw, m_attachmentSetup);
            s.WriteClassPointer(bw, m_attacherHandle);
            s.WriteClassPointer(bw, m_attacheeHandle);
            bw.WriteInt32(m_attacheeLayer);
            bw.Position += 4;
            s.WriteVoidPointer(bw);
            bw.WriteByte(m_oldMotionType);
            bw.Position += 3;
            bw.WriteInt32(m_oldFilterInfo);
            s.WriteVoidPointer(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_sendToAttacherOnAttach = xd.ReadClass<hkbEventProperty>(xe, nameof(m_sendToAttacherOnAttach));
            m_sendToAttacheeOnAttach = xd.ReadClass<hkbEventProperty>(xe, nameof(m_sendToAttacheeOnAttach));
            m_sendToAttacherOnDetach = xd.ReadClass<hkbEventProperty>(xe, nameof(m_sendToAttacherOnDetach));
            m_sendToAttacheeOnDetach = xd.ReadClass<hkbEventProperty>(xe, nameof(m_sendToAttacheeOnDetach));
            m_attachmentSetup = xd.ReadClassPointer<hkbAttachmentSetup>(xe, nameof(m_attachmentSetup));
            m_attacherHandle = xd.ReadClassPointer<hkbHandle>(xe, nameof(m_attacherHandle));
            m_attacheeHandle = xd.ReadClassPointer<hkbHandle>(xe, nameof(m_attacheeHandle));
            m_attacheeLayer = xd.ReadInt32(xe, nameof(m_attacheeLayer));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkbEventProperty>(xe, nameof(m_sendToAttacherOnAttach), m_sendToAttacherOnAttach);
            xs.WriteClass<hkbEventProperty>(xe, nameof(m_sendToAttacheeOnAttach), m_sendToAttacheeOnAttach);
            xs.WriteClass<hkbEventProperty>(xe, nameof(m_sendToAttacherOnDetach), m_sendToAttacherOnDetach);
            xs.WriteClass<hkbEventProperty>(xe, nameof(m_sendToAttacheeOnDetach), m_sendToAttacheeOnDetach);
            xs.WriteClassPointer(xe, nameof(m_attachmentSetup), m_attachmentSetup);
            xs.WriteClassPointer(xe, nameof(m_attacherHandle), m_attacherHandle);
            xs.WriteClassPointer(xe, nameof(m_attacheeHandle), m_attacheeHandle);
            xs.WriteNumber(xe, nameof(m_attacheeLayer), m_attacheeLayer);
            xs.WriteSerializeIgnored(xe, nameof(m_attacheeRB));
            xs.WriteSerializeIgnored(xe, nameof(m_oldMotionType));
            xs.WriteSerializeIgnored(xe, nameof(m_oldFilterInfo));
            xs.WriteSerializeIgnored(xe, nameof(m_attachment));
        }
    }
}

