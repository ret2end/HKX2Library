using System.Collections.Generic;

namespace HKX2
{
    public class hkaAnnotationTrack : IHavokObject
    {
        public List<hkaAnnotationTrackAnnotation> m_annotations;

        public string m_trackName;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_trackName = des.ReadStringPointer(br);
            m_annotations = des.ReadClassArray<hkaAnnotationTrackAnnotation>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteStringPointer(bw, m_trackName);
            s.WriteClassArray(bw, m_annotations);
        }
    }
}