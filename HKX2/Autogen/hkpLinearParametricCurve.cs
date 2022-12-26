using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpLinearParametricCurve Signatire: 0xd7b3be03 size: 80 flags: FLAGS_NONE

    // m_smoothingFactor m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_closedLoop m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_dirNotParallelToTangentAlongWholePath m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_points m_class:  Type.TYPE_ARRAY Type.TYPE_VECTOR4 arrSize: 0 offset: 48 flags:  enum: 
    // m_distance m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkpLinearParametricCurve : hkpParametricCurve
    {

        public float m_smoothingFactor;
        public bool m_closedLoop;
        public Vector4 m_dirNotParallelToTangentAlongWholePath;
        public List<Vector4> m_points;
        public List<float> m_distance;

        public override uint Signature => 0xd7b3be03;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_smoothingFactor = br.ReadSingle();
            m_closedLoop = br.ReadBoolean();
            br.Position += 11;
            m_dirNotParallelToTangentAlongWholePath = br.ReadVector4();
            m_points = des.ReadVector4Array(br);
            m_distance = des.ReadSingleArray(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_smoothingFactor);
            bw.WriteBoolean(m_closedLoop);
            bw.Position += 11;
            bw.WriteVector4(m_dirNotParallelToTangentAlongWholePath);
            s.WriteVector4Array(bw, m_points);
            s.WriteSingleArray(bw, m_distance);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

