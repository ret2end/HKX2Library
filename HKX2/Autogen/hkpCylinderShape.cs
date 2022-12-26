using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpCylinderShape Signatire: 0x3e463c3a size: 112 flags: FLAGS_NONE

    // m_cylRadius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_cylBaseRadiusFactorForHeightFieldCollisions m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 44 flags:  enum: 
    // m_vertexA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_vertexB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_perpendicular1 m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_perpendicular2 m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    
    public class hkpCylinderShape : hkpConvexShape
    {

        public float m_cylRadius;
        public float m_cylBaseRadiusFactorForHeightFieldCollisions;
        public Vector4 m_vertexA;
        public Vector4 m_vertexB;
        public Vector4 m_perpendicular1;
        public Vector4 m_perpendicular2;

        public override uint Signature => 0x3e463c3a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_cylRadius = br.ReadSingle();
            m_cylBaseRadiusFactorForHeightFieldCollisions = br.ReadSingle();
            m_vertexA = br.ReadVector4();
            m_vertexB = br.ReadVector4();
            m_perpendicular1 = br.ReadVector4();
            m_perpendicular2 = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_cylRadius);
            bw.WriteSingle(m_cylBaseRadiusFactorForHeightFieldCollisions);
            bw.WriteVector4(m_vertexA);
            bw.WriteVector4(m_vertexB);
            bw.WriteVector4(m_perpendicular1);
            bw.WriteVector4(m_perpendicular2);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

