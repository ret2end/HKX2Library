using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbComputeDirectionModifierInternalState Signatire: 0x6ac054d7 size: 48 flags: FLAGS_NONE

    // m_pointOut m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_groundAngleOut m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_upAngleOut m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_computedOutput m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    
    public class hkbComputeDirectionModifierInternalState : hkReferencedObject
    {

        public Vector4 m_pointOut;
        public float m_groundAngleOut;
        public float m_upAngleOut;
        public bool m_computedOutput;

        public override uint Signature => 0x6ac054d7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_pointOut = br.ReadVector4();
            m_groundAngleOut = br.ReadSingle();
            m_upAngleOut = br.ReadSingle();
            m_computedOutput = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_pointOut);
            bw.WriteSingle(m_groundAngleOut);
            bw.WriteSingle(m_upAngleOut);
            bw.WriteBoolean(m_computedOutput);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

