using System.Numerics;

namespace HKX2
{
    public class hclStorageSetupMeshBone : IHavokObject
    {
        public Matrix4x4 m_boneFromSkin;

        public string m_name;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_name = des.ReadStringPointer(br);
            br.ReadUInt64();
            m_boneFromSkin = des.ReadMatrix4(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_name);
            bw.WriteUInt64(0);
            s.WriteMatrix4(bw, m_boneFromSkin);
        }
    }
}