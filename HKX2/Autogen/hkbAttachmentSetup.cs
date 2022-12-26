using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbAttachmentSetup Signatire: 0x774632b size: 48 flags: FLAGS_NONE

    // m_blendInTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_moveAttacherFraction m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_gain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_extrapolationTimeStep m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    // m_fixUpGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_maxLinearDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_maxAngularDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_attachmentType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 44 flags:  enum: AttachmentType
    
    public class hkbAttachmentSetup : hkReferencedObject
    {

        public float m_blendInTime;
        public float m_moveAttacherFraction;
        public float m_gain;
        public float m_extrapolationTimeStep;
        public float m_fixUpGain;
        public float m_maxLinearDistance;
        public float m_maxAngularDistance;
        public sbyte m_attachmentType;

        public override uint Signature => 0x774632b;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_blendInTime = br.ReadSingle();
            m_moveAttacherFraction = br.ReadSingle();
            m_gain = br.ReadSingle();
            m_extrapolationTimeStep = br.ReadSingle();
            m_fixUpGain = br.ReadSingle();
            m_maxLinearDistance = br.ReadSingle();
            m_maxAngularDistance = br.ReadSingle();
            m_attachmentType = br.ReadSByte();
            br.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteSingle(m_blendInTime);
            bw.WriteSingle(m_moveAttacherFraction);
            bw.WriteSingle(m_gain);
            bw.WriteSingle(m_extrapolationTimeStep);
            bw.WriteSingle(m_fixUpGain);
            bw.WriteSingle(m_maxLinearDistance);
            bw.WriteSingle(m_maxAngularDistance);
            s.WriteSByte(bw, m_attachmentType);
            bw.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

