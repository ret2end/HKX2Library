using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBehaviorInfoIdToNamePair Signatire: 0x35a0439a size: 24 flags: FLAGS_NONE

    // m_behaviorName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_nodeName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_toolType m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 16 flags:  enum: ToolNodeType
    // m_id m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 18 flags:  enum: 
    
    public class hkbBehaviorInfoIdToNamePair : IHavokObject
    {

        public string m_behaviorName;
        public string m_nodeName;
        public byte m_toolType;
        public short m_id;

        public uint Signature => 0x35a0439a;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_behaviorName = des.ReadStringPointer(br);
            m_nodeName = des.ReadStringPointer(br);
            m_toolType = br.ReadByte();
            br.Position += 1;
            m_id = br.ReadInt16();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_behaviorName);
            s.WriteStringPointer(bw, m_nodeName);
            s.WriteByte(bw, m_toolType);
            bw.Position += 1;
            bw.WriteInt16(m_id);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

