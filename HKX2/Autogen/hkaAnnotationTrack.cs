using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaAnnotationTrack Signatire: 0xd4114fdd size: 24 flags: FLAGS_NONE

    // m_trackName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_annotations m_class: hkaAnnotationTrackAnnotation Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 8 flags:  enum: 
    
    public class hkaAnnotationTrack : IHavokObject
    {

        public string m_trackName;
        public List<hkaAnnotationTrackAnnotation> m_annotations;

        public uint Signature => 0xd4114fdd;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_trackName = des.ReadStringPointer(br);
            m_annotations = des.ReadClassArray<hkaAnnotationTrackAnnotation>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStringPointer(bw, m_trackName);
            s.WriteClassArray<hkaAnnotationTrackAnnotation>(bw, m_annotations);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

