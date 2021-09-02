using System.Numerics;

namespace HKX2
{
    public class hkaBoneAttachment : hkReferencedObject
    {
        public hkReferencedObject m_attachment;
        public Matrix4x4 m_boneFromAttachment;
        public short m_boneIndex;
        public string m_name;

        public string m_originalSkeletonName;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_originalSkeletonName = des.ReadStringPointer(br);
            br.Pad(16);
            m_boneFromAttachment = des.ReadMatrix4(br);
            m_attachment = des.ReadClassPointer<hkReferencedObject>(br);
            m_name = des.ReadStringPointer(br);
            m_boneIndex = br.ReadInt16();
            br.ReadUInt16();

            if (des._header.PointerSize == 8)
            {
                br.ReadUInt32();
                br.ReadUInt64();
            }
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_originalSkeletonName);
            bw.Pad(16);
            s.WriteMatrix4(bw, m_boneFromAttachment);
            s.WriteClassPointer(bw, m_attachment);
            s.WriteStringPointer(bw, m_name);
            bw.WriteInt16(m_boneIndex);
            bw.WriteUInt16(0);

            if (s._header.PointerSize == 8)
            {
                bw.WriteUInt32(0);
                bw.WriteUInt64(0);
            }
        }
    }
}