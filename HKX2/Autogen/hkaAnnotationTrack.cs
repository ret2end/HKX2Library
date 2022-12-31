using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkaAnnotationTrack Signatire: 0xd4114fdd size: 24 flags: FLAGS_NONE

    // m_trackName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_annotations m_class: hkaAnnotationTrackAnnotation Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkaAnnotationTrack : IHavokObject
    {
        public string m_trackName;
        public List<hkaAnnotationTrackAnnotation> m_annotations;

        public virtual uint Signature => 0xd4114fdd;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_trackName = des.ReadStringPointer(br);
            m_annotations = des.ReadClassArray<hkaAnnotationTrackAnnotation>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_trackName);
            s.WriteClassArray<hkaAnnotationTrackAnnotation>(bw, m_annotations);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteString(xe, nameof(m_trackName), m_trackName);
            xs.WriteClassArray<hkaAnnotationTrackAnnotation>(xe, nameof(m_annotations), m_annotations);
        }
    }
}

