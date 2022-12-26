using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaAnimationContainer Signatire: 0x8dc20333 size: 96 flags: FLAGS_NONE

    // m_skeletons m_class: hkaSkeleton Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags:  enum: 
    // m_animations m_class: hkaAnimation Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags:  enum: 
    // m_bindings m_class: hkaAnimationBinding Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 48 flags:  enum: 
    // m_attachments m_class: hkaBoneAttachment Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 64 flags:  enum: 
    // m_skins m_class: hkaMeshBinding Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 80 flags:  enum: 
    
    public class hkaAnimationContainer : hkReferencedObject
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

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkaSkeleton>(bw, m_skeletons);
            s.WriteClassPointerArray<hkaAnimation>(bw, m_animations);
            s.WriteClassPointerArray<hkaAnimationBinding>(bw, m_bindings);
            s.WriteClassPointerArray<hkaBoneAttachment>(bw, m_attachments);
            s.WriteClassPointerArray<hkaMeshBinding>(bw, m_skins);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

