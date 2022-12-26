using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbComputeDirectionModifier Signatire: 0xdf358bd3 size: 144 flags: FLAGS_NONE

    // m_pointIn m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_pointOut m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_groundAngleOut m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_upAngleOut m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 116 flags:  enum: 
    // m_verticalOffset m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 120 flags:  enum: 
    // m_reverseGroundAngle m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 124 flags:  enum: 
    // m_reverseUpAngle m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 125 flags:  enum: 
    // m_projectPoint m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 126 flags:  enum: 
    // m_normalizePoint m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 127 flags:  enum: 
    // m_computeOnlyOnce m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_computedOutput m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 129 flags:  enum: 
    
    public class hkbComputeDirectionModifier : hkbModifier
    {

        public Vector4 m_pointIn;
        public Vector4 m_pointOut;
        public float m_groundAngleOut;
        public float m_upAngleOut;
        public float m_verticalOffset;
        public bool m_reverseGroundAngle;
        public bool m_reverseUpAngle;
        public bool m_projectPoint;
        public bool m_normalizePoint;
        public bool m_computeOnlyOnce;
        public bool m_computedOutput;

        public override uint Signature => 0xdf358bd3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_pointIn = br.ReadVector4();
            m_pointOut = br.ReadVector4();
            m_groundAngleOut = br.ReadSingle();
            m_upAngleOut = br.ReadSingle();
            m_verticalOffset = br.ReadSingle();
            m_reverseGroundAngle = br.ReadBoolean();
            m_reverseUpAngle = br.ReadBoolean();
            m_projectPoint = br.ReadBoolean();
            m_normalizePoint = br.ReadBoolean();
            m_computeOnlyOnce = br.ReadBoolean();
            m_computedOutput = br.ReadBoolean();
            br.Position += 14;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_pointIn);
            bw.WriteVector4(m_pointOut);
            bw.WriteSingle(m_groundAngleOut);
            bw.WriteSingle(m_upAngleOut);
            bw.WriteSingle(m_verticalOffset);
            bw.WriteBoolean(m_reverseGroundAngle);
            bw.WriteBoolean(m_reverseUpAngle);
            bw.WriteBoolean(m_projectPoint);
            bw.WriteBoolean(m_normalizePoint);
            bw.WriteBoolean(m_computeOnlyOnce);
            bw.WriteBoolean(m_computedOutput);
            bw.Position += 14;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

