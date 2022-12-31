using System.Xml.Linq;

namespace HKX2
{
    // hkpLinLimitConstraintAtom Signatire: 0xa44d1b07 size: 12 flags: FLAGS_NONE

    // m_axisIndex m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 2 flags: FLAGS_NONE enum: 
    // m_min m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_max m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkpLinLimitConstraintAtom : hkpConstraintAtom
    {
        public byte m_axisIndex;
        public float m_min;
        public float m_max;

        public override uint Signature => 0xa44d1b07;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_axisIndex = br.ReadByte();
            br.Position += 1;
            m_min = br.ReadSingle();
            m_max = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte(m_axisIndex);
            bw.Position += 1;
            bw.WriteSingle(m_min);
            bw.WriteSingle(m_max);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_axisIndex), m_axisIndex);
            xs.WriteFloat(xe, nameof(m_min), m_min);
            xs.WriteFloat(xe, nameof(m_max), m_max);
        }
    }
}

