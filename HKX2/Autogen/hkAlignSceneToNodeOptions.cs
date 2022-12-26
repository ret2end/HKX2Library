using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkAlignSceneToNodeOptions Signatire: 0x207cb01 size: 40 flags: FLAGS_NONE

    // m_invert m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_transformPositionX m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 17 flags:  enum: 
    // m_transformPositionY m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 18 flags:  enum: 
    // m_transformPositionZ m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 19 flags:  enum: 
    // m_transformRotation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 20 flags:  enum: 
    // m_transformScale m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 21 flags:  enum: 
    // m_transformSkew m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 22 flags:  enum: 
    // m_keyframe m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_nodeName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkAlignSceneToNodeOptions : hkReferencedObject
    {

        public bool m_invert;
        public bool m_transformPositionX;
        public bool m_transformPositionY;
        public bool m_transformPositionZ;
        public bool m_transformRotation;
        public bool m_transformScale;
        public bool m_transformSkew;
        public int m_keyframe;
        public string m_nodeName;

        public override uint Signature => 0x207cb01;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_invert = br.ReadBoolean();
            m_transformPositionX = br.ReadBoolean();
            m_transformPositionY = br.ReadBoolean();
            m_transformPositionZ = br.ReadBoolean();
            m_transformRotation = br.ReadBoolean();
            m_transformScale = br.ReadBoolean();
            m_transformSkew = br.ReadBoolean();
            br.Position += 1;
            m_keyframe = br.ReadInt32();
            br.Position += 4;
            m_nodeName = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteBoolean(m_invert);
            bw.WriteBoolean(m_transformPositionX);
            bw.WriteBoolean(m_transformPositionY);
            bw.WriteBoolean(m_transformPositionZ);
            bw.WriteBoolean(m_transformRotation);
            bw.WriteBoolean(m_transformScale);
            bw.WriteBoolean(m_transformSkew);
            bw.Position += 1;
            bw.WriteInt32(m_keyframe);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_nodeName);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

