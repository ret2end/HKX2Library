using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkaSplineCompressedAnimation Signatire: 0x792ee0bb size: 176 flags: FLAGS_NONE

    // m_numFrames m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    // m_numBlocks m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 60 flags: FLAGS_NONE enum: 
    // m_maxFramesPerBlock m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_maskAndQuantizationSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 68 flags: FLAGS_NONE enum: 
    // m_blockDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_blockInverseDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 76 flags: FLAGS_NONE enum: 
    // m_frameDuration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_blockOffsets m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_floatBlockOffsets m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // m_transformOffsets m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 120 flags: FLAGS_NONE enum: 
    // m_floatOffsets m_class:  Type.TYPE_ARRAY Type.TYPE_UINT32 arrSize: 0 offset: 136 flags: FLAGS_NONE enum: 
    // m_data m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 152 flags: FLAGS_NONE enum: 
    // m_endian m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 168 flags: FLAGS_NONE enum: 
    public partial class hkaSplineCompressedAnimation : hkaAnimation
    {
        public int m_numFrames;
        public int m_numBlocks;
        public int m_maxFramesPerBlock;
        public int m_maskAndQuantizationSize;
        public float m_blockDuration;
        public float m_blockInverseDuration;
        public float m_frameDuration;
        public List<uint> m_blockOffsets;
        public List<uint> m_floatBlockOffsets;
        public List<uint> m_transformOffsets;
        public List<uint> m_floatOffsets;
        public List<byte> m_data;
        public int m_endian;

        public override uint Signature => 0x792ee0bb;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_numFrames = br.ReadInt32();
            m_numBlocks = br.ReadInt32();
            m_maxFramesPerBlock = br.ReadInt32();
            m_maskAndQuantizationSize = br.ReadInt32();
            m_blockDuration = br.ReadSingle();
            m_blockInverseDuration = br.ReadSingle();
            m_frameDuration = br.ReadSingle();
            br.Position += 4;
            m_blockOffsets = des.ReadUInt32Array(br);
            m_floatBlockOffsets = des.ReadUInt32Array(br);
            m_transformOffsets = des.ReadUInt32Array(br);
            m_floatOffsets = des.ReadUInt32Array(br);
            m_data = des.ReadByteArray(br);
            m_endian = br.ReadInt32();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteInt32(m_numFrames);
            bw.WriteInt32(m_numBlocks);
            bw.WriteInt32(m_maxFramesPerBlock);
            bw.WriteInt32(m_maskAndQuantizationSize);
            bw.WriteSingle(m_blockDuration);
            bw.WriteSingle(m_blockInverseDuration);
            bw.WriteSingle(m_frameDuration);
            bw.Position += 4;
            s.WriteUInt32Array(bw, m_blockOffsets);
            s.WriteUInt32Array(bw, m_floatBlockOffsets);
            s.WriteUInt32Array(bw, m_transformOffsets);
            s.WriteUInt32Array(bw, m_floatOffsets);
            s.WriteByteArray(bw, m_data);
            bw.WriteInt32(m_endian);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_numFrames), m_numFrames);
            xs.WriteNumber(xe, nameof(m_numBlocks), m_numBlocks);
            xs.WriteNumber(xe, nameof(m_maxFramesPerBlock), m_maxFramesPerBlock);
            xs.WriteNumber(xe, nameof(m_maskAndQuantizationSize), m_maskAndQuantizationSize);
            xs.WriteFloat(xe, nameof(m_blockDuration), m_blockDuration);
            xs.WriteFloat(xe, nameof(m_blockInverseDuration), m_blockInverseDuration);
            xs.WriteFloat(xe, nameof(m_frameDuration), m_frameDuration);
            xs.WriteNumberArray(xe, nameof(m_blockOffsets), m_blockOffsets);
            xs.WriteNumberArray(xe, nameof(m_floatBlockOffsets), m_floatBlockOffsets);
            xs.WriteNumberArray(xe, nameof(m_transformOffsets), m_transformOffsets);
            xs.WriteNumberArray(xe, nameof(m_floatOffsets), m_floatOffsets);
            xs.WriteNumberArray(xe, nameof(m_data), m_data);
            xs.WriteNumber(xe, nameof(m_endian), m_endian);
        }
    }
}

