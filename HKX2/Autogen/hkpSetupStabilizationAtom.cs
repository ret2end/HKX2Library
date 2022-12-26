using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSetupStabilizationAtom Signatire: 0xf05d137e size: 16 flags: FLAGS_NONE

    // m_enabled m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 2 flags:  enum: 
    // m_maxAngle m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags:  enum: 
    // m_padding m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 8 offset: 8 flags:  enum: 
    
    public class hkpSetupStabilizationAtom : hkpConstraintAtom
    {

        public bool m_enabled;
        public float m_maxAngle;
        public List<byte> m_padding;

        public override uint Signature => 0xf05d137e;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_enabled = br.ReadBoolean();
            br.Position += 1;
            m_maxAngle = br.ReadSingle();
            m_padding = des.ReadByteCStyleArray(br, 8); //m_padding = br.ReadByte();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteBoolean(m_enabled);
            bw.Position += 1;
            bw.WriteSingle(m_maxAngle);
            s.WriteByteCStyleArray(bw, m_padding); //bw.WriteByte(m_padding);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

