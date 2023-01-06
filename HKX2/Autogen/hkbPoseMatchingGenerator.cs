using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbPoseMatchingGenerator Signatire: 0x29e271b4 size: 240 flags: FLAGS_NONE

    // m_worldFromModelRotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 160 flags: FLAGS_NONE enum: 
    // m_blendSpeed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 176 flags: FLAGS_NONE enum: 
    // m_minSpeedToSwitch m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 180 flags: FLAGS_NONE enum: 
    // m_minSwitchTimeNoError m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 184 flags: FLAGS_NONE enum: 
    // m_minSwitchTimeFullError m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 188 flags: FLAGS_NONE enum: 
    // m_startPlayingEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 192 flags: FLAGS_NONE enum: 
    // m_startMatchingEventId m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 196 flags: FLAGS_NONE enum: 
    // m_rootBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 200 flags: FLAGS_NONE enum: 
    // m_otherBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 202 flags: FLAGS_NONE enum: 
    // m_anotherBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 204 flags: FLAGS_NONE enum: 
    // m_pelvisIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 206 flags: FLAGS_NONE enum: 
    // m_mode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 208 flags: FLAGS_NONE enum: Mode
    // m_currentMatch m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 212 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_bestMatch m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 216 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_timeSinceBetterMatch m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 220 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_error m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 224 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_resetCurrentMatchLocalTime m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 228 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_poseMatchingUtility m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 232 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbPoseMatchingGenerator : hkbBlenderGenerator
    {
        public Quaternion m_worldFromModelRotation;
        public float m_blendSpeed;
        public float m_minSpeedToSwitch;
        public float m_minSwitchTimeNoError;
        public float m_minSwitchTimeFullError;
        public int m_startPlayingEventId;
        public int m_startMatchingEventId;
        public short m_rootBoneIndex;
        public short m_otherBoneIndex;
        public short m_anotherBoneIndex;
        public short m_pelvisIndex;
        public sbyte m_mode;
        public int m_currentMatch;
        public int m_bestMatch;
        public float m_timeSinceBetterMatch;
        public float m_error;
        public bool m_resetCurrentMatchLocalTime;
        public dynamic m_poseMatchingUtility;

        public override uint Signature => 0x29e271b4;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_worldFromModelRotation = des.ReadQuaternion(br);
            m_blendSpeed = br.ReadSingle();
            m_minSpeedToSwitch = br.ReadSingle();
            m_minSwitchTimeNoError = br.ReadSingle();
            m_minSwitchTimeFullError = br.ReadSingle();
            m_startPlayingEventId = br.ReadInt32();
            m_startMatchingEventId = br.ReadInt32();
            m_rootBoneIndex = br.ReadInt16();
            m_otherBoneIndex = br.ReadInt16();
            m_anotherBoneIndex = br.ReadInt16();
            m_pelvisIndex = br.ReadInt16();
            m_mode = br.ReadSByte();
            br.Position += 3;
            m_currentMatch = br.ReadInt32();
            m_bestMatch = br.ReadInt32();
            m_timeSinceBetterMatch = br.ReadSingle();
            m_error = br.ReadSingle();
            m_resetCurrentMatchLocalTime = br.ReadBoolean();
            br.Position += 3;
            des.ReadEmptyPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteQuaternion(bw, m_worldFromModelRotation);
            bw.WriteSingle(m_blendSpeed);
            bw.WriteSingle(m_minSpeedToSwitch);
            bw.WriteSingle(m_minSwitchTimeNoError);
            bw.WriteSingle(m_minSwitchTimeFullError);
            bw.WriteInt32(m_startPlayingEventId);
            bw.WriteInt32(m_startMatchingEventId);
            bw.WriteInt16(m_rootBoneIndex);
            bw.WriteInt16(m_otherBoneIndex);
            bw.WriteInt16(m_anotherBoneIndex);
            bw.WriteInt16(m_pelvisIndex);
            s.WriteSByte(bw, m_mode);
            bw.Position += 3;
            bw.WriteInt32(m_currentMatch);
            bw.WriteInt32(m_bestMatch);
            bw.WriteSingle(m_timeSinceBetterMatch);
            bw.WriteSingle(m_error);
            bw.WriteBoolean(m_resetCurrentMatchLocalTime);
            bw.Position += 3;
            s.WriteVoidPointer(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_worldFromModelRotation = xd.ReadQuaternion(xe, nameof(m_worldFromModelRotation));
            m_blendSpeed = xd.ReadSingle(xe, nameof(m_blendSpeed));
            m_minSpeedToSwitch = xd.ReadSingle(xe, nameof(m_minSpeedToSwitch));
            m_minSwitchTimeNoError = xd.ReadSingle(xe, nameof(m_minSwitchTimeNoError));
            m_minSwitchTimeFullError = xd.ReadSingle(xe, nameof(m_minSwitchTimeFullError));
            m_startPlayingEventId = xd.ReadInt32(xe, nameof(m_startPlayingEventId));
            m_startMatchingEventId = xd.ReadInt32(xe, nameof(m_startMatchingEventId));
            m_rootBoneIndex = xd.ReadInt16(xe, nameof(m_rootBoneIndex));
            m_otherBoneIndex = xd.ReadInt16(xe, nameof(m_otherBoneIndex));
            m_anotherBoneIndex = xd.ReadInt16(xe, nameof(m_anotherBoneIndex));
            m_pelvisIndex = xd.ReadInt16(xe, nameof(m_pelvisIndex));
            m_mode = xd.ReadFlag<Mode, sbyte>(xe, nameof(m_mode));
            m_currentMatch = default;
            m_bestMatch = default;
            m_timeSinceBetterMatch = default;
            m_error = default;
            m_resetCurrentMatchLocalTime = default;
            m_poseMatchingUtility = default;
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteQuaternion(xe, nameof(m_worldFromModelRotation), m_worldFromModelRotation);
            xs.WriteFloat(xe, nameof(m_blendSpeed), m_blendSpeed);
            xs.WriteFloat(xe, nameof(m_minSpeedToSwitch), m_minSpeedToSwitch);
            xs.WriteFloat(xe, nameof(m_minSwitchTimeNoError), m_minSwitchTimeNoError);
            xs.WriteFloat(xe, nameof(m_minSwitchTimeFullError), m_minSwitchTimeFullError);
            xs.WriteNumber(xe, nameof(m_startPlayingEventId), m_startPlayingEventId);
            xs.WriteNumber(xe, nameof(m_startMatchingEventId), m_startMatchingEventId);
            xs.WriteNumber(xe, nameof(m_rootBoneIndex), m_rootBoneIndex);
            xs.WriteNumber(xe, nameof(m_otherBoneIndex), m_otherBoneIndex);
            xs.WriteNumber(xe, nameof(m_anotherBoneIndex), m_anotherBoneIndex);
            xs.WriteNumber(xe, nameof(m_pelvisIndex), m_pelvisIndex);
            xs.WriteEnum<Mode, sbyte>(xe, nameof(m_mode), m_mode);
            xs.WriteSerializeIgnored(xe, nameof(m_currentMatch));
            xs.WriteSerializeIgnored(xe, nameof(m_bestMatch));
            xs.WriteSerializeIgnored(xe, nameof(m_timeSinceBetterMatch));
            xs.WriteSerializeIgnored(xe, nameof(m_error));
            xs.WriteSerializeIgnored(xe, nameof(m_resetCurrentMatchLocalTime));
            xs.WriteSerializeIgnored(xe, nameof(m_poseMatchingUtility));
        }
    }
}

