using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbNodeInternalStateInfo Signatire: 0x7db9971d size: 120 flags: FLAGS_NONE

    // m_syncInfo m_class: hkbGeneratorSyncInfo Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_internalState m_class: hkReferencedObject Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 104 flags:  enum: 
    // m_nodeId m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_hasActivateBeenCalled m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 114 flags:  enum: 
    
    public class hkbNodeInternalStateInfo : hkReferencedObject
    {

        public hkbGeneratorSyncInfo/*struct void*/ m_syncInfo;
        public string m_name;
        public hkReferencedObject /*pointer struct*/ m_internalState;
        public short m_nodeId;
        public bool m_hasActivateBeenCalled;

        public override uint Signature => 0x7db9971d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_syncInfo = new hkbGeneratorSyncInfo();
            m_syncInfo.Read(des,br);
            m_name = des.ReadStringPointer(br);
            m_internalState = des.ReadClassPointer<hkReferencedObject>(br);
            m_nodeId = br.ReadInt16();
            m_hasActivateBeenCalled = br.ReadBoolean();
            br.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_syncInfo.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_internalState);
            bw.WriteInt16(m_nodeId);
            bw.WriteBoolean(m_hasActivateBeenCalled);
            bw.Position += 5;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

