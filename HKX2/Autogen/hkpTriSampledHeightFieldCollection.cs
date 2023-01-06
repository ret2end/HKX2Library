using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpTriSampledHeightFieldCollection Signatire: 0xc291ddde size: 96 flags: FLAGS_NONE

    // m_heightfield m_class: hkpSampledHeightFieldShape Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_childSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_radius m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 60 flags: FLAGS_NONE enum: 
    // m_weldingInfo m_class:  Type.TYPE_ARRAY Type.TYPE_UINT16 arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_triangleExtrusion m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    public partial class hkpTriSampledHeightFieldCollection : hkpShapeCollection
    {
        public hkpSampledHeightFieldShape m_heightfield;
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
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_heightfield);
            bw.WriteInt32(m_childSize);
            bw.WriteSingle(m_radius);
            s.WriteUInt16Array(bw, m_weldingInfo);
            bw.WriteVector4(m_triangleExtrusion);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_heightfield = xd.ReadClassPointer<hkpSampledHeightFieldShape>(xe, nameof(m_heightfield));
            m_childSize = default;
            m_radius = xd.ReadSingle(xe, nameof(m_radius));
            m_weldingInfo = xd.ReadUInt16Array(xe, nameof(m_weldingInfo));
            m_triangleExtrusion = xd.ReadVector4(xe, nameof(m_triangleExtrusion));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointer(xe, nameof(m_heightfield), m_heightfield);
            xs.WriteSerializeIgnored(xe, nameof(m_childSize));
            xs.WriteFloat(xe, nameof(m_radius), m_radius);
            xs.WriteNumberArray(xe, nameof(m_weldingInfo), m_weldingInfo);
            xs.WriteVector4(xe, nameof(m_triangleExtrusion), m_triangleExtrusion);
        }
    }
}

