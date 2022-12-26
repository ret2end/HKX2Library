using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpSerializedDisplayMarkerList Signatire: 0x54785c77 size: 32 flags: FLAGS_NONE

    // m_markers m_class: hkpSerializedDisplayMarker Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkpSerializedDisplayMarkerList : hkReferencedObject
    {

        public List<hkpSerializedDisplayMarker> m_markers;

        public override uint Signature => 0x54785c77;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_markers = des.ReadClassPointerArray<hkpSerializedDisplayMarker>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkpSerializedDisplayMarker>(bw, m_markers);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

