using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSampledHeightFieldShape Signatire: 0x11213421 size: 112 flags: FLAGS_NONE

    // m_xRes m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_zRes m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_heightCenter m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_useProjectionBasedHeight m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 44 flags:  enum: 
    // m_heightfieldType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 45 flags:  enum: HeightFieldType
    // m_intToFloatScale m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_floatToIntScale m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_floatToIntOffsetFloorCorrected m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_extents m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    
    public class hkpSampledHeightFieldShape : hkpHeightFieldShape
    {

        public int m_xRes;
        public int m_zRes;
        public float m_heightCenter;
        public bool m_useProjectionBasedHeight;
        public byte m_heightfieldType;
        public Vector4 m_intToFloatScale;
        public Vector4 m_floatToIntScale;
        public Vector4 m_floatToIntOffsetFloorCorrected;
        public Vector4 m_extents;

        public override uint Signature => 0x11213421;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_xRes = br.ReadInt32();
            m_zRes = br.ReadInt32();
            m_heightCenter = br.ReadSingle();
            m_useProjectionBasedHeight = br.ReadBoolean();
            m_heightfieldType = br.ReadByte();
            br.Position += 2;
            m_intToFloatScale = br.ReadVector4();
            m_floatToIntScale = br.ReadVector4();
            m_floatToIntOffsetFloorCorrected = br.ReadVector4();
            m_extents = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteInt32(m_xRes);
            bw.WriteInt32(m_zRes);
            bw.WriteSingle(m_heightCenter);
            bw.WriteBoolean(m_useProjectionBasedHeight);
            s.WriteByte(bw, m_heightfieldType);
            bw.Position += 2;
            bw.WriteVector4(m_intToFloatScale);
            bw.WriteVector4(m_floatToIntScale);
            bw.WriteVector4(m_floatToIntOffsetFloorCorrected);
            bw.WriteVector4(m_extents);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

