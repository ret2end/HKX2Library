using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpSimpleContactConstraintAtom Signatire: 0x920df11a size: 48 flags: FLAGS_NONE

    // m_sizeOfAllAtoms m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 2 flags: FLAGS_NONE enum: 
    // m_numContactPoints m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_numReservedContactPoints m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 6 flags: FLAGS_NONE enum: 
    // m_numUserDatasForBodyA m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_numUserDatasForBodyB m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 9 flags: FLAGS_NONE enum: 
    // m_contactPointPropertiesStriding m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 10 flags: FLAGS_NONE enum: 
    // m_maxNumContactPoints m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    // m_info m_class: hkpSimpleContactConstraintDataInfo Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags: ALIGN_16|FLAGS_NONE enum: 
    public partial class hkpSimpleContactConstraintAtom : hkpConstraintAtom
    {
        public ushort m_sizeOfAllAtoms { set; get; } = default;
        public ushort m_numContactPoints { set; get; } = default;
        public ushort m_numReservedContactPoints { set; get; } = default;
        public byte m_numUserDatasForBodyA { set; get; } = default;
        public byte m_numUserDatasForBodyB { set; get; } = default;
        public byte m_contactPointPropertiesStriding { set; get; } = default;
        public ushort m_maxNumContactPoints { set; get; } = default;
        public hkpSimpleContactConstraintDataInfo m_info { set; get; } = new();

        public override uint Signature => 0x920df11a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_sizeOfAllAtoms = br.ReadUInt16();
            m_numContactPoints = br.ReadUInt16();
            m_numReservedContactPoints = br.ReadUInt16();
            m_numUserDatasForBodyA = br.ReadByte();
            m_numUserDatasForBodyB = br.ReadByte();
            m_contactPointPropertiesStriding = br.ReadByte();
            br.Position += 1;
            m_maxNumContactPoints = br.ReadUInt16();
            br.Position += 2;
            m_info.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt16(m_sizeOfAllAtoms);
            bw.WriteUInt16(m_numContactPoints);
            bw.WriteUInt16(m_numReservedContactPoints);
            bw.WriteByte(m_numUserDatasForBodyA);
            bw.WriteByte(m_numUserDatasForBodyB);
            bw.WriteByte(m_contactPointPropertiesStriding);
            bw.Position += 1;
            bw.WriteUInt16(m_maxNumContactPoints);
            bw.Position += 2;
            m_info.Write(s, bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_sizeOfAllAtoms = xd.ReadUInt16(xe, nameof(m_sizeOfAllAtoms));
            m_numContactPoints = xd.ReadUInt16(xe, nameof(m_numContactPoints));
            m_numReservedContactPoints = xd.ReadUInt16(xe, nameof(m_numReservedContactPoints));
            m_numUserDatasForBodyA = xd.ReadByte(xe, nameof(m_numUserDatasForBodyA));
            m_numUserDatasForBodyB = xd.ReadByte(xe, nameof(m_numUserDatasForBodyB));
            m_contactPointPropertiesStriding = xd.ReadByte(xe, nameof(m_contactPointPropertiesStriding));
            m_maxNumContactPoints = xd.ReadUInt16(xe, nameof(m_maxNumContactPoints));
            m_info = xd.ReadClass<hkpSimpleContactConstraintDataInfo>(xe, nameof(m_info));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_sizeOfAllAtoms), m_sizeOfAllAtoms);
            xs.WriteNumber(xe, nameof(m_numContactPoints), m_numContactPoints);
            xs.WriteNumber(xe, nameof(m_numReservedContactPoints), m_numReservedContactPoints);
            xs.WriteNumber(xe, nameof(m_numUserDatasForBodyA), m_numUserDatasForBodyA);
            xs.WriteNumber(xe, nameof(m_numUserDatasForBodyB), m_numUserDatasForBodyB);
            xs.WriteNumber(xe, nameof(m_contactPointPropertiesStriding), m_contactPointPropertiesStriding);
            xs.WriteNumber(xe, nameof(m_maxNumContactPoints), m_maxNumContactPoints);
            xs.WriteClass<hkpSimpleContactConstraintDataInfo>(xe, nameof(m_info), m_info);
        }
    }
}

