using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpTriggerVolumeEventInfo Signatire: 0xeb60f431 size: 24 flags: FLAGS_NONE

    // m_sortValue m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_body m_class: hkpRigidBody Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_operation m_class:  Type.TYPE_ENUM Type.TYPE_INT32 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: Operation
    public partial class hkpTriggerVolumeEventInfo : IHavokObject
    {
        public ulong m_sortValue { set; get; } = default;
        public hkpRigidBody? m_body { set; get; } = default;
        public int m_operation { set; get; } = default;

        public virtual uint Signature => 0xeb60f431;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_sortValue = br.ReadUInt64();
            m_body = des.ReadClassPointer<hkpRigidBody>(br);
            m_operation = br.ReadInt32();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt64(m_sortValue);
            s.WriteClassPointer(bw, m_body);
            bw.WriteInt32(m_operation);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_sortValue = xd.ReadUInt64(xe, nameof(m_sortValue));
            m_body = xd.ReadClassPointer<hkpRigidBody>(xe, nameof(m_body));
            m_operation = xd.ReadFlag<Operation, int>(xe, nameof(m_operation));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_sortValue), m_sortValue);
            xs.WriteClassPointer(xe, nameof(m_body), m_body);
            xs.WriteEnum<Operation, int>(xe, nameof(m_operation), m_operation);
        }
    }
}

