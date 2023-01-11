using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbCharacterSkinInfo Signatire: 0x180d900d size: 56 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_deformableSkins m_class:  Type.TYPE_ARRAY Type.TYPE_UINT64 arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_rigidSkins m_class:  Type.TYPE_ARRAY Type.TYPE_UINT64 arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    public partial class hkbCharacterSkinInfo : hkReferencedObject
    {
        public ulong m_characterId { set; get; } = default;
        public IList<ulong> m_deformableSkins { set; get; } = new List<ulong>();
        public IList<ulong> m_rigidSkins { set; get; } = new List<ulong>();

        public override uint Signature => 0x180d900d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_deformableSkins = des.ReadUInt64Array(br);
            m_rigidSkins = des.ReadUInt64Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            s.WriteUInt64Array(bw, m_deformableSkins);
            s.WriteUInt64Array(bw, m_rigidSkins);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_characterId = xd.ReadUInt64(xe, nameof(m_characterId));
            m_deformableSkins = xd.ReadUInt64Array(xe, nameof(m_deformableSkins));
            m_rigidSkins = xd.ReadUInt64Array(xe, nameof(m_rigidSkins));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_characterId), m_characterId);
            xs.WriteNumberArray(xe, nameof(m_deformableSkins), m_deformableSkins);
            xs.WriteNumberArray(xe, nameof(m_rigidSkins), m_rigidSkins);
        }
    }
}

