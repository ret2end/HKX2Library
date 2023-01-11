using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbBehaviorGraphInternalState Signatire: 0x8699b6eb size: 40 flags: FLAGS_NONE

    // m_nodeInternalStateInfos m_class: hkbNodeInternalStateInfo Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_variableValueSet m_class: hkbVariableValueSet Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    public partial class hkbBehaviorGraphInternalState : hkReferencedObject
    {
        public IList<hkbNodeInternalStateInfo> m_nodeInternalStateInfos { set; get; } = new List<hkbNodeInternalStateInfo>();
        public hkbVariableValueSet? m_variableValueSet { set; get; } = default;

        public override uint Signature => 0x8699b6eb;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_nodeInternalStateInfos = des.ReadClassPointerArray<hkbNodeInternalStateInfo>(br);
            m_variableValueSet = des.ReadClassPointer<hkbVariableValueSet>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_nodeInternalStateInfos);
            s.WriteClassPointer(bw, m_variableValueSet);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_nodeInternalStateInfos = xd.ReadClassPointerArray<hkbNodeInternalStateInfo>(xe, nameof(m_nodeInternalStateInfos));
            m_variableValueSet = xd.ReadClassPointer<hkbVariableValueSet>(xe, nameof(m_variableValueSet));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkbNodeInternalStateInfo>(xe, nameof(m_nodeInternalStateInfos), m_nodeInternalStateInfos);
            xs.WriteClassPointer(xe, nameof(m_variableValueSet), m_variableValueSet);
        }
    }
}

