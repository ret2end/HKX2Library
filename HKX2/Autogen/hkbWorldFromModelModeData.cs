using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbWorldFromModelModeData Signatire: 0xa3af8783 size: 8 flags: FLAGS_NONE

    // m_poseMatchingBone0 m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_poseMatchingBone1 m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_poseMatchingBone2 m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_mode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 6 flags:  enum: WorldFromModelMode
    
    public class hkbWorldFromModelModeData : IHavokObject
    {

        public short m_poseMatchingBone0;
        public short m_poseMatchingBone1;
        public short m_poseMatchingBone2;
        public sbyte m_mode;

        public uint Signature => 0xa3af8783;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_poseMatchingBone0 = br.ReadInt16();
            m_poseMatchingBone1 = br.ReadInt16();
            m_poseMatchingBone2 = br.ReadInt16();
            m_mode = br.ReadSByte();
            br.Position += 1;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteInt16(m_poseMatchingBone0);
            bw.WriteInt16(m_poseMatchingBone1);
            bw.WriteInt16(m_poseMatchingBone2);
            s.WriteSByte(bw, m_mode);
            bw.Position += 1;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

