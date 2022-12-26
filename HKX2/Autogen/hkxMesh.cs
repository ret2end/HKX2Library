using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxMesh Signatire: 0xf2edcc5f size: 48 flags: FLAGS_NONE

    // m_sections m_class: hkxMeshSection Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags:  enum: 
    // m_userChannelInfos m_class: hkxMeshUserChannelInfo Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkxMesh : hkReferencedObject
    {

        public List<hkxMeshSection> m_sections;
        public List<hkxMeshUserChannelInfo> m_userChannelInfos;

        public override uint Signature => 0xf2edcc5f;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_sections = des.ReadClassPointerArray<hkxMeshSection>(br);
            m_userChannelInfos = des.ReadClassPointerArray<hkxMeshUserChannelInfo>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkxMeshSection>(bw, m_sections);
            s.WriteClassPointerArray<hkxMeshUserChannelInfo>(bw, m_userChannelInfos);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

