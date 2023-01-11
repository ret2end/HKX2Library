using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkaSkeletonLocalFrameOnBone Signatire: 0x52e8043 size: 16 flags: FLAGS_NONE

    // m_localFrame m_class: hkLocalFrame Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_boneIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    public partial class hkaSkeletonLocalFrameOnBone : IHavokObject
    {
        public hkLocalFrame? m_localFrame { set; get; } = default;
        public int m_boneIndex { set; get; } = default;

        public virtual uint Signature => 0x52e8043;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_localFrame = des.ReadClassPointer<hkLocalFrame>(br);
            m_boneIndex = br.ReadInt32();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteClassPointer(bw, m_localFrame);
            bw.WriteInt32(m_boneIndex);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {
            m_localFrame = xd.ReadClassPointer<hkLocalFrame>(xe, nameof(m_localFrame));
            m_boneIndex = xd.ReadInt32(xe, nameof(m_boneIndex));
        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteClassPointer(xe, nameof(m_localFrame), m_localFrame);
            xs.WriteNumber(xe, nameof(m_boneIndex), m_boneIndex);
        }
    }
}

