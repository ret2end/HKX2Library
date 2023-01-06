using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkaSkeleton Signatire: 0x366e8220 size: 120 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_parentIndices m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_bones m_class: hkaBone Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_referencePose m_class:  Type.TYPE_ARRAY Type.TYPE_QSTRANSFORM arrSize: 0 offset: 56 flags: FLAGS_NONE enum: 
    // m_referenceFloats m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    // m_floatSlots m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_localFrames m_class: hkaSkeletonLocalFrameOnBone Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    public partial class hkaSkeleton : hkReferencedObject
    {
        public string m_name;
        public List<short> m_parentIndices;
        public List<hkaBone> m_bones = new List<hkaBone>();
        public List<Matrix4x4> m_referencePose;
        public List<float> m_referenceFloats;
        public List<string> m_floatSlots;
        public List<hkaSkeletonLocalFrameOnBone> m_localFrames = new List<hkaSkeletonLocalFrameOnBone>();

        public override uint Signature => 0x366e8220;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_parentIndices = des.ReadInt16Array(br);
            m_bones = des.ReadClassArray<hkaBone>(br);
            m_referencePose = des.ReadQSTransformArray(br);
            m_referenceFloats = des.ReadSingleArray(br);
            m_floatSlots = des.ReadStringPointerArray(br);
            m_localFrames = des.ReadClassArray<hkaSkeletonLocalFrameOnBone>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteInt16Array(bw, m_parentIndices);
            s.WriteClassArray<hkaBone>(bw, m_bones);
            s.WriteQSTransformArray(bw, m_referencePose);
            s.WriteSingleArray(bw, m_referenceFloats);
            s.WriteStringPointerArray(bw, m_floatSlots);
            s.WriteClassArray<hkaSkeletonLocalFrameOnBone>(bw, m_localFrames);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_name = xd.ReadString(xe, nameof(m_name));
            m_parentIndices = xd.ReadInt16Array(xe, nameof(m_parentIndices));
            m_bones = xd.ReadClassArray<hkaBone>(xe, nameof(m_bones));
            m_referencePose = xd.ReadQSTransformArray(xe, nameof(m_referencePose));
            m_referenceFloats = xd.ReadSingleArray(xe, nameof(m_referenceFloats));
            m_floatSlots = xd.ReadStringArray(xe, nameof(m_floatSlots));
            m_localFrames = xd.ReadClassArray<hkaSkeletonLocalFrameOnBone>(xe, nameof(m_localFrames));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteNumberArray(xe, nameof(m_parentIndices), m_parentIndices);
            xs.WriteClassArray<hkaBone>(xe, nameof(m_bones), m_bones);
            xs.WriteQSTransformArray(xe, nameof(m_referencePose), m_referencePose);
            xs.WriteFloatArray(xe, nameof(m_referenceFloats), m_referenceFloats);
            xs.WriteStringArray(xe, nameof(m_floatSlots), m_floatSlots);
            xs.WriteClassArray<hkaSkeletonLocalFrameOnBone>(xe, nameof(m_localFrames), m_localFrames);
        }
    }
}

