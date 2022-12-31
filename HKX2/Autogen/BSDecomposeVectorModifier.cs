using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // BSDecomposeVectorModifier Signatire: 0x31f6b8b6 size: 112 flags: FLAGS_NONE

    // m_vector m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_x m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_y m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 100 flags: FLAGS_NONE enum: 
    // m_z m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // m_w m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 108 flags: FLAGS_NONE enum: 
    public partial class BSDecomposeVectorModifier : hkbModifier
    {
        public Vector4 m_vector;
        public float m_x;
        public float m_y;
        public float m_z;
        public float m_w;

        public override uint Signature => 0x31f6b8b6;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vector = br.ReadVector4();
            m_x = br.ReadSingle();
            m_y = br.ReadSingle();
            m_z = br.ReadSingle();
            m_w = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteVector4(m_vector);
            bw.WriteSingle(m_x);
            bw.WriteSingle(m_y);
            bw.WriteSingle(m_z);
            bw.WriteSingle(m_w);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_vector), m_vector);
            xs.WriteFloat(xe, nameof(m_x), m_x);
            xs.WriteFloat(xe, nameof(m_y), m_y);
            xs.WriteFloat(xe, nameof(m_z), m_z);
            xs.WriteFloat(xe, nameof(m_w), m_w);
        }
    }
}

