using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // BSSynchronizedClipGenerator Signatire: 0xd83bea64 size: 304 flags: FLAGS_NONE

    // m_pClipGenerator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: ALIGN_8|FLAGS_NONE enum: 
    // m_SyncAnimPrefix m_class:  Type.TYPE_CSTRING Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_bSyncClipIgnoreMarkPlacement m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_fGetToMarkTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    // m_fMarkErrorThreshold m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_bLeadCharacter m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 108 flags:  enum: 
    // m_bReorientSupportChar m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 109 flags:  enum: 
    // m_bApplyMotionFromRoot m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 110 flags:  enum: 
    // m_pSyncScene m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 112 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_StartMarkWS m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 128 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_EndMarkWS m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 176 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_StartMarkMS m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 224 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_fCurrentLerp m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 272 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_pLocalSyncBinding m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 280 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_pEventMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 288 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_sAnimationBindingIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 296 flags:  enum: 
    // m_bAtMark m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 298 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_bAllCharactersInScene m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 299 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_bAllCharactersAtMarks m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 300 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 

    public class BSSynchronizedClipGenerator : hkbGenerator
    {

        public hkbGenerator /*pointer struct*/ m_pClipGenerator;
        public string m_SyncAnimPrefix;
        public bool m_bSyncClipIgnoreMarkPlacement;
        public float m_fGetToMarkTime;
        public float m_fMarkErrorThreshold;
        public bool m_bLeadCharacter;
        public bool m_bReorientSupportChar;
        public bool m_bApplyMotionFromRoot;
        public dynamic /* POINTER VOID */ m_pSyncScene;
        public Matrix4x4 m_StartMarkWS;
        public Matrix4x4 m_EndMarkWS;
        public Matrix4x4 m_StartMarkMS;
        public float m_fCurrentLerp;
        public dynamic /* POINTER VOID */ m_pLocalSyncBinding;
        public dynamic /* POINTER VOID */ m_pEventMap;
        public short m_sAnimationBindingIndex;
        public bool m_bAtMark;
        public bool m_bAllCharactersInScene;
        public bool m_bAllCharactersAtMarks;

        public override uint Signature => 0xd83bea64;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_pClipGenerator = des.ReadClassPointer<hkbGenerator>(br);
            m_SyncAnimPrefix = des.ReadStringPointer(br);//m_SyncAnimPrefix = br.ReadASCII(8);
            m_bSyncClipIgnoreMarkPlacement = br.ReadBoolean();
            br.Position += 3;
            m_fGetToMarkTime = br.ReadSingle();
            m_fMarkErrorThreshold = br.ReadSingle();
            m_bLeadCharacter = br.ReadBoolean();
            m_bReorientSupportChar = br.ReadBoolean();
            m_bApplyMotionFromRoot = br.ReadBoolean();
            br.Position += 1;
            des.ReadEmptyPointer(br);/* m_pSyncScene POINTER VOID */
            br.Position += 8;
            m_StartMarkWS = des.ReadQSTransform(br);
            m_EndMarkWS = des.ReadQSTransform(br);
            m_StartMarkMS = des.ReadQSTransform(br);
            m_fCurrentLerp = br.ReadSingle();
            br.Position += 4;
            des.ReadEmptyPointer(br);/* m_pLocalSyncBinding POINTER VOID */
            des.ReadEmptyPointer(br);/* m_pEventMap POINTER VOID */
            m_sAnimationBindingIndex = br.ReadInt16();
            m_bAtMark = br.ReadBoolean();
            m_bAllCharactersInScene = br.ReadBoolean();
            m_bAllCharactersAtMarks = br.ReadBoolean();
            br.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            s.WriteClassPointer(bw, m_pClipGenerator);
            s.WriteStringPointer(bw, m_SyncAnimPrefix);//bw.WriteASCII(m_SyncAnimPrefix, true);
            bw.WriteBoolean(m_bSyncClipIgnoreMarkPlacement);
            bw.Position += 3;
            bw.WriteSingle(m_fGetToMarkTime);
            bw.WriteSingle(m_fMarkErrorThreshold);
            bw.WriteBoolean(m_bLeadCharacter);
            bw.WriteBoolean(m_bReorientSupportChar);
            bw.WriteBoolean(m_bApplyMotionFromRoot);
            bw.Position += 1;
            s.WriteVoidPointer(bw);/* m_pSyncScene POINTER VOID */
            bw.Position += 8;
            s.WriteQSTransform(bw, m_StartMarkWS);
            s.WriteQSTransform(bw, m_EndMarkWS);
            s.WriteQSTransform(bw, m_StartMarkMS);
            bw.WriteSingle(m_fCurrentLerp);
            bw.Position += 4;
            s.WriteVoidPointer(bw);/* m_pLocalSyncBinding POINTER VOID */
            s.WriteVoidPointer(bw);/* m_pEventMap POINTER VOID */
            bw.WriteInt16(m_sAnimationBindingIndex);
            bw.WriteBoolean(m_bAtMark);
            bw.WriteBoolean(m_bAllCharactersInScene);
            bw.WriteBoolean(m_bAllCharactersAtMarks);
            bw.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

