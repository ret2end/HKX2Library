using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbProjectData Signatire: 0x13a39ba7 size: 48 flags: FLAGS_NONE

    // m_worldUpWS m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_stringData m_class: hkbProjectStringData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    // m_defaultEventMode m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 40 flags:  enum: EventMode
    
    public class hkbProjectData : hkReferencedObject
    {

        public Vector4 m_worldUpWS;
        public hkbProjectStringData /*pointer struct*/ m_stringData;
        public sbyte m_defaultEventMode;

        public override uint Signature => 0x13a39ba7;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_worldUpWS = br.ReadVector4();
            m_stringData = des.ReadClassPointer<hkbProjectStringData>(br);
            m_defaultEventMode = br.ReadSByte();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_worldUpWS);
            s.WriteClassPointer(bw, m_stringData);
            s.WriteSByte(bw, m_defaultEventMode);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

