using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbAttachmentModifier Signatire: 0xcc0aab32 size: 200 flags: FLAGS_NONE

    // m_sendToAttacherOnAttach m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_sendToAttacheeOnAttach m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_sendToAttacherOnDetach m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_sendToAttacheeOnDetach m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_attachmentSetup m_class: hkbAttachmentSetup Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 144 flags:  enum: 
    // m_attacherHandle m_class: hkbHandle Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 152 flags:  enum: 
    // m_attacheeHandle m_class: hkbHandle Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 160 flags:  enum: 
    // m_attacheeLayer m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 168 flags:  enum: 
    // m_attacheeRB m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 176 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_oldMotionType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 184 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_oldFilterInfo m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 188 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_attachment m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 192 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbAttachmentModifier : hkbModifier
    {

        public hkbEventProperty/*struct void*/ m_sendToAttacherOnAttach;
        public hkbEventProperty/*struct void*/ m_sendToAttacheeOnAttach;
        public hkbEventProperty/*struct void*/ m_sendToAttacherOnDetach;
        public hkbEventProperty/*struct void*/ m_sendToAttacheeOnDetach;
        public hkbAttachmentSetup /*pointer struct*/ m_attachmentSetup;
        public hkbHandle /*pointer struct*/ m_attacherHandle;
        public hkbHandle /*pointer struct*/ m_attacheeHandle;
        public int m_attacheeLayer;
        public dynamic /* POINTER VOID */ m_attacheeRB;
        public byte m_oldMotionType;
        public int m_oldFilterInfo;
        public dynamic /* POINTER VOID */ m_attachment;

        public override uint Signature => 0xcc0aab32;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_sendToAttacherOnAttach = new hkbEventProperty();
            m_sendToAttacherOnAttach.Read(des,br);
            m_sendToAttacheeOnAttach = new hkbEventProperty();
            m_sendToAttacheeOnAttach.Read(des,br);
            m_sendToAttacherOnDetach = new hkbEventProperty();
            m_sendToAttacherOnDetach.Read(des,br);
            m_sendToAttacheeOnDetach = new hkbEventProperty();
            m_sendToAttacheeOnDetach.Read(des,br);
            m_attachmentSetup = des.ReadClassPointer<hkbAttachmentSetup>(br);
            m_attacherHandle = des.ReadClassPointer<hkbHandle>(br);
            m_attacheeHandle = des.ReadClassPointer<hkbHandle>(br);
            m_attacheeLayer = br.ReadInt32();
            br.Position += 4;
            des.ReadEmptyPointer(br);/* m_attacheeRB POINTER VOID */
            m_oldMotionType = br.ReadByte();
            br.Position += 3;
            m_oldFilterInfo = br.ReadInt32();
            des.ReadEmptyPointer(br);/* m_attachment POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
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
            s.WriteVoidPointer(bw);/* m_attacheeRB POINTER VOID */
            s.WriteByte(bw, m_oldMotionType);
            bw.Position += 3;
            bw.WriteInt32(m_oldFilterInfo);
            s.WriteVoidPointer(bw);/* m_attachment POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

