using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbBehaviorGraphData Signatire: 0x95aca5d size: 128 flags: FLAGS_NONE

    // m_attributeDefaults m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_variableInfos m_class: hkbVariableInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_characterPropertyInfos m_class: hkbVariableInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_eventInfos m_class: hkbEventInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_wordMinVariableValues m_class: hkbVariableValue Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_wordMaxVariableValues m_class: hkbVariableValue Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_variableInitialValues m_class: hkbVariableValueSet Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_stringData m_class: hkbBehaviorGraphStringData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 120 flags: FLAGS_NONE enum: 
    public partial class hkbBehaviorGraphData : hkReferencedObject
    {
        public List<float> m_attributeDefaults;
        public List<hkbVariableInfo> m_variableInfos = new List<hkbVariableInfo>();
        public List<hkbVariableInfo> m_characterPropertyInfos = new List<hkbVariableInfo>();
        public List<hkbEventInfo> m_eventInfos = new List<hkbEventInfo>();
        public List<hkbVariableValue> m_wordMinVariableValues = new List<hkbVariableValue>();
        public List<hkbVariableValue> m_wordMaxVariableValues = new List<hkbVariableValue>();
        public hkbVariableValueSet m_variableInitialValues;
        public hkbBehaviorGraphStringData m_stringData;

        public override uint Signature => 0x95aca5d;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_attributeDefaults = des.ReadSingleArray(br);
            m_variableInfos = des.ReadClassArray<hkbVariableInfo>(br);
            m_characterPropertyInfos = des.ReadClassArray<hkbVariableInfo>(br);
            m_eventInfos = des.ReadClassArray<hkbEventInfo>(br);
            m_wordMinVariableValues = des.ReadClassArray<hkbVariableValue>(br);
            m_wordMaxVariableValues = des.ReadClassArray<hkbVariableValue>(br);
            m_variableInitialValues = des.ReadClassPointer<hkbVariableValueSet>(br);
            m_stringData = des.ReadClassPointer<hkbBehaviorGraphStringData>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteSingleArray(bw, m_attributeDefaults);
            s.WriteClassArray<hkbVariableInfo>(bw, m_variableInfos);
            s.WriteClassArray<hkbVariableInfo>(bw, m_characterPropertyInfos);
            s.WriteClassArray<hkbEventInfo>(bw, m_eventInfos);
            s.WriteClassArray<hkbVariableValue>(bw, m_wordMinVariableValues);
            s.WriteClassArray<hkbVariableValue>(bw, m_wordMaxVariableValues);
            s.WriteClassPointer(bw, m_variableInitialValues);
            s.WriteClassPointer(bw, m_stringData);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_attributeDefaults = xd.ReadSingleArray(xe, nameof(m_attributeDefaults));
            m_variableInfos = xd.ReadClassArray<hkbVariableInfo>(xe, nameof(m_variableInfos));
            m_characterPropertyInfos = xd.ReadClassArray<hkbVariableInfo>(xe, nameof(m_characterPropertyInfos));
            m_eventInfos = xd.ReadClassArray<hkbEventInfo>(xe, nameof(m_eventInfos));
            m_wordMinVariableValues = xd.ReadClassArray<hkbVariableValue>(xe, nameof(m_wordMinVariableValues));
            m_wordMaxVariableValues = xd.ReadClassArray<hkbVariableValue>(xe, nameof(m_wordMaxVariableValues));
            m_variableInitialValues = xd.ReadClassPointer<hkbVariableValueSet>(xe, nameof(m_variableInitialValues));
            m_stringData = xd.ReadClassPointer<hkbBehaviorGraphStringData>(xe, nameof(m_stringData));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteFloatArray(xe, nameof(m_attributeDefaults), m_attributeDefaults);
            xs.WriteClassArray<hkbVariableInfo>(xe, nameof(m_variableInfos), m_variableInfos);
            xs.WriteClassArray<hkbVariableInfo>(xe, nameof(m_characterPropertyInfos), m_characterPropertyInfos);
            xs.WriteClassArray<hkbEventInfo>(xe, nameof(m_eventInfos), m_eventInfos);
            xs.WriteClassArray<hkbVariableValue>(xe, nameof(m_wordMinVariableValues), m_wordMinVariableValues);
            xs.WriteClassArray<hkbVariableValue>(xe, nameof(m_wordMaxVariableValues), m_wordMaxVariableValues);
            xs.WriteClassPointer(xe, nameof(m_variableInitialValues), m_variableInitialValues);
            xs.WriteClassPointer(xe, nameof(m_stringData), m_stringData);
        }
    }
}

