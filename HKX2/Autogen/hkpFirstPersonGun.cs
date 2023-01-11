using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpFirstPersonGun Signatire: 0x852ab70b size: 56 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 16 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_keyboardKey m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 32 flags: FLAGS_NONE enum: KeyboardKey
    // m_listeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 40 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkpFirstPersonGun : hkReferencedObject
    {
        private byte m_type { set; get; } = default;
        public string m_name { set; get; } = "";
        public byte m_keyboardKey { set; get; } = default;
        public IList<object> m_listeners { set; get; } = new List<object>();

        public override uint Signature => 0x852ab70b;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_type = br.ReadByte();
            br.Position += 7;
            m_name = des.ReadStringPointer(br);
            m_keyboardKey = br.ReadByte();
            br.Position += 7;
            des.ReadEmptyArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_type);
            bw.Position += 7;
            s.WriteStringPointer(bw, m_name);
            bw.WriteByte(m_keyboardKey);
            bw.Position += 7;
            s.WriteVoidArray(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_name = xd.ReadString(xe, nameof(m_name));
            m_keyboardKey = xd.ReadFlag<KeyboardKey, byte>(xe, nameof(m_keyboardKey));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteSerializeIgnored(xe, nameof(m_type));
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteEnum<KeyboardKey, byte>(xe, nameof(m_keyboardKey), m_keyboardKey);
            xs.WriteSerializeIgnored(xe, nameof(m_listeners));
        }
    }
}

