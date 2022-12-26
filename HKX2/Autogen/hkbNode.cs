using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbNode Signatire: 0x6d26f61d size: 72 flags: FLAGS_NONE

    // m_userData m_class:  Type.TYPE_ULONG Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    // m_id m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 64 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_cloneState m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 66 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_padNode m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 1 offset: 67 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 

    public class hkbNode : hkbBindable
    {

        public ulong m_userData;
        public string m_name;
        public short m_id;
        public sbyte m_cloneState;
        public List<bool> m_padNode;

        public override uint Signature => 0x6d26f61d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_userData = br.ReadUInt64();
            m_name = des.ReadStringPointer(br);
            m_id = br.ReadInt16();
            m_cloneState = br.ReadSByte();
            m_padNode = des.ReadBooleanCStyleArray(br, 1);//m_padNode = br.ReadBoolean();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt64(m_userData);
            s.WriteStringPointer(bw, m_name);
            bw.WriteInt16(m_id);
            s.WriteSByte(bw, m_cloneState);
            s.WriteBooleanCStyleArray(bw, m_padNode);//bw.WriteBoolean(m_padNode);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

