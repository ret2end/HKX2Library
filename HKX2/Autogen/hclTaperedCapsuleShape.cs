using System.Numerics;

namespace HKX2
{
    public class hclTaperedCapsuleShape : hclShape
    {
        public Vector4 m_big;
        public float m_bigRadius;
        public Vector4 m_coneApex;
        public Vector4 m_coneAxis;
        public float m_cosTheta;
        public float m_d;
        public Vector4 m_dVec;
        public float m_l;
        public Vector4 m_lVec;
        public float m_sinTheta;

        public Vector4 m_small;
        public float m_smallRadius;
        public float m_tanTheta;
        public float m_tanThetaSqr;
        public Vector4 m_tanThetaVecNeg;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_small = des.ReadVector4(br);
            m_big = des.ReadVector4(br);
            m_coneApex = des.ReadVector4(br);
            m_coneAxis = des.ReadVector4(br);
            m_lVec = des.ReadVector4(br);
            m_dVec = des.ReadVector4(br);
            m_tanThetaVecNeg = des.ReadVector4(br);
            m_smallRadius = br.ReadSingle();
            m_bigRadius = br.ReadSingle();
            m_l = br.ReadSingle();
            m_d = br.ReadSingle();
            m_cosTheta = br.ReadSingle();
            m_sinTheta = br.ReadSingle();
            m_tanTheta = br.ReadSingle();
            m_tanThetaSqr = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVector4(bw, m_small);
            s.WriteVector4(bw, m_big);
            s.WriteVector4(bw, m_coneApex);
            s.WriteVector4(bw, m_coneAxis);
            s.WriteVector4(bw, m_lVec);
            s.WriteVector4(bw, m_dVec);
            s.WriteVector4(bw, m_tanThetaVecNeg);
            bw.WriteSingle(m_smallRadius);
            bw.WriteSingle(m_bigRadius);
            bw.WriteSingle(m_l);
            bw.WriteSingle(m_d);
            bw.WriteSingle(m_cosTheta);
            bw.WriteSingle(m_sinTheta);
            bw.WriteSingle(m_tanTheta);
            bw.WriteSingle(m_tanThetaSqr);
        }
    }
}