using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkaAnimationContainer Signatire: 0x8dc20333 size: 96 flags: FLAGS_NONE

    // m_skeletons m_class: hkaSkeleton Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_animations m_class: hkaAnimation Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_bindings m_class: hkaAnimationBinding Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_attachments m_class: hkaBoneAttachment Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_skins m_class: hkaMeshBinding Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class hkaAnimationContainer : hkReferencedObject
    {
        public List<hkaSkeleton> m_skeletons;
        public List<hkaAnimation> m_animations;
        public List<hkaAnimationBinding> m_bindings;
        public List<hkaBoneAttachment> m_attachments;
        public List<hkaMeshBinding> m_skins;

        public override uint Signature => 0x8dc20333;

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
            s.WriteClassPointerArray<hkaSkeleton>(bw, m_skeletons);
            s.WriteClassPointerArray<hkaAnimation>(bw, m_animations);
            s.WriteClassPointerArray<hkaAnimationBinding>(bw, m_bindings);
            s.WriteClassPointerArray<hkaBoneAttachment>(bw, m_attachments);
            s.WriteClassPointerArray<hkaMeshBinding>(bw, m_skins);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkaSkeleton>(xe, nameof(m_skeletons), m_skeletons);
            xs.WriteClassPointerArray<hkaAnimation>(xe, nameof(m_animations), m_animations);
            xs.WriteClassPointerArray<hkaAnimationBinding>(xe, nameof(m_bindings), m_bindings);
            xs.WriteClassPointerArray<hkaBoneAttachment>(xe, nameof(m_attachments), m_attachments);
            xs.WriteClassPointerArray<hkaMeshBinding>(xe, nameof(m_skins), m_skins);
        }
    }
}

