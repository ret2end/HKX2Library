using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpDisplayBindingDataRigidBody Signatire: 0xfe16e2a3 size: 96 flags: FLAGS_NONE

    // m_rigidBody m_class: hkpRigidBody Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_displayObjectPtr m_class: hkReferencedObject Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags:  enum: 
    // m_rigidBodyFromDisplayObjectTransform m_class:  Type.TYPE_MATRIX4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkpDisplayBindingDataRigidBody : hkReferencedObject
    {

        public hkpRigidBody /*pointer struct*/ m_rigidBody;
        public hkReferencedObject /*pointer struct*/ m_displayObjectPtr;
        public Matrix4x4 m_rigidBodyFromDisplayObjectTransform;

        public override uint Signature => 0xfe16e2a3;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_rigidBody = des.ReadClassPointer<hkpRigidBody>(br);
            m_displayObjectPtr = des.ReadClassPointer<hkReferencedObject>(br);
            m_rigidBodyFromDisplayObjectTransform = des.ReadMatrix4(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_rigidBody);
            s.WriteClassPointer(bw, m_displayObjectPtr);
            s.WriteMatrix4(bw, m_rigidBodyFromDisplayObjectTransform);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

