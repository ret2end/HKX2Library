using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPoweredChainDataConstraintInfo Signatire: 0xf88aee25 size: 96 flags: FLAGS_NONE

    // m_pivotInA m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_pivotInB m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_aTc m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_bTc m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_motors m_class: hkpConstraintMotor Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 3 offset: 64 flags:  enum: 
    // m_switchBodies m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    
    public class hkpPoweredChainDataConstraintInfo : IHavokObject
    {

        public Vector4 m_pivotInA;
        public Vector4 m_pivotInB;
        public Quaternion m_aTc;
        public Quaternion m_bTc;
        public List<hkpConstraintMotor /*pointer struct*/> m_motors;
        public bool m_switchBodies;

        public uint Signature => 0xf88aee25;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_pivotInA = br.ReadVector4();
            m_pivotInB = br.ReadVector4();
            m_aTc = des.ReadQuaternion(br);
            m_bTc = des.ReadQuaternion(br);
            des.ReadClassPointerCStyleArray<hkpConstraintMotor>(br, 3); //m_motors = des.ReadClassPointer<hkpConstraintMotor>(br);
            m_switchBodies = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_pivotInA);
            bw.WriteVector4(m_pivotInB);
            s.WriteQuaternion(bw, m_aTc);
            s.WriteQuaternion(bw, m_bTc);
            s.WriteClassPointerCStyleArray(bw, m_motors); //s.WriteClassPointer(bw, m_motors);
            bw.WriteBoolean(m_switchBodies);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

