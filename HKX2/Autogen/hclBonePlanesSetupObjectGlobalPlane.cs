using System.Numerics;

namespace HKX2
{
    public class hclBonePlanesSetupObjectGlobalPlane : IHavokObject
    {
        public hclVertexFloatInput m_allowedPenetration;
        public hclVertexSelectionInput m_particles;
        public Vector4 m_planeEquationBoneSpace;
        public hclVertexFloatInput m_stiffness;

        public string m_transformName;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transformName = des.ReadStringPointer(br);
            m_particles = new hclVertexSelectionInput();
            m_particles.Read(des, br);
            br.ReadUInt64();
            m_planeEquationBoneSpace = des.ReadVector4(br);
            m_allowedPenetration = new hclVertexFloatInput();
            m_allowedPenetration.Read(des, br);
            m_stiffness = new hclVertexFloatInput();
            m_stiffness.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_transformName);
            m_particles.Write(s, bw);
            bw.WriteUInt64(0);
            s.WriteVector4(bw, m_planeEquationBoneSpace);
            m_allowedPenetration.Write(s, bw);
            m_stiffness.Write(s, bw);
        }
    }
}