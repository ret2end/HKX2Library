using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbNodeInternalStateInfo Signatire: 0x7db9971d size: 120 flags: FLAGS_NONE

    // m_syncInfo m_class: hkbGeneratorSyncInfo Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_internalState m_class: hkReferencedObject Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // m_nodeId m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_hasActivateBeenCalled m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 114 flags: FLAGS_NONE enum: 
    public partial class hkbNodeInternalStateInfo : hkReferencedObject
    {
        public hkbGeneratorSyncInfo m_syncInfo { set; get; } = new();
        public string m_name { set; get; } = "";
        public hkReferencedObject? m_internalState { set; get; } = default;
        public short m_nodeId { set; get; } = default;
        public bool m_hasActivateBeenCalled { set; get; } = default;

        public override uint Signature => 0x7db9971d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_syncInfo.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_internalState = des.ReadClassPointer<hkReferencedObject>(br);
            m_nodeId = br.ReadInt16();
            m_hasActivateBeenCalled = br.ReadBoolean();
            br.Position += 5;
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
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_syncInfo = xd.ReadClass<hkbGeneratorSyncInfo>(xe, nameof(m_syncInfo));
            m_name = xd.ReadString(xe, nameof(m_name));
            m_internalState = xd.ReadClassPointer<hkReferencedObject>(xe, nameof(m_internalState));
            m_nodeId = xd.ReadInt16(xe, nameof(m_nodeId));
            m_hasActivateBeenCalled = xd.ReadBoolean(xe, nameof(m_hasActivateBeenCalled));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClass<hkbGeneratorSyncInfo>(xe, nameof(m_syncInfo), m_syncInfo);
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteClassPointer(xe, nameof(m_internalState), m_internalState);
            xs.WriteNumber(xe, nameof(m_nodeId), m_nodeId);
            xs.WriteBoolean(xe, nameof(m_hasActivateBeenCalled), m_hasActivateBeenCalled);
        }
    }
}

