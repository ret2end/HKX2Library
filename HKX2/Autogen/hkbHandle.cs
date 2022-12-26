using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbHandle Signatire: 0xd8b6401c size: 48 flags: FLAGS_NONE

    // m_frame m_class: hkLocalFrame Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_rigidBody m_class: hkpRigidBody Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags:  enum: 
    // m_character m_class: hkbCharacter Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    // m_animationBoneIndex m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    
    public class hkbHandle : hkReferencedObject
    {

        public hkLocalFrame /*pointer struct*/ m_frame;
        public hkpRigidBody /*pointer struct*/ m_rigidBody;
        public hkbCharacter /*pointer struct*/ m_character;
        public short m_animationBoneIndex;

        public override uint Signature => 0xd8b6401c;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_frame = des.ReadClassPointer<hkLocalFrame>(br);
            m_rigidBody = des.ReadClassPointer<hkpRigidBody>(br);
            m_character = des.ReadClassPointer<hkbCharacter>(br);
            m_animationBoneIndex = br.ReadInt16();
            br.Position += 6;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_frame);
            s.WriteClassPointer(bw, m_rigidBody);
            s.WriteClassPointer(bw, m_character);
            bw.WriteInt16(m_animationBoneIndex);
            bw.Position += 6;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

