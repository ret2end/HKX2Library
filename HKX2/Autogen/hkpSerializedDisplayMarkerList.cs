using System.Collections.Generic;

namespace HKX2
{
    public class hkpSerializedDisplayMarkerList : hkReferencedObject
    {
        public List<hkpSerializedDisplayMarker> m_markers;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_markers = des.ReadClassPointerArray<hkpSerializedDisplayMarker>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_markers);
        }
    }
}