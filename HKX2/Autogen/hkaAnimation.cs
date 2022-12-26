using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaAnimation Signatire: 0xa6fa7e88 size: 56 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_INT32 arrSize: 0 offset: 16 flags:  enum: AnimationType
    // m_duration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_numberOfTransformTracks m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_numberOfFloatTracks m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    // m_extractedMotion m_class: hkaAnimatedReferenceFrame Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    // m_annotationTracks m_class: hkaAnnotationTrack Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 40 flags:  enum: 
    
    public class hkaAnimation : hkReferencedObject
    {

        public int m_type;
        public float m_duration;
        public int m_numberOfTransformTracks;
        public int m_numberOfFloatTracks;
        public hkaAnimatedReferenceFrame /*pointer struct*/ m_extractedMotion;
        public List<hkaAnnotationTrack> m_annotationTracks;

        public override uint Signature => 0xa6fa7e88;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_type = br.ReadInt32();
            m_duration = br.ReadSingle();
            m_numberOfTransformTracks = br.ReadInt32();
            m_numberOfFloatTracks = br.ReadInt32();
            m_extractedMotion = des.ReadClassPointer<hkaAnimatedReferenceFrame>(br);
            m_annotationTracks = des.ReadClassArray<hkaAnnotationTrack>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteInt32(bw, m_type);
            bw.WriteSingle(m_duration);
            bw.WriteInt32(m_numberOfTransformTracks);
            bw.WriteInt32(m_numberOfFloatTracks);
            s.WriteClassPointer(bw, m_extractedMotion);
            s.WriteClassArray<hkaAnnotationTrack>(bw, m_annotationTracks);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

