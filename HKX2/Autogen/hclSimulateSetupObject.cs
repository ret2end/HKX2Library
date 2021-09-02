using System.Collections.Generic;

namespace HKX2
{
    public class hclSimulateSetupObject : hclOperatorSetupObject
    {
        public bool m_adaptConstraintStiffness;
        public List<hclConstraintSetSetupObject> m_constraintSetExecutionOrder;
        public bool m_explicitConstraintOrder;

        public string m_name;
        public uint m_numberOfSolveIterations;
        public uint m_numberOfSubsteps;
        public hclSimClothSetupObject m_simClothSetupObject;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_simClothSetupObject = des.ReadClassPointer<hclSimClothSetupObject>(br);
            m_numberOfSubsteps = br.ReadUInt32();
            m_numberOfSolveIterations = br.ReadUInt32();
            m_adaptConstraintStiffness = br.ReadBoolean();
            m_explicitConstraintOrder = br.ReadBoolean();
            br.ReadUInt32();
            br.ReadUInt16();
            m_constraintSetExecutionOrder = des.ReadClassPointerArray<hclConstraintSetSetupObject>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_simClothSetupObject);
            bw.WriteUInt32(m_numberOfSubsteps);
            bw.WriteUInt32(m_numberOfSolveIterations);
            bw.WriteBoolean(m_adaptConstraintStiffness);
            bw.WriteBoolean(m_explicitConstraintOrder);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            s.WriteClassPointerArray(bw, m_constraintSetExecutionOrder);
        }
    }
}