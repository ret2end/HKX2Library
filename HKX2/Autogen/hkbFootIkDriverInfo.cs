using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbFootIkDriverInfo Signatire: 0xc6a09dbf size: 72 flags: FLAGS_NONE

    // m_legs m_class: hkbFootIkDriverInfoLeg Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_raycastDistanceUp m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_raycastDistanceDown m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_originalGroundHeightMS m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_verticalOffset m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 44 flags:  enum: 
    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_forwardAlignFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 52 flags:  enum: 
    // m_sidewaysAlignFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    // m_sidewaysSampleWidth m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 60 flags:  enum: 
    // m_lockFeetWhenPlanted m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_useCharacterUpVector m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 65 flags:  enum: 
    // m_isQuadrupedNarrow m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 66 flags:  enum: 
    
    public class hkbFootIkDriverInfo : hkReferencedObject
    {

        public List<hkbFootIkDriverInfoLeg> m_legs;
        public float m_raycastDistanceUp;
        public float m_raycastDistanceDown;
        public float m_originalGroundHeightMS;
        public float m_verticalOffset;
        public uint m_collisionFilterInfo;
        public float m_forwardAlignFraction;
        public float m_sidewaysAlignFraction;
        public float m_sidewaysSampleWidth;
        public bool m_lockFeetWhenPlanted;
        public bool m_useCharacterUpVector;
        public bool m_isQuadrupedNarrow;

        public override uint Signature => 0xc6a09dbf;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_legs = des.ReadClassArray<hkbFootIkDriverInfoLeg>(br);
            m_raycastDistanceUp = br.ReadSingle();
            m_raycastDistanceDown = br.ReadSingle();
            m_originalGroundHeightMS = br.ReadSingle();
            m_verticalOffset = br.ReadSingle();
            m_collisionFilterInfo = br.ReadUInt32();
            m_forwardAlignFraction = br.ReadSingle();
            m_sidewaysAlignFraction = br.ReadSingle();
            m_sidewaysSampleWidth = br.ReadSingle();
            m_lockFeetWhenPlanted = br.ReadBoolean();
            m_useCharacterUpVector = br.ReadBoolean();
            m_isQuadrupedNarrow = br.ReadBoolean();
            br.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkbFootIkDriverInfoLeg>(bw, m_legs);
            bw.WriteSingle(m_raycastDistanceUp);
            bw.WriteSingle(m_raycastDistanceDown);
            bw.WriteSingle(m_originalGroundHeightMS);
            bw.WriteSingle(m_verticalOffset);
            bw.WriteUInt32(m_collisionFilterInfo);
            bw.WriteSingle(m_forwardAlignFraction);
            bw.WriteSingle(m_sidewaysAlignFraction);
            bw.WriteSingle(m_sidewaysSampleWidth);
            bw.WriteBoolean(m_lockFeetWhenPlanted);
            bw.WriteBoolean(m_useCharacterUpVector);
            bw.WriteBoolean(m_isQuadrupedNarrow);
            bw.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

