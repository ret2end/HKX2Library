using System.Xml.Linq;

namespace HKX2
{
    // hkpSimpleShapePhantomCollisionDetail Signatire: 0x98bfa6ce size: 8 flags: FLAGS_NOT_SERIALIZABLE

    // m_collidable m_class: hkpCollidable Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    public partial class hkpSimpleShapePhantomCollisionDetail : IHavokObject
    {
        public hkpCollidable m_collidable;

        public virtual uint Signature => 0x98bfa6ce;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_collidable = des.ReadClassPointer<hkpCollidable>(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_collidable);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClassPointer(xe, nameof(m_collidable), m_collidable);
        }
    }
}

