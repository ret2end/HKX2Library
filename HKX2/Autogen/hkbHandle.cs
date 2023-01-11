using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbHandle Signatire: 0xd8b6401c size: 48 flags: FLAGS_NONE

    // m_frame m_class: hkLocalFrame Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_rigidBody m_class: hkpRigidBody Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_character m_class: hkbCharacter Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_animationBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    public partial class hkbHandle : hkReferencedObject
    {
        public hkLocalFrame? m_frame { set; get; } = default;
        public hkpRigidBody? m_rigidBody { set; get; } = default;
        public hkbCharacter? m_character { set; get; } = default;
        public short m_animationBoneIndex { set; get; } = default;

        public override uint Signature => 0xd8b6401c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_frame = des.ReadClassPointer<hkLocalFrame>(br);
            m_rigidBody = des.ReadClassPointer<hkpRigidBody>(br);
            m_character = des.ReadClassPointer<hkbCharacter>(br);
            m_animationBoneIndex = br.ReadInt16();
            br.Position += 6;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_frame);
            s.WriteClassPointer(bw, m_rigidBody);
            s.WriteClassPointer(bw, m_character);
            bw.WriteInt16(m_animationBoneIndex);
            bw.Position += 6;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_frame = xd.ReadClassPointer<hkLocalFrame>(xe, nameof(m_frame));
            m_rigidBody = xd.ReadClassPointer<hkpRigidBody>(xe, nameof(m_rigidBody));
            m_character = xd.ReadClassPointer<hkbCharacter>(xe, nameof(m_character));
            m_animationBoneIndex = xd.ReadInt16(xe, nameof(m_animationBoneIndex));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_frame), m_frame);
            xs.WriteClassPointer(xe, nameof(m_rigidBody), m_rigidBody);
            xs.WriteClassPointer(xe, nameof(m_character), m_character);
            xs.WriteNumber(xe, nameof(m_animationBoneIndex), m_animationBoneIndex);
        }
    }
}

