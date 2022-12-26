using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbSetNodePropertyCommand Signatire: 0xc5160b64 size: 48 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_nodeName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_propertyName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_propertyValue m_class: hkbVariableValue Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_padding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 44 flags:  enum: 
    
    public class hkbSetNodePropertyCommand : hkReferencedObject
    {

        public ulong m_characterId;
        public string m_nodeName;
        public string m_propertyName;
        public hkbVariableValue/*struct void*/ m_propertyValue;
        public int m_padding;

        public override uint Signature => 0xc5160b64;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_nodeName = des.ReadStringPointer(br);
            m_propertyName = des.ReadStringPointer(br);
            m_propertyValue = new hkbVariableValue();
            m_propertyValue.Read(des,br);
            m_padding = br.ReadInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            s.WriteStringPointer(bw, m_nodeName);
            s.WriteStringPointer(bw, m_propertyName);
            m_propertyValue.Write(s, bw);
            bw.WriteInt32(m_padding);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

