using System.Collections.Generic;

namespace HKX2
{
    public class hkpSerializedDisplayRbTransforms : hkReferencedObject
    {
        public List<hkpSerializedDisplayRbTransformsDisplayTransformPair> m_transforms;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_transforms = des.ReadClassArray<hkpSerializedDisplayRbTransformsDisplayTransformPair>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_transforms);
        }
    }
}