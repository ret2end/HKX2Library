using System.Collections.Generic;

namespace HKX2
{
    public class hclClothSetupObject : hkReferencedObject
    {
        public List<hclBufferSetupObject> m_bufferSetupObjects;
        public List<hclClothStateSetupObject> m_clothStateSetupObjects;

        public string m_name;
        public List<hclOperatorSetupObject> m_operatorSetupObjects;
        public List<hclSimClothSetupObject> m_simClothSetupObjects;
        public List<hclTransformSetSetupObject> m_transformSetSetupObjects;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_bufferSetupObjects = des.ReadClassPointerArray<hclBufferSetupObject>(br);
            m_transformSetSetupObjects = des.ReadClassPointerArray<hclTransformSetSetupObject>(br);
            m_simClothSetupObjects = des.ReadClassPointerArray<hclSimClothSetupObject>(br);
            m_operatorSetupObjects = des.ReadClassPointerArray<hclOperatorSetupObject>(br);
            m_clothStateSetupObjects = des.ReadClassPointerArray<hclClothStateSetupObject>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointerArray(bw, m_bufferSetupObjects);
            s.WriteClassPointerArray(bw, m_transformSetSetupObjects);
            s.WriteClassPointerArray(bw, m_simClothSetupObjects);
            s.WriteClassPointerArray(bw, m_operatorSetupObjects);
            s.WriteClassPointerArray(bw, m_clothStateSetupObjects);
        }
    }
}