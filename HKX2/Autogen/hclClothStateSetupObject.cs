using System.Collections.Generic;

namespace HKX2
{
    public class hclClothStateSetupObject : hkReferencedObject
    {
        public string m_name;
        public List<hclOperatorSetupObject> m_operatorSetupObjects;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_operatorSetupObjects = des.ReadClassPointerArray<hclOperatorSetupObject>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointerArray(bw, m_operatorSetupObjects);
        }
    }
}