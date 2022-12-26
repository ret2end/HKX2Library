using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbFootIkControlsModifier Signatire: 0xe5b6f544 size: 176 flags: FLAGS_NONE

    // m_controlData m_class: hkbFootIkControlData Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_legs m_class: hkbFootIkControlsModifierLeg Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 128 flags:  enum: 
    // m_errorOutTranslation m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_alignWithGroundRotation m_class:  Type.TYPE_QUATERNION Type.TYPE_VOID arrSize: 0 offset: 160 flags:  enum: 
    
    public class hkbFootIkControlsModifier : hkbModifier
    {

        public hkbFootIkControlData/*struct void*/ m_controlData;
        public List<hkbFootIkControlsModifierLeg> m_legs;
        public Vector4 m_errorOutTranslation;
        public Quaternion m_alignWithGroundRotation;

        public override uint Signature => 0xe5b6f544;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_controlData = new hkbFootIkControlData();
            m_controlData.Read(des,br);
            m_legs = des.ReadClassArray<hkbFootIkControlsModifierLeg>(br);
            m_errorOutTranslation = br.ReadVector4();
            m_alignWithGroundRotation = des.ReadQuaternion(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_controlData.Write(s, bw);
            s.WriteClassArray<hkbFootIkControlsModifierLeg>(bw, m_legs);
            bw.WriteVector4(m_errorOutTranslation);
            s.WriteQuaternion(bw, m_alignWithGroundRotation);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}
