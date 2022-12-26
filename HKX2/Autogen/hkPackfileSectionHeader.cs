using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkPackfileSectionHeader Signatire: 0xf2a92154 size: 48 flags: FLAGS_NONE

    // m_sectionTag m_class:  Type.TYPE_CHAR Type.TYPE_VOID arrSize: 19 offset: 0 flags:  enum: 
    // m_nullByte m_class:  Type.TYPE_CHAR Type.TYPE_VOID arrSize: 0 offset: 19 flags:  enum: 
    // m_absoluteDataStart m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_localFixupsOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_globalFixupsOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    // m_virtualFixupsOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_exportsOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_importsOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_endOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 44 flags:  enum: 
    
    public class hkPackfileSectionHeader : IHavokObject
    {

        public string m_sectionTag;
        public string/*char*/ m_nullByte;
        public int m_absoluteDataStart;
        public int m_localFixupsOffset;
        public int m_globalFixupsOffset;
        public int m_virtualFixupsOffset;
        public int m_exportsOffset;
        public int m_importsOffset;
        public int m_endOffset;

        public uint Signature => 0xf2a92154;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_sectionTag = br.ReadASCII(19);
            m_nullByte = br.ReadASCII();
            m_absoluteDataStart = br.ReadInt32();
            m_localFixupsOffset = br.ReadInt32();
            m_globalFixupsOffset = br.ReadInt32();
            m_virtualFixupsOffset = br.ReadInt32();
            m_exportsOffset = br.ReadInt32();
            m_importsOffset = br.ReadInt32();
            m_endOffset = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteASCII(m_sectionTag);
            bw.WriteASCII(m_nullByte);
            bw.WriteInt32(m_absoluteDataStart);
            bw.WriteInt32(m_localFixupsOffset);
            bw.WriteInt32(m_globalFixupsOffset);
            bw.WriteInt32(m_virtualFixupsOffset);
            bw.WriteInt32(m_exportsOffset);
            bw.WriteInt32(m_importsOffset);
            bw.WriteInt32(m_endOffset);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

