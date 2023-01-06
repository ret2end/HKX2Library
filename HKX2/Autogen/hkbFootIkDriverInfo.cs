using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbFootIkDriverInfo Signatire: 0xc6a09dbf size: 72 flags: FLAGS_NONE

    // m_legs m_class: hkbFootIkDriverInfoLeg Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_raycastDistanceUp m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_raycastDistanceDown m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags: FLAGS_NONE enum: 
    // m_originalGroundHeightMS m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_verticalOffset m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 44 flags: FLAGS_NONE enum: 
    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_forwardAlignFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 52 flags: FLAGS_NONE enum: 
    // m_sidewaysAlignFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    // m_sidewaysSampleWidth m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 60 flags: FLAGS_NONE enum: 
    // m_lockFeetWhenPlanted m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_useCharacterUpVector m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 65 flags: FLAGS_NONE enum: 
    // m_isQuadrupedNarrow m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 66 flags: FLAGS_NONE enum: 
    public partial class hkbFootIkDriverInfo : hkReferencedObject
    {
        public List<hkbFootIkDriverInfoLeg> m_legs = new List<hkbFootIkDriverInfoLeg>();
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
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_legs = xd.ReadClassArray<hkbFootIkDriverInfoLeg>(xe, nameof(m_legs));
            m_raycastDistanceUp = xd.ReadSingle(xe, nameof(m_raycastDistanceUp));
            m_raycastDistanceDown = xd.ReadSingle(xe, nameof(m_raycastDistanceDown));
            m_originalGroundHeightMS = xd.ReadSingle(xe, nameof(m_originalGroundHeightMS));
            m_verticalOffset = xd.ReadSingle(xe, nameof(m_verticalOffset));
            m_collisionFilterInfo = xd.ReadUInt32(xe, nameof(m_collisionFilterInfo));
            m_forwardAlignFraction = xd.ReadSingle(xe, nameof(m_forwardAlignFraction));
            m_sidewaysAlignFraction = xd.ReadSingle(xe, nameof(m_sidewaysAlignFraction));
            m_sidewaysSampleWidth = xd.ReadSingle(xe, nameof(m_sidewaysSampleWidth));
            m_lockFeetWhenPlanted = xd.ReadBoolean(xe, nameof(m_lockFeetWhenPlanted));
            m_useCharacterUpVector = xd.ReadBoolean(xe, nameof(m_useCharacterUpVector));
            m_isQuadrupedNarrow = xd.ReadBoolean(xe, nameof(m_isQuadrupedNarrow));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassArray<hkbFootIkDriverInfoLeg>(xe, nameof(m_legs), m_legs);
            xs.WriteFloat(xe, nameof(m_raycastDistanceUp), m_raycastDistanceUp);
            xs.WriteFloat(xe, nameof(m_raycastDistanceDown), m_raycastDistanceDown);
            xs.WriteFloat(xe, nameof(m_originalGroundHeightMS), m_originalGroundHeightMS);
            xs.WriteFloat(xe, nameof(m_verticalOffset), m_verticalOffset);
            xs.WriteNumber(xe, nameof(m_collisionFilterInfo), m_collisionFilterInfo);
            xs.WriteFloat(xe, nameof(m_forwardAlignFraction), m_forwardAlignFraction);
            xs.WriteFloat(xe, nameof(m_sidewaysAlignFraction), m_sidewaysAlignFraction);
            xs.WriteFloat(xe, nameof(m_sidewaysSampleWidth), m_sidewaysSampleWidth);
            xs.WriteBoolean(xe, nameof(m_lockFeetWhenPlanted), m_lockFeetWhenPlanted);
            xs.WriteBoolean(xe, nameof(m_useCharacterUpVector), m_useCharacterUpVector);
            xs.WriteBoolean(xe, nameof(m_isQuadrupedNarrow), m_isQuadrupedNarrow);
        }
    }
}

