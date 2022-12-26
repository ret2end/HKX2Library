using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpListShape Signatire: 0xa1937cbd size: 144 flags: FLAGS_NONE

    // m_childInfo m_class: hkpListShapeChildInfo Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 48 flags:  enum: 
    // m_flags m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_numDisabledChildren m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 66 flags:  enum: 
    // m_aabbHalfExtents m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_aabbCenter m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_enabledChildren m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 8 offset: 112 flags:  enum: 

    public class hkpListShape : hkpShapeCollection
    {

        public List<hkpListShapeChildInfo> m_childInfo;
        public ushort m_flags;
        public ushort m_numDisabledChildren;
        public Vector4 m_aabbHalfExtents;
        public Vector4 m_aabbCenter;
        public List<uint> m_enabledChildren;

        public override uint Signature => 0xa1937cbd;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_childInfo = des.ReadClassArray<hkpListShapeChildInfo>(br);
            m_flags = br.ReadUInt16();
            m_numDisabledChildren = br.ReadUInt16();
            br.Position += 12;
            m_aabbHalfExtents = br.ReadVector4();
            m_aabbCenter = br.ReadVector4();
            m_enabledChildren = des.ReadUInt32CStyleArray(br, 8);//m_enabledChildren = br.ReadUInt32();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassArray<hkpListShapeChildInfo>(bw, m_childInfo);
            bw.WriteUInt16(m_flags);
            bw.WriteUInt16(m_numDisabledChildren);
            bw.Position += 12;
            bw.WriteVector4(m_aabbHalfExtents);
            bw.WriteVector4(m_aabbCenter);
            s.WriteUInt32CStyleArray(bw, m_enabledChildren);//bw.WriteUInt32(m_enabledChildren);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

