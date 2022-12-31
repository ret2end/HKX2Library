using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // BSDirectAtModifier Signatire: 0x19a005c0 size: 224 flags: FLAGS_NONE

    // m_directAtTarget m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_sourceBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 82 flags: FLAGS_NONE enum: 
    // m_startBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 84 flags: FLAGS_NONE enum: 
    // m_endBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 86 flags: FLAGS_NONE enum: 
    // m_limitHeadingDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_limitPitchDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 92 flags: FLAGS_NONE enum: 
    // m_offsetHeadingDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_offsetPitchDegrees m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags: FLAGS_NONE enum: 
    // m_onGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // m_offGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 108 flags: FLAGS_NONE enum: 
    // m_targetLocation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_userInfo m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_directAtCamera m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 132 flags: FLAGS_NONE enum: 
    // m_directAtCameraX m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 136 flags: FLAGS_NONE enum: 
    // m_directAtCameraY m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 140 flags: FLAGS_NONE enum: 
    // m_directAtCameraZ m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_active m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 148 flags: FLAGS_NONE enum: 
    // m_currentHeadingOffset m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 152 flags: FLAGS_NONE enum: 
    // m_currentPitchOffset m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 156 flags: FLAGS_NONE enum: 
    // m_timeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 160 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_pSkeletonMemory m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 168 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_hasTarget m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 176 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_directAtTargetLocation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 192 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_boneChainIndices m_class:  Type.TYPE_ARRAY Type.TYPE_VOID arrSize: 0 offset: 208 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class BSDirectAtModifier : hkbModifier
    {
        public bool m_directAtTarget;
        public short m_sourceBoneIndex;
        public short m_startBoneIndex;
        public short m_endBoneIndex;
        public float m_limitHeadingDegrees;
        public float m_limitPitchDegrees;
        public float m_offsetHeadingDegrees;
        public float m_offsetPitchDegrees;
        public float m_onGain;
        public float m_offGain;
        public Vector4 m_targetLocation;
        public uint m_userInfo;
        public bool m_directAtCamera;
        public float m_directAtCameraX;
        public float m_directAtCameraY;
        public float m_directAtCameraZ;
        public bool m_active;
        public float m_currentHeadingOffset;
        public float m_currentPitchOffset;
        public float m_timeStep;
        public dynamic m_pSkeletonMemory;
        public bool m_hasTarget;
        public Vector4 m_directAtTargetLocation;
        public List<dynamic> m_boneChainIndices;

        public override uint Signature => 0x19a005c0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_directAtTarget = br.ReadBoolean();
            br.Position += 1;
            m_sourceBoneIndex = br.ReadInt16();
            m_startBoneIndex = br.ReadInt16();
            m_endBoneIndex = br.ReadInt16();
            m_limitHeadingDegrees = br.ReadSingle();
            m_limitPitchDegrees = br.ReadSingle();
            m_offsetHeadingDegrees = br.ReadSingle();
            m_offsetPitchDegrees = br.ReadSingle();
            m_onGain = br.ReadSingle();
            m_offGain = br.ReadSingle();
            m_targetLocation = br.ReadVector4();
            m_userInfo = br.ReadUInt32();
            m_directAtCamera = br.ReadBoolean();
            br.Position += 3;
            m_directAtCameraX = br.ReadSingle();
            m_directAtCameraY = br.ReadSingle();
            m_directAtCameraZ = br.ReadSingle();
            m_active = br.ReadBoolean();
            br.Position += 3;
            m_currentHeadingOffset = br.ReadSingle();
            m_currentPitchOffset = br.ReadSingle();
            m_timeStep = br.ReadSingle();
            br.Position += 4;
            des.ReadEmptyPointer(br);
            m_hasTarget = br.ReadBoolean();
            br.Position += 15;
            m_directAtTargetLocation = br.ReadVector4();
            des.ReadEmptyArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteBoolean(m_directAtTarget);
            bw.Position += 1;
            bw.WriteInt16(m_sourceBoneIndex);
            bw.WriteInt16(m_startBoneIndex);
            bw.WriteInt16(m_endBoneIndex);
            bw.WriteSingle(m_limitHeadingDegrees);
            bw.WriteSingle(m_limitPitchDegrees);
            bw.WriteSingle(m_offsetHeadingDegrees);
            bw.WriteSingle(m_offsetPitchDegrees);
            bw.WriteSingle(m_onGain);
            bw.WriteSingle(m_offGain);
            bw.WriteVector4(m_targetLocation);
            bw.WriteUInt32(m_userInfo);
            bw.WriteBoolean(m_directAtCamera);
            bw.Position += 3;
            bw.WriteSingle(m_directAtCameraX);
            bw.WriteSingle(m_directAtCameraY);
            bw.WriteSingle(m_directAtCameraZ);
            bw.WriteBoolean(m_active);
            bw.Position += 3;
            bw.WriteSingle(m_currentHeadingOffset);
            bw.WriteSingle(m_currentPitchOffset);
            bw.WriteSingle(m_timeStep);
            bw.Position += 4;
            s.WriteVoidPointer(bw);
            bw.WriteBoolean(m_hasTarget);
            bw.Position += 15;
            bw.WriteVector4(m_directAtTargetLocation);
            s.WriteVoidArray(bw);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteBoolean(xe, nameof(m_directAtTarget), m_directAtTarget);
            xs.WriteNumber(xe, nameof(m_sourceBoneIndex), m_sourceBoneIndex);
            xs.WriteNumber(xe, nameof(m_startBoneIndex), m_startBoneIndex);
            xs.WriteNumber(xe, nameof(m_endBoneIndex), m_endBoneIndex);
            xs.WriteFloat(xe, nameof(m_limitHeadingDegrees), m_limitHeadingDegrees);
            xs.WriteFloat(xe, nameof(m_limitPitchDegrees), m_limitPitchDegrees);
            xs.WriteFloat(xe, nameof(m_offsetHeadingDegrees), m_offsetHeadingDegrees);
            xs.WriteFloat(xe, nameof(m_offsetPitchDegrees), m_offsetPitchDegrees);
            xs.WriteFloat(xe, nameof(m_onGain), m_onGain);
            xs.WriteFloat(xe, nameof(m_offGain), m_offGain);
            xs.WriteVector4(xe, nameof(m_targetLocation), m_targetLocation);
            xs.WriteNumber(xe, nameof(m_userInfo), m_userInfo);
            xs.WriteBoolean(xe, nameof(m_directAtCamera), m_directAtCamera);
            xs.WriteFloat(xe, nameof(m_directAtCameraX), m_directAtCameraX);
            xs.WriteFloat(xe, nameof(m_directAtCameraY), m_directAtCameraY);
            xs.WriteFloat(xe, nameof(m_directAtCameraZ), m_directAtCameraZ);
            xs.WriteBoolean(xe, nameof(m_active), m_active);
            xs.WriteFloat(xe, nameof(m_currentHeadingOffset), m_currentHeadingOffset);
            xs.WriteFloat(xe, nameof(m_currentPitchOffset), m_currentPitchOffset);
            xs.WriteSerializeIgnored(xe, nameof(m_timeStep));
            xs.WriteSerializeIgnored(xe, nameof(m_pSkeletonMemory));
            xs.WriteSerializeIgnored(xe, nameof(m_hasTarget));
            xs.WriteSerializeIgnored(xe, nameof(m_directAtTargetLocation));
            xs.WriteSerializeIgnored(xe, nameof(m_boneChainIndices));
        }
    }
}

