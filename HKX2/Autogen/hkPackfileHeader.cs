using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkPackfileHeader Signatire: 0x79f9ffda size: 64 flags: FLAGS_NONE

    // m_magic m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 2 offset: 0 flags:  enum: 
    // m_userTag m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_fileVersion m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    // m_layoutRules m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 4 offset: 16 flags:  enum: 
    // m_numSections m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_contentsSectionIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_contentsSectionOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    // m_contentsClassNameSectionIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_contentsClassNameSectionOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_contentsVersion m_class:  Type.TYPE_CHAR Type.TYPE_VOID arrSize: 16 offset: 40 flags:  enum: 
    // m_flags m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    // m_pad m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 1 offset: 60 flags:  enum: 

    public class hkPackfileHeader : IHavokObject
    {

        public List<int> m_magic;
        public int m_userTag;
        public int m_fileVersion;
        public List<byte> m_layoutRules;
        public int m_numSections;
        public int m_contentsSectionIndex;
        public int m_contentsSectionOffset;
        public int m_contentsClassNameSectionIndex;
        public int m_contentsClassNameSectionOffset;
        public string m_contentsVersion;
        public int m_flags;
        public List<int> m_pad;

        public uint Signature => 0x79f9ffda;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_magic = des.ReadInt32CStyleArray(br, 2);//m_magic = br.ReadInt32();
            m_userTag = br.ReadInt32();
            m_fileVersion = br.ReadInt32();
            m_layoutRules = des.ReadByteCStyleArray(br, 4);//m_layoutRules = br.ReadByte();
            m_numSections = br.ReadInt32();
            m_contentsSectionIndex = br.ReadInt32();
            m_contentsSectionOffset = br.ReadInt32();
            m_contentsClassNameSectionIndex = br.ReadInt32();
            m_contentsClassNameSectionOffset = br.ReadInt32();
            m_contentsVersion = br.ReadASCII(16);
            m_flags = br.ReadInt32();
            m_pad = des.ReadInt32CStyleArray(br, 1);//m_pad = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteInt32CStyleArray(bw, m_magic);//bw.WriteInt32(m_magic);
            bw.WriteInt32(m_userTag);
            bw.WriteInt32(m_fileVersion);
            s.WriteByteCStyleArray(bw, m_layoutRules);//bw.WriteByte(m_layoutRules);
            bw.WriteInt32(m_numSections);
            bw.WriteInt32(m_contentsSectionIndex);
            bw.WriteInt32(m_contentsSectionOffset);
            bw.WriteInt32(m_contentsClassNameSectionIndex);
            bw.WriteInt32(m_contentsClassNameSectionOffset);
            bw.WriteASCII(m_contentsVersion);
            bw.WriteInt32(m_flags);
            s.WriteInt32CStyleArray(bw, m_pad);//bw.WriteInt32(m_pad);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

