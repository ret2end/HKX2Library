using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpMoppCode Signatire: 0x924c2661 size: 64 flags: FLAGS_NONE

    // m_info m_class: hkpMoppCodeCodeInfo Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_data m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 32 flags:  enum: 
    // m_buildType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 48 flags:  enum: BuildType
    
    public class hkpMoppCode : hkReferencedObject
    {

        public hkpMoppCodeCodeInfo/*struct void*/ m_info;
        public List<byte> m_data;
        public sbyte m_buildType;

        public override uint Signature => 0x924c2661;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_info = new hkpMoppCodeCodeInfo();
            m_info.Read(des,br);
            m_data = des.ReadByteArray(br);
            m_buildType = br.ReadSByte();
            br.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_info.Write(s, bw);
            s.WriteByteArray(bw, m_data);
            s.WriteSByte(bw, m_buildType);
            bw.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

