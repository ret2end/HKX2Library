using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxCamera Signatire: 0xe3597b02 size: 80 flags: FLAGS_NONE

    // m_from m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_focus m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_up m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_fov m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_far m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags:  enum: 
    // m_near m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_leftHanded m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 76 flags:  enum: 
    
    public class hkxCamera : hkReferencedObject
    {

        public Vector4 m_from;
        public Vector4 m_focus;
        public Vector4 m_up;
        public float m_fov;
        public float m_far;
        public float m_near;
        public bool m_leftHanded;

        public override uint Signature => 0xe3597b02;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_from = br.ReadVector4();
            m_focus = br.ReadVector4();
            m_up = br.ReadVector4();
            m_fov = br.ReadSingle();
            m_far = br.ReadSingle();
            m_near = br.ReadSingle();
            m_leftHanded = br.ReadBoolean();
            br.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_from);
            bw.WriteVector4(m_focus);
            bw.WriteVector4(m_up);
            bw.WriteSingle(m_fov);
            bw.WriteSingle(m_far);
            bw.WriteSingle(m_near);
            bw.WriteBoolean(m_leftHanded);
            bw.Position += 3;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

