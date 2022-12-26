using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBehaviorGraphData Signatire: 0x95aca5d size: 128 flags: FLAGS_NONE

    // m_attributeDefaults m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 16 flags:  enum: 
    // m_variableInfos m_class: hkbVariableInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    // m_characterPropertyInfos m_class: hkbVariableInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 48 flags:  enum: 
    // m_eventInfos m_class: hkbEventInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 64 flags:  enum: 
    // m_wordMinVariableValues m_class: hkbVariableValue Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 80 flags:  enum: 
    // m_wordMaxVariableValues m_class: hkbVariableValue Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 96 flags:  enum: 
    // m_variableInitialValues m_class: hkbVariableValueSet Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 112 flags:  enum: 
    // m_stringData m_class: hkbBehaviorGraphStringData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 120 flags:  enum: 
    
    public class hkbBehaviorGraphData : hkReferencedObject
    {

        public List<float> m_attributeDefaults;
        public List<hkbVariableInfo> m_variableInfos;
        public List<hkbVariableInfo> m_characterPropertyInfos;
        public List<hkbEventInfo> m_eventInfos;
        public List<hkbVariableValue> m_wordMinVariableValues;
        public List<hkbVariableValue> m_wordMaxVariableValues;
        public hkbVariableValueSet /*pointer struct*/ m_variableInitialValues;
        public hkbBehaviorGraphStringData /*pointer struct*/ m_stringData;

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

            // throw new NotImplementedException("code generated. check first");
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

            // throw new NotImplementedException("code generated. check first");
        }
    }
}
