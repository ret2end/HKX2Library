using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpProjectileGun Signatire: 0xb4f30148 size: 104 flags: FLAGS_NONE

    // m_maxProjectiles m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    // m_reloadTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 60 flags: FLAGS_NONE enum: 
    // m_reload m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_projectiles m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 72 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_world m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 88 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_destructionWorld m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 96 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkpProjectileGun : hkpFirstPersonGun
    {
        public int m_maxProjectiles { set; get; } = default;
        public float m_reloadTime { set; get; } = default;
        private float m_reload { set; get; } = default;
        public IList<object> m_projectiles { set; get; } = new List<object>();
        private object? m_world { set; get; } = default;
        private object? m_destructionWorld { set; get; } = default;

        public override uint Signature => 0xb4f30148;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_maxProjectiles = br.ReadInt32();
            m_reloadTime = br.ReadSingle();
            m_reload = br.ReadSingle();
            br.Position += 4;
            des.ReadEmptyArray(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(m_maxProjectiles);
            bw.WriteSingle(m_reloadTime);
            bw.WriteSingle(m_reload);
            bw.Position += 4;
            s.WriteVoidArray(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_maxProjectiles = xd.ReadInt32(xe, nameof(m_maxProjectiles));
            m_reloadTime = xd.ReadSingle(xe, nameof(m_reloadTime));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_maxProjectiles), m_maxProjectiles);
            xs.WriteFloat(xe, nameof(m_reloadTime), m_reloadTime);
            xs.WriteSerializeIgnored(xe, nameof(m_reload));
            xs.WriteSerializeIgnored(xe, nameof(m_projectiles));
            xs.WriteSerializeIgnored(xe, nameof(m_world));
            xs.WriteSerializeIgnored(xe, nameof(m_destructionWorld));
        }
    }
}

