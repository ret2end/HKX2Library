using System.Xml.Linq;

namespace HKX2
{
    // hkaQuantizedAnimationTrackCompressionParams Signatire: 0xf7d64649 size: 16 flags: FLAGS_NONE

    // m_rotationTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_translationTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_scaleTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_floatingTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    public partial class hkaQuantizedAnimationTrackCompressionParams : IHavokObject
    {
        public float m_rotationTolerance;
        public float m_translationTolerance;
        public float m_scaleTolerance;
        public float m_floatingTolerance;

        public virtual uint Signature => 0xf7d64649;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_rotationTolerance = br.ReadSingle();
            m_translationTolerance = br.ReadSingle();
            m_scaleTolerance = br.ReadSingle();
            m_floatingTolerance = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_rotationTolerance);
            bw.WriteSingle(m_translationTolerance);
            bw.WriteSingle(m_scaleTolerance);
            bw.WriteSingle(m_floatingTolerance);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_rotationTolerance = xd.ReadSingle(xe, nameof(m_rotationTolerance));
            m_translationTolerance = xd.ReadSingle(xe, nameof(m_translationTolerance));
            m_scaleTolerance = xd.ReadSingle(xe, nameof(m_scaleTolerance));
            m_floatingTolerance = xd.ReadSingle(xe, nameof(m_floatingTolerance));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteFloat(xe, nameof(m_rotationTolerance), m_rotationTolerance);
            xs.WriteFloat(xe, nameof(m_translationTolerance), m_translationTolerance);
            xs.WriteFloat(xe, nameof(m_scaleTolerance), m_scaleTolerance);
            xs.WriteFloat(xe, nameof(m_floatingTolerance), m_floatingTolerance);
        }
    }
}

