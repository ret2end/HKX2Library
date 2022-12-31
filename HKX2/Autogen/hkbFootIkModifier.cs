using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbFootIkModifier Signatire: 0xed8966c0 size: 256 flags: FLAGS_NONE

    // m_gains m_class: hkbFootIkGains Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_legs m_class: hkbFootIkModifierLeg Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_raycastDistanceUp m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_raycastDistanceDown m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 148 flags: FLAGS_NONE enum: 
    // m_originalGroundHeightMS m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 152 flags: FLAGS_NONE enum: 
    // m_errorOut m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 156 flags: FLAGS_NONE enum: 
    // m_errorOutTranslation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 160 flags: FLAGS_NONE enum: 
    // m_alignWithGroundRotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 176 flags: FLAGS_NONE enum: 
    // m_verticalOffset m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 192 flags: FLAGS_NONE enum: 
    // m_collisionFilterInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 196 flags: FLAGS_NONE enum: 
    // m_forwardAlignFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 200 flags: FLAGS_NONE enum: 
    // m_sidewaysAlignFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 204 flags: FLAGS_NONE enum: 
    // m_sidewaysSampleWidth m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 208 flags: FLAGS_NONE enum: 
    // m_useTrackData m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 212 flags: FLAGS_NONE enum: 
    // m_lockFeetWhenPlanted m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 213 flags: FLAGS_NONE enum: 
    // m_useCharacterUpVector m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 214 flags: FLAGS_NONE enum: 
    // m_alignMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 215 flags: FLAGS_NONE enum: AlignMode
    // m_internalLegData m_class: hkbFootIkModifierInternalLegData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 216 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_prevIsFootIkEnabled m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 232 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_isSetUp m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 236 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_isGroundPositionValid m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 237 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_timeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 240 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbFootIkModifier : hkbModifier
    {
        public hkbFootIkGains m_gains;
        public List<hkbFootIkModifierLeg> m_legs;
        public float m_raycastDistanceUp;
        public float m_raycastDistanceDown;
        public float m_originalGroundHeightMS;
        public float m_errorOut;
        public Vector4 m_errorOutTranslation;
        public Quaternion m_alignWithGroundRotation;
        public float m_verticalOffset;
        public uint m_collisionFilterInfo;
        public float m_forwardAlignFraction;
        public float m_sidewaysAlignFraction;
        public float m_sidewaysSampleWidth;
        public bool m_useTrackData;
        public bool m_lockFeetWhenPlanted;
        public bool m_useCharacterUpVector;
        public sbyte m_alignMode;
        public List<hkbFootIkModifierInternalLegData> m_internalLegData;
        public float m_prevIsFootIkEnabled;
        public bool m_isSetUp;
        public bool m_isGroundPositionValid;
        public float m_timeStep;

        public override uint Signature => 0xed8966c0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_gains = new hkbFootIkGains();
            m_gains.Read(des, br);
            m_legs = des.ReadClassArray<hkbFootIkModifierLeg>(br);
            m_raycastDistanceUp = br.ReadSingle();
            m_raycastDistanceDown = br.ReadSingle();
            m_originalGroundHeightMS = br.ReadSingle();
            m_errorOut = br.ReadSingle();
            m_errorOutTranslation = br.ReadVector4();
            m_alignWithGroundRotation = des.ReadQuaternion(br);
            m_verticalOffset = br.ReadSingle();
            m_collisionFilterInfo = br.ReadUInt32();
            m_forwardAlignFraction = br.ReadSingle();
            m_sidewaysAlignFraction = br.ReadSingle();
            m_sidewaysSampleWidth = br.ReadSingle();
            m_useTrackData = br.ReadBoolean();
            m_lockFeetWhenPlanted = br.ReadBoolean();
            m_useCharacterUpVector = br.ReadBoolean();
            m_alignMode = br.ReadSByte();
            m_internalLegData = des.ReadClassArray<hkbFootIkModifierInternalLegData>(br);
            m_prevIsFootIkEnabled = br.ReadSingle();
            m_isSetUp = br.ReadBoolean();
            m_isGroundPositionValid = br.ReadBoolean();
            br.Position += 2;
            m_timeStep = br.ReadSingle();
            br.Position += 12;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_gains.Write(s, bw);
            s.WriteClassArray<hkbFootIkModifierLeg>(bw, m_legs);
            bw.WriteSingle(m_raycastDistanceUp);
            bw.WriteSingle(m_raycastDistanceDown);
            bw.WriteSingle(m_originalGroundHeightMS);
            bw.WriteSingle(m_errorOut);
            bw.WriteVector4(m_errorOutTranslation);
            s.WriteQuaternion(bw, m_alignWithGroundRotation);
            bw.WriteSingle(m_verticalOffset);
            bw.WriteUInt32(m_collisionFilterInfo);
            bw.WriteSingle(m_forwardAlignFraction);
            bw.WriteSingle(m_sidewaysAlignFraction);
            bw.WriteSingle(m_sidewaysSampleWidth);
            bw.WriteBoolean(m_useTrackData);
            bw.WriteBoolean(m_lockFeetWhenPlanted);
            bw.WriteBoolean(m_useCharacterUpVector);
            s.WriteSByte(bw, m_alignMode);
            s.WriteClassArray<hkbFootIkModifierInternalLegData>(bw, m_internalLegData);
            bw.WriteSingle(m_prevIsFootIkEnabled);
            bw.WriteBoolean(m_isSetUp);
            bw.WriteBoolean(m_isGroundPositionValid);
            bw.Position += 2;
            bw.WriteSingle(m_timeStep);
            bw.Position += 12;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkbFootIkGains>(xe, nameof(m_gains), m_gains);
            xs.WriteClassArray<hkbFootIkModifierLeg>(xe, nameof(m_legs), m_legs);
            xs.WriteFloat(xe, nameof(m_raycastDistanceUp), m_raycastDistanceUp);
            xs.WriteFloat(xe, nameof(m_raycastDistanceDown), m_raycastDistanceDown);
            xs.WriteFloat(xe, nameof(m_originalGroundHeightMS), m_originalGroundHeightMS);
            xs.WriteFloat(xe, nameof(m_errorOut), m_errorOut);
            xs.WriteVector4(xe, nameof(m_errorOutTranslation), m_errorOutTranslation);
            xs.WriteQuaternion(xe, nameof(m_alignWithGroundRotation), m_alignWithGroundRotation);
            xs.WriteFloat(xe, nameof(m_verticalOffset), m_verticalOffset);
            xs.WriteNumber(xe, nameof(m_collisionFilterInfo), m_collisionFilterInfo);
            xs.WriteFloat(xe, nameof(m_forwardAlignFraction), m_forwardAlignFraction);
            xs.WriteFloat(xe, nameof(m_sidewaysAlignFraction), m_sidewaysAlignFraction);
            xs.WriteFloat(xe, nameof(m_sidewaysSampleWidth), m_sidewaysSampleWidth);
            xs.WriteBoolean(xe, nameof(m_useTrackData), m_useTrackData);
            xs.WriteBoolean(xe, nameof(m_lockFeetWhenPlanted), m_lockFeetWhenPlanted);
            xs.WriteBoolean(xe, nameof(m_useCharacterUpVector), m_useCharacterUpVector);
            xs.WriteEnum<AlignMode, sbyte>(xe, nameof(m_alignMode), m_alignMode);
            xs.WriteSerializeIgnored(xe, nameof(m_internalLegData));
            xs.WriteSerializeIgnored(xe, nameof(m_prevIsFootIkEnabled));
            xs.WriteSerializeIgnored(xe, nameof(m_isSetUp));
            xs.WriteSerializeIgnored(xe, nameof(m_isGroundPositionValid));
            xs.WriteSerializeIgnored(xe, nameof(m_timeStep));
        }
    }
}

