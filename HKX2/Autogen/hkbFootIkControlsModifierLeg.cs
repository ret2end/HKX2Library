using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbFootIkControlsModifierLeg Signatire: 0x9e17091a size: 48 flags: FLAGS_NONE

    // m_groundPosition m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 0 flags:  enum: 
    // m_ungroundedEvent m_class: hkbEventProperty Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_verticalError m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_hitSomething m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_isPlantedMS m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 37 flags:  enum: 
    
    public class hkbFootIkControlsModifierLeg : IHavokObject
    {

        public Vector4 m_groundPosition;
        public hkbEventProperty/*struct void*/ m_ungroundedEvent;
        public float m_verticalError;
        public bool m_hitSomething;
        public bool m_isPlantedMS;

        public uint Signature => 0x9e17091a;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            m_groundPosition = br.ReadVector4();
            m_ungroundedEvent = new hkbEventProperty();
            m_ungroundedEvent.Read(des,br);
            m_verticalError = br.ReadSingle();
            m_hitSomething = br.ReadBoolean();
            m_isPlantedMS = br.ReadBoolean();
            br.Position += 10;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            bw.WriteVector4(m_groundPosition);
            m_ungroundedEvent.Write(s, bw);
            bw.WriteSingle(m_verticalError);
            bw.WriteBoolean(m_hitSomething);
            bw.WriteBoolean(m_isPlantedMS);
            bw.Position += 10;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

