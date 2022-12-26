using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPointToPathConstraintData Signatire: 0x8e7cb5da size: 192 flags: FLAGS_NONE

    // m_atoms m_class: hkpBridgeAtoms Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_path m_class: hkpParametricCurve Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags:  enum: 
    // m_maxFrictionForce m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    // m_angularConstrainedDOF m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 60 flags:  enum: OrientationConstraintType
    // m_transform_OS_KS m_class:  Type.TYPE_TRANSFORM Type.TYPE_VOID arrSize: 2 offset: 64 flags:  enum: 

    public class hkpPointToPathConstraintData : hkpConstraintData
    {

        public hkpBridgeAtoms/*struct void*/ m_atoms;
        public hkpParametricCurve /*pointer struct*/ m_path;
        public float m_maxFrictionForce;
        public sbyte m_angularConstrainedDOF;
        public List<Matrix4x4> m_transform_OS_KS;

        public override uint Signature => 0x8e7cb5da;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des, br);
            m_path = des.ReadClassPointer<hkpParametricCurve>(br);
            m_maxFrictionForce = br.ReadSingle();
            m_angularConstrainedDOF = br.ReadSByte();
            br.Position += 3;
            m_transform_OS_KS = des.ReadTransformCStyleArray(br, 2); //m_transform_OS_KS = des.ReadTransform(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_atoms.Write(s, bw);
            s.WriteClassPointer(bw, m_path);
            bw.WriteSingle(m_maxFrictionForce);
            s.WriteSByte(bw, m_angularConstrainedDOF);
            bw.Position += 3;
            s.WriteTransformCStyleArray(bw, m_transform_OS_KS); //s.WriteTransform(bw, m_transform_OS_KS);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

