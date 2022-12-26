using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaSkeletonMapper Signatire: 0x12df42a5 size: 144 flags: FLAGS_NONE

    // m_mapping m_class: hkaSkeletonMapperData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    
    public class hkaSkeletonMapper : hkReferencedObject
    {

        public hkaSkeletonMapperData/*struct void*/ m_mapping;

        public override uint Signature => 0x12df42a5;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_mapping = new hkaSkeletonMapperData();
            m_mapping.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_mapping.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

