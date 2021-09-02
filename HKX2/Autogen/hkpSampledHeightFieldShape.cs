using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public enum HeightFieldType
    {
        HEIGHTFIELD_STORAGE = 0,
        HEIGHTFIELD_COMPRESSED = 1,
        HEIGHTFIELD_USER = 2,
        HEIGHTFIELD_MAX_ID = 3
    }

    public class hkpSampledHeightFieldShape : hkpHeightFieldShape
    {
        public int m_coarseness;

        public List<hkpSampledHeightFieldShapeCoarseMinMaxLevel> m_coarseTreeData;
        public Vector4 m_extents;
        public Vector4 m_floatToIntOffsetFloorCorrected;
        public Vector4 m_floatToIntScale;
        public float m_heightCenter;
        public HeightFieldType m_heightfieldType;
        public Vector4 m_intToFloatScale;
        public float m_raycastMaxY;
        public float m_raycastMinY;
        public bool m_useProjectionBasedHeight;
        public int m_xRes;
        public int m_zRes;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_coarseTreeData = des.ReadClassArray<hkpSampledHeightFieldShapeCoarseMinMaxLevel>(br);
            m_coarseness = br.ReadInt32();
            m_raycastMinY = br.ReadSingle();
            m_raycastMaxY = br.ReadSingle();
            m_xRes = br.ReadInt32();
            m_zRes = br.ReadInt32();
            m_heightCenter = br.ReadSingle();
            m_useProjectionBasedHeight = br.ReadBoolean();
            m_heightfieldType = (HeightFieldType) br.ReadByte();
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadUInt16();
            m_intToFloatScale = des.ReadVector4(br);
            m_floatToIntScale = des.ReadVector4(br);
            m_floatToIntOffsetFloorCorrected = des.ReadVector4(br);
            m_extents = des.ReadVector4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_coarseTreeData);
            bw.WriteInt32(m_coarseness);
            bw.WriteSingle(m_raycastMinY);
            bw.WriteSingle(m_raycastMaxY);
            bw.WriteInt32(m_xRes);
            bw.WriteInt32(m_zRes);
            bw.WriteSingle(m_heightCenter);
            bw.WriteBoolean(m_useProjectionBasedHeight);
            bw.WriteByte((byte) m_heightfieldType);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            s.WriteVector4(bw, m_intToFloatScale);
            s.WriteVector4(bw, m_floatToIntScale);
            s.WriteVector4(bw, m_floatToIntOffsetFloorCorrected);
            s.WriteVector4(bw, m_extents);
        }
    }
}