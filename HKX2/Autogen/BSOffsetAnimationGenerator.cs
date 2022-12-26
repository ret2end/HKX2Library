using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSOffsetAnimationGenerator Signatire: 0xb8571122 size: 176 flags: FLAGS_NONE

    // m_pDefaultGenerator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: ALIGN_8|FLAGS_NONE enum: 
    // m_pOffsetClipGenerator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 96 flags: ALIGN_8|FLAGS_NONE enum: 
    // m_fOffsetVariable m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_fOffsetRangeStart m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 108 flags:  enum: 
    // m_fOffsetRangeEnd m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_BoneOffsetA m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 120 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_BoneIndexA m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 136 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_fCurrentPercentage m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 152 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_iCurrentFrame m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 156 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_bZeroOffset m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 160 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_bOffsetValid m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 161 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class BSOffsetAnimationGenerator : hkbGenerator
    {

        public hkbGenerator /*pointer struct*/ m_pDefaultGenerator;
        public hkbGenerator /*pointer struct*/ m_pOffsetClipGenerator;
        public float m_fOffsetVariable;
        public float m_fOffsetRangeStart;
        public float m_fOffsetRangeEnd;
        public List<ulong> m_BoneOffsetA;
        public List<ulong> m_BoneIndexA;
        public float m_fCurrentPercentage;
        public uint m_iCurrentFrame;
        public bool m_bZeroOffset;
        public bool m_bOffsetValid;

        public override uint Signature => 0xb8571122;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_pDefaultGenerator = des.ReadClassPointer<hkbGenerator>(br);
            br.Position += 8;
            m_pOffsetClipGenerator = des.ReadClassPointer<hkbGenerator>(br);
            m_fOffsetVariable = br.ReadSingle();
            m_fOffsetRangeStart = br.ReadSingle();
            m_fOffsetRangeEnd = br.ReadSingle();
            br.Position += 4;
            des.ReadEmptyArray(br); //m_BoneOffsetA
            des.ReadEmptyArray(br); //m_BoneIndexA
            m_fCurrentPercentage = br.ReadSingle();
            m_iCurrentFrame = br.ReadUInt32();
            m_bZeroOffset = br.ReadBoolean();
            m_bOffsetValid = br.ReadBoolean();
            br.Position += 14;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            s.WriteClassPointer(bw, m_pDefaultGenerator);
            bw.Position += 8;
            s.WriteClassPointer(bw, m_pOffsetClipGenerator);
            bw.WriteSingle(m_fOffsetVariable);
            bw.WriteSingle(m_fOffsetRangeStart);
            bw.WriteSingle(m_fOffsetRangeEnd);
            bw.Position += 4;
            s.WriteVoidArray(bw); // m_BoneOffsetA
            s.WriteVoidArray(bw); // m_BoneIndexA
            bw.WriteSingle(m_fCurrentPercentage);
            bw.WriteUInt32(m_iCurrentFrame);
            bw.WriteBoolean(m_bZeroOffset);
            bw.WriteBoolean(m_bOffsetValid);
            bw.Position += 14;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

