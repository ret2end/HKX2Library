using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpBridgeAtoms Signatire: 0xde152a4d size: 24 flags: FLAGS_NONE

    // m_bridgeAtom m_class: hkpBridgeConstraintAtom Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    public partial class hkpBridgeAtoms : IHavokObject
    {
        public hkpBridgeConstraintAtom m_bridgeAtom { set; get; } = new();

        public virtual uint Signature => 0xde152a4d;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_bridgeAtom.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_bridgeAtom.Write(s, bw);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_bridgeAtom = xd.ReadClass<hkpBridgeConstraintAtom>(xe, nameof(m_bridgeAtom));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClass<hkpBridgeConstraintAtom>(xe, nameof(m_bridgeAtom), m_bridgeAtom);
        }
    }
}

