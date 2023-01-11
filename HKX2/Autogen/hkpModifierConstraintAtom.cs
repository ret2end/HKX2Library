using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpModifierConstraintAtom Signatire: 0xb13fef1f size: 48 flags: FLAGS_NONE

    // m_modifierAtomSize m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 16 flags: ALIGN_16|FLAGS_NONE enum: 
    // m_childSize m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 18 flags: FLAGS_NONE enum: 
    // m_child m_class: hkpConstraintAtom Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_pad m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 2 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkpModifierConstraintAtom : hkpConstraintAtom
    {
        public ushort m_modifierAtomSize { set; get; } = default;
        public ushort m_childSize { set; get; } = default;
        public hkpConstraintAtom? m_child { set; get; } = default;
        public uint[] m_pad = new uint[2];

        public override uint Signature => 0xb13fef1f;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.Position += 14;
            m_modifierAtomSize = br.ReadUInt16();
            m_childSize = br.ReadUInt16();
            br.Position += 4;
            m_child = des.ReadClassPointer<hkpConstraintAtom>(br);
            m_pad = des.ReadUInt32CStyleArray(br, 2);
            br.Position += 8;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.Position += 14;
            bw.WriteUInt16(m_modifierAtomSize);
            bw.WriteUInt16(m_childSize);
            bw.Position += 4;
            s.WriteClassPointer(bw, m_child);
            s.WriteUInt32CStyleArray(bw, m_pad);
            bw.Position += 8;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_modifierAtomSize = xd.ReadUInt16(xe, nameof(m_modifierAtomSize));
            m_childSize = xd.ReadUInt16(xe, nameof(m_childSize));
            m_child = xd.ReadClassPointer<hkpConstraintAtom>(xe, nameof(m_child));
            m_pad = xd.ReadUInt32CStyleArray(xe, nameof(m_pad), 2);
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_modifierAtomSize), m_modifierAtomSize);
            xs.WriteNumber(xe, nameof(m_childSize), m_childSize);
            xs.WriteClassPointer(xe, nameof(m_child), m_child);
            xs.WriteNumberArray(xe, nameof(m_pad), m_pad);
        }
    }
}

