using System.Collections.Generic;

namespace HKX2
{
    public class hkaAnimationContainer : hkReferencedObject
    {
        public List<hkaAnimation> m_animations;
        public List<hkaBoneAttachment> m_attachments;
        public List<hkaAnimationBinding> m_bindings;

        public List<hkaSkeleton> m_skeletons;
        public List<hkaMeshBinding> m_skins;
        public override uint Signature => 0x26859F4C;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_skeletons = des.ReadClassPointerArray<hkaSkeleton>(br);
            m_animations = des.ReadClassPointerArray<hkaAnimation>(br);
            m_bindings = des.ReadClassPointerArray<hkaAnimationBinding>(br);
            m_attachments = des.ReadClassPointerArray<hkaBoneAttachment>(br);
            m_skins = des.ReadClassPointerArray<hkaMeshBinding>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_skeletons);
            s.WriteClassPointerArray(bw, m_animations);
            s.WriteClassPointerArray(bw, m_bindings);
            s.WriteClassPointerArray(bw, m_attachments);
            s.WriteClassPointerArray(bw, m_skins);
        }
    }
}