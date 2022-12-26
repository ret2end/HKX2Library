using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPlaneShape Signatire: 0xc36bbd30 size: 80 flags: FLAGS_NONE

    // m_plane m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_aabbCenter m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_aabbHalfExtents m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkpPlaneShape : hkpHeightFieldShape
    {

        public Vector4 m_plane;
        public Vector4 m_aabbCenter;
        public Vector4 m_aabbHalfExtents;

        public override uint Signature => 0xc36bbd30;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_plane = br.ReadVector4();
            m_aabbCenter = br.ReadVector4();
            m_aabbHalfExtents = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_plane);
            bw.WriteVector4(m_aabbCenter);
            bw.WriteVector4(m_aabbHalfExtents);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

