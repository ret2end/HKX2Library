using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbHandIkControlsModifierHand Signatire: 0x9c72e9e3 size: 112 flags: FLAGS_NONE

    // m_controlData m_class: hkbHandIkControlData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_handIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_enable m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 100 flags:  enum: 
    
    public class hkbHandIkControlsModifierHand : IHavokObject
    {

        public hkbHandIkControlData/*struct void*/ m_controlData;
        public int m_handIndex;
        public bool m_enable;

        public uint Signature => 0x9c72e9e3;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_controlData = new hkbHandIkControlData();
            m_controlData.Read(des,br);
            m_handIndex = br.ReadInt32();
            m_enable = br.ReadBoolean();
            br.Position += 11;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            m_controlData.Write(s, bw);
            bw.WriteInt32(m_handIndex);
            bw.WriteBoolean(m_enable);
            bw.Position += 11;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

