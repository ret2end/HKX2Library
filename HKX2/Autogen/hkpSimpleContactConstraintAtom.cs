using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSimpleContactConstraintAtom Signatire: 0x920df11a size: 48 flags: FLAGS_NONE

    // m_sizeOfAllAtoms m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_numContactPoints m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_numReservedContactPoints m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 6 flags:  enum: 
    // m_numUserDatasForBodyA m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_numUserDatasForBodyB m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 9 flags:  enum: 
    // m_contactPointPropertiesStriding m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 10 flags:  enum: 
    // m_maxNumContactPoints m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    // m_info m_class: hkpSimpleContactConstraintDataInfo Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags: ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpSimpleContactConstraintAtom : hkpConstraintAtom
    {

        public ushort m_sizeOfAllAtoms;
        public ushort m_numContactPoints;
        public ushort m_numReservedContactPoints;
        public byte m_numUserDatasForBodyA;
        public byte m_numUserDatasForBodyB;
        public byte m_contactPointPropertiesStriding;
        public ushort m_maxNumContactPoints;
        public hkpSimpleContactConstraintDataInfo/*struct void*/ m_info;

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
            m_info = new hkpSimpleContactConstraintDataInfo();
            m_info.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
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

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

