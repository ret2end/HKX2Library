using System.Collections.Generic;

namespace HKX2
{
    public class hclBonePlanesSetupObject : hclConstraintSetSetupObject
    {
        public bool m_angleSpecifiedInDegrees;
        public List<hclBonePlanesSetupObjectGlobalPlane> m_globalPlanes;

        public string m_name;
        public List<hclBonePlanesSetupObjectPerParticleAngle> m_perParticleAngle;
        public List<hclBonePlanesSetupObjectPerParticlePlane> m_perParticlePlanes;
        public hclSimulationSetupMesh m_simulationMesh;
        public hclTransformSetSetupObject m_transformSetSetup;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_simulationMesh = des.ReadClassPointer<hclSimulationSetupMesh>(br);
            m_transformSetSetup = des.ReadClassPointer<hclTransformSetSetupObject>(br);
            m_perParticlePlanes = des.ReadClassArray<hclBonePlanesSetupObjectPerParticlePlane>(br);
            m_globalPlanes = des.ReadClassArray<hclBonePlanesSetupObjectGlobalPlane>(br);
            m_perParticleAngle = des.ReadClassArray<hclBonePlanesSetupObjectPerParticleAngle>(br);
            m_angleSpecifiedInDegrees = br.ReadBoolean();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_simulationMesh);
            s.WriteClassPointer(bw, m_transformSetSetup);
            s.WriteClassArray(bw, m_perParticlePlanes);
            s.WriteClassArray(bw, m_globalPlanes);
            s.WriteClassArray(bw, m_perParticleAngle);
            bw.WriteBoolean(m_angleSpecifiedInDegrees);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}