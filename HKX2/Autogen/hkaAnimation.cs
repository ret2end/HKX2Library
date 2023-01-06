using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkaAnimation Signatire: 0xa6fa7e88 size: 56 flags: FLAGS_NONE

    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_INT32 arrSize: 0 offset: 16 flags: FLAGS_NONE enum: AnimationType
    // m_duration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags: FLAGS_NONE enum: 
    // m_numberOfTransformTracks m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_numberOfFloatTracks m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags: FLAGS_NONE enum: 
    // m_extractedMotion m_class: hkaAnimatedReferenceFrame Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_annotationTracks m_class: hkaAnnotationTrack Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    public partial class hkaAnimation : hkReferencedObject
    {
        public int m_type;
        public float m_duration;
        public int m_numberOfTransformTracks;
        public int m_numberOfFloatTracks;
        public hkaAnimatedReferenceFrame m_extractedMotion;
        public List<hkaAnnotationTrack> m_annotationTracks = new List<hkaAnnotationTrack>();

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
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_type = xd.ReadFlag<AnimationType, int>(xe, nameof(m_type));
            m_duration = xd.ReadSingle(xe, nameof(m_duration));
            m_numberOfTransformTracks = xd.ReadInt32(xe, nameof(m_numberOfTransformTracks));
            m_numberOfFloatTracks = xd.ReadInt32(xe, nameof(m_numberOfFloatTracks));
            m_extractedMotion = xd.ReadClassPointer<hkaAnimatedReferenceFrame>(xe, nameof(m_extractedMotion));
            m_annotationTracks = xd.ReadClassArray<hkaAnnotationTrack>(xe, nameof(m_annotationTracks));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteEnum<AnimationType, int>(xe, nameof(m_type), m_type);
            xs.WriteFloat(xe, nameof(m_duration), m_duration);
            xs.WriteNumber(xe, nameof(m_numberOfTransformTracks), m_numberOfTransformTracks);
            xs.WriteNumber(xe, nameof(m_numberOfFloatTracks), m_numberOfFloatTracks);
            xs.WriteClassPointer(xe, nameof(m_extractedMotion), m_extractedMotion);
            xs.WriteClassArray<hkaAnnotationTrack>(xe, nameof(m_annotationTracks), m_annotationTracks);
        }
    }
}

