using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkaSkeleton Signatire: 0x366e8220 size: 120 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_parentIndices m_class:  Type.TYPE_ARRAY Type.TYPE_INT16 arrSize: 0 offset: 24 flags:  enum: 
    // m_bones m_class: hkaBone Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 40 flags:  enum: 
    // m_referencePose m_class:  Type.TYPE_ARRAY Type.TYPE_QSTRANSFORM arrSize: 0 offset: 56 flags:  enum: 
    // m_referenceFloats m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 72 flags:  enum: 
    // m_floatSlots m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 88 flags:  enum: 
    // m_localFrames m_class: hkaSkeletonLocalFrameOnBone Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 104 flags:  enum: 
    
    public class hkaSkeleton : hkReferencedObject
    {

        public string m_name;
        public List<short> m_parentIndices;
        public List<hkaBone> m_bones;
        public List<Matrix4x4> m_referencePose;
        public List<float> m_referenceFloats;
        public List<string> m_floatSlots;
        public List<hkaSkeletonLocalFrameOnBone> m_localFrames;

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

            // throw new NotImplementedException("code generated. check first");
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

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

