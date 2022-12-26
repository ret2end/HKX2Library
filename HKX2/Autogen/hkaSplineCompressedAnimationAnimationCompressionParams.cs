using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaSplineCompressedAnimationAnimationCompressionParams Signatire: 0xde830789 size: 4 flags: FLAGS_NONE

    // m_maxFramesPerBlock m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_enableSampleSingleTracks m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    
    public class hkaSplineCompressedAnimationAnimationCompressionParams : IHavokObject
    {

        public ushort m_maxFramesPerBlock;
        public bool m_enableSampleSingleTracks;

        public uint Signature => 0xde830789;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_maxFramesPerBlock = br.ReadUInt16();
            m_enableSampleSingleTracks = br.ReadBoolean();
            br.Position += 1;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteUInt16(m_maxFramesPerBlock);
            bw.WriteBoolean(m_enableSampleSingleTracks);
            bw.Position += 1;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

