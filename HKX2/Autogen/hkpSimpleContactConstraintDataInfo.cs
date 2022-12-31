using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkpSimpleContactConstraintDataInfo Signatire: 0xb59d1734 size: 32 flags: FLAGS_NONE

    // m_flags m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 0 flags: ALIGN_16|FLAGS_NONE enum: 
    // m_index m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 2 flags: FLAGS_NONE enum: 
    // m_internalData0 m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_rollingFrictionMultiplier m_class:  Type.TYPE_HALF Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_internalData1 m_class:  Type.TYPE_HALF Type.TYPE_VOID arrSize: 0 offset: 10 flags: FLAGS_NONE enum: 
    // m_data m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 5 offset: 12 flags: FLAGS_NONE enum: 
    public partial class hkpSimpleContactConstraintDataInfo : IHavokObject
    {
        public ushort m_flags;
        public ushort m_index;
        public float m_internalData0;
        public Half m_rollingFrictionMultiplier;
        public Half m_internalData1;
        public List<uint> m_data;

        public virtual uint Signature => 0xb59d1734;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_flags = br.ReadUInt16();
            m_index = br.ReadUInt16();
            m_internalData0 = br.ReadSingle();
            m_rollingFrictionMultiplier = br.ReadHalf();
            m_internalData1 = br.ReadHalf();
            m_data = des.ReadUInt32CStyleArray(br, 5);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_flags);
            bw.WriteUInt16(m_index);
            bw.WriteSingle(m_internalData0);
            bw.WriteHalf(m_rollingFrictionMultiplier);
            bw.WriteHalf(m_internalData1);
            s.WriteUInt32CStyleArray(bw, m_data);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteNumber(xe, nameof(m_flags), m_flags);
            xs.WriteNumber(xe, nameof(m_index), m_index);
            xs.WriteFloat(xe, nameof(m_internalData0), m_internalData0);
            xs.WriteFloat(xe, nameof(m_rollingFrictionMultiplier), m_rollingFrictionMultiplier);
            xs.WriteFloat(xe, nameof(m_internalData1), m_internalData1);
            xs.WriteNumberArray(xe, nameof(m_data), m_data);
        }
    }
}

