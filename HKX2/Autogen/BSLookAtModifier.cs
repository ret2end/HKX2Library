using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // BSLookAtModifier Signatire: 0xd756fc25 size: 224 flags: FLAGS_NONE

    // m_lookAtTarget m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_bones m_class: BSLookAtModifierBoneData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_eyeBones m_class: BSLookAtModifierBoneData Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // m_limitAngleDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 120 flags: FLAGS_NONE enum: 
    // m_limitAngleThresholdDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 124 flags: FLAGS_NONE enum: 
    // m_continueLookOutsideOfLimit m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_onGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 132 flags: FLAGS_NONE enum: 
    // m_offGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 136 flags: FLAGS_NONE enum: 
    // m_useBoneGains m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 140 flags: FLAGS_NONE enum: 
    // m_targetLocation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_targetOutsideLimits m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 160 flags: FLAGS_NONE enum: 
    // m_targetOutOfLimitEvent m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 168 flags: FLAGS_NONE enum: 
    // m_lookAtCamera m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 184 flags: FLAGS_NONE enum: 
    // m_lookAtCameraX m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 188 flags: FLAGS_NONE enum: 
    // m_lookAtCameraY m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 192 flags: FLAGS_NONE enum: 
    // m_lookAtCameraZ m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 196 flags: FLAGS_NONE enum: 
    // m_timeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 200 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_ballBonesValid m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 204 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_pSkeletonMemory m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 208 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class BSLookAtModifier : hkbModifier
    {
        public bool m_lookAtTarget;
        public List<BSLookAtModifierBoneData> m_bones = new List<BSLookAtModifierBoneData>();
        public List<BSLookAtModifierBoneData> m_eyeBones = new List<BSLookAtModifierBoneData>();
        public float m_limitAngleDegrees;
        public float m_limitAngleThresholdDegrees;
        public bool m_continueLookOutsideOfLimit;
        public float m_onGain;
        public float m_offGain;
        public bool m_useBoneGains;
        public Vector4 m_targetLocation;
        public bool m_targetOutsideLimits;
        public hkbEventProperty m_targetOutOfLimitEvent = new hkbEventProperty();
        public bool m_lookAtCamera;
        public float m_lookAtCameraX;
        public float m_lookAtCameraY;
        public float m_lookAtCameraZ;
        public float m_timeStep;
        public bool m_ballBonesValid;
        public dynamic m_pSkeletonMemory;

        public override uint Signature => 0xd756fc25;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_lookAtTarget = br.ReadBoolean();
            br.Position += 7;
            m_bones = des.ReadClassArray<BSLookAtModifierBoneData>(br);
            m_eyeBones = des.ReadClassArray<BSLookAtModifierBoneData>(br);
            m_limitAngleDegrees = br.ReadSingle();
            m_limitAngleThresholdDegrees = br.ReadSingle();
            m_continueLookOutsideOfLimit = br.ReadBoolean();
            br.Position += 3;
            m_onGain = br.ReadSingle();
            m_offGain = br.ReadSingle();
            m_useBoneGains = br.ReadBoolean();
            br.Position += 3;
            m_targetLocation = br.ReadVector4();
            m_targetOutsideLimits = br.ReadBoolean();
            br.Position += 7;
            m_targetOutOfLimitEvent = new hkbEventProperty();
            m_targetOutOfLimitEvent.Read(des, br);
            m_lookAtCamera = br.ReadBoolean();
            br.Position += 3;
            m_lookAtCameraX = br.ReadSingle();
            m_lookAtCameraY = br.ReadSingle();
            m_lookAtCameraZ = br.ReadSingle();
            m_timeStep = br.ReadSingle();
            m_ballBonesValid = br.ReadBoolean();
            br.Position += 3;
            des.ReadEmptyPointer(br);
            br.Position += 8;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteBoolean(m_lookAtTarget);
            bw.Position += 7;
            s.WriteClassArray<BSLookAtModifierBoneData>(bw, m_bones);
            s.WriteClassArray<BSLookAtModifierBoneData>(bw, m_eyeBones);
            bw.WriteSingle(m_limitAngleDegrees);
            bw.WriteSingle(m_limitAngleThresholdDegrees);
            bw.WriteBoolean(m_continueLookOutsideOfLimit);
            bw.Position += 3;
            bw.WriteSingle(m_onGain);
            bw.WriteSingle(m_offGain);
            bw.WriteBoolean(m_useBoneGains);
            bw.Position += 3;
            bw.WriteVector4(m_targetLocation);
            bw.WriteBoolean(m_targetOutsideLimits);
            bw.Position += 7;
            m_targetOutOfLimitEvent.Write(s, bw);
            bw.WriteBoolean(m_lookAtCamera);
            bw.Position += 3;
            bw.WriteSingle(m_lookAtCameraX);
            bw.WriteSingle(m_lookAtCameraY);
            bw.WriteSingle(m_lookAtCameraZ);
            bw.WriteSingle(m_timeStep);
            bw.WriteBoolean(m_ballBonesValid);
            bw.Position += 3;
            s.WriteVoidPointer(bw);
            bw.Position += 8;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_lookAtTarget = xd.ReadBoolean(xe, nameof(m_lookAtTarget));
            m_bones = xd.ReadClassArray<BSLookAtModifierBoneData>(xe, nameof(m_bones));
            m_eyeBones = xd.ReadClassArray<BSLookAtModifierBoneData>(xe, nameof(m_eyeBones));
            m_limitAngleDegrees = xd.ReadSingle(xe, nameof(m_limitAngleDegrees));
            m_limitAngleThresholdDegrees = xd.ReadSingle(xe, nameof(m_limitAngleThresholdDegrees));
            m_continueLookOutsideOfLimit = xd.ReadBoolean(xe, nameof(m_continueLookOutsideOfLimit));
            m_onGain = xd.ReadSingle(xe, nameof(m_onGain));
            m_offGain = xd.ReadSingle(xe, nameof(m_offGain));
            m_useBoneGains = xd.ReadBoolean(xe, nameof(m_useBoneGains));
            m_targetLocation = xd.ReadVector4(xe, nameof(m_targetLocation));
            m_targetOutsideLimits = xd.ReadBoolean(xe, nameof(m_targetOutsideLimits));
            m_targetOutOfLimitEvent = xd.ReadClass<hkbEventProperty>(xe, nameof(m_targetOutOfLimitEvent));
            m_lookAtCamera = xd.ReadBoolean(xe, nameof(m_lookAtCamera));
            m_lookAtCameraX = xd.ReadSingle(xe, nameof(m_lookAtCameraX));
            m_lookAtCameraY = xd.ReadSingle(xe, nameof(m_lookAtCameraY));
            m_lookAtCameraZ = xd.ReadSingle(xe, nameof(m_lookAtCameraZ));
            m_timeStep = default;
            m_ballBonesValid = default;
            m_pSkeletonMemory = default;
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteBoolean(xe, nameof(m_lookAtTarget), m_lookAtTarget);
            xs.WriteClassArray<BSLookAtModifierBoneData>(xe, nameof(m_bones), m_bones);
            xs.WriteClassArray<BSLookAtModifierBoneData>(xe, nameof(m_eyeBones), m_eyeBones);
            xs.WriteFloat(xe, nameof(m_limitAngleDegrees), m_limitAngleDegrees);
            xs.WriteFloat(xe, nameof(m_limitAngleThresholdDegrees), m_limitAngleThresholdDegrees);
            xs.WriteBoolean(xe, nameof(m_continueLookOutsideOfLimit), m_continueLookOutsideOfLimit);
            xs.WriteFloat(xe, nameof(m_onGain), m_onGain);
            xs.WriteFloat(xe, nameof(m_offGain), m_offGain);
            xs.WriteBoolean(xe, nameof(m_useBoneGains), m_useBoneGains);
            xs.WriteVector4(xe, nameof(m_targetLocation), m_targetLocation);
            xs.WriteBoolean(xe, nameof(m_targetOutsideLimits), m_targetOutsideLimits);
            xs.WriteClass<hkbEventProperty>(xe, nameof(m_targetOutOfLimitEvent), m_targetOutOfLimitEvent);
            xs.WriteBoolean(xe, nameof(m_lookAtCamera), m_lookAtCamera);
            xs.WriteFloat(xe, nameof(m_lookAtCameraX), m_lookAtCameraX);
            xs.WriteFloat(xe, nameof(m_lookAtCameraY), m_lookAtCameraY);
            xs.WriteFloat(xe, nameof(m_lookAtCameraZ), m_lookAtCameraZ);
            xs.WriteSerializeIgnored(xe, nameof(m_timeStep));
            xs.WriteSerializeIgnored(xe, nameof(m_ballBonesValid));
            xs.WriteSerializeIgnored(xe, nameof(m_pSkeletonMemory));
        }
    }
}

