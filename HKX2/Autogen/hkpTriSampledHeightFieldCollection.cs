using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpTriSampledHeightFieldCollection Signatire: 0xc291ddde size: 96 flags: FLAGS_NONE

    // m_heightfield m_class: hkpSampledHeightFieldShape Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags:  enum: 
    // m_childSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_radius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 60 flags:  enum: 
    // m_weldingInfo m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 64 flags:  enum: 
    // m_triangleExtrusion m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    
    public class hkpTriSampledHeightFieldCollection : hkpShapeCollection
    {

        public hkpSampledHeightFieldShape /*pointer struct*/ m_heightfield;
        public int m_childSize;
        public float m_radius;
        public List<ushort> m_weldingInfo;
        public Vector4 m_triangleExtrusion;

        public override uint Signature => 0xc291ddde;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_heightfield = des.ReadClassPointer<hkpSampledHeightFieldShape>(br);
            m_childSize = br.ReadInt32();
            m_radius = br.ReadSingle();
            m_weldingInfo = des.ReadUInt16Array(br);
            m_triangleExtrusion = br.ReadVector4();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_heightfield);
            bw.WriteInt32(m_childSize);
            bw.WriteSingle(m_radius);
            s.WriteUInt16Array(bw, m_weldingInfo);
            bw.WriteVector4(m_triangleExtrusion);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

