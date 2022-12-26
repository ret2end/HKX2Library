using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpRagdollMotorConstraintAtom Signatire: 0x71013826 size: 96 flags: FLAGS_NONE

    // m_isEnabled m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_initializedOffset m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_previousTargetAnglesOffset m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 6 flags:  enum: 
    // m_target_bRca m_class:  Type.TYPE_MATRIX3 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_motors m_class: hkpConstraintMotor Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 3 offset: 64 flags:  enum: 
    
    public class hkpRagdollMotorConstraintAtom : hkpConstraintAtom
    {

        public bool m_isEnabled;
        public short m_initializedOffset;
        public short m_previousTargetAnglesOffset;
        public Matrix4x4 m_target_bRca;
        public List<hkpConstraintMotor /*pointer struct*/> m_motors;

        public override uint Signature => 0x71013826;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_isEnabled = br.ReadBoolean();
            br.Position += 1;
            m_initializedOffset = br.ReadInt16();
            m_previousTargetAnglesOffset = br.ReadInt16();
            br.Position += 8;
            m_target_bRca = des.ReadMatrix3(br);
            m_motors = des.ReadClassPointerCStyleArray<hkpConstraintMotor>(br, 3);
            //m_motors = des.ReadClassPointer<hkpConstraintMotor>(br);
            br.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteBoolean(m_isEnabled);
            bw.Position += 1;
            bw.WriteInt16(m_initializedOffset);
            bw.WriteInt16(m_previousTargetAnglesOffset);
            bw.Position += 8;
            s.WriteMatrix3(bw, m_target_bRca);
            s.WriteClassPointerCStyleArray(bw, m_motors); //s.WriteClassPointer(bw, m_motors);
            bw.Position += 8;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

