using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpShapePhantom Signatire: 0xcb22fbcd size: 416 flags: FLAGS_NONE

    // m_motionState m_class: hkMotionState Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 240 flags:  enum: 
    
    public class hkpShapePhantom : hkpPhantom
    {

        public hkMotionState/*struct void*/ m_motionState;

        public override uint Signature => 0xcb22fbcd;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_motionState = new hkMotionState();
            m_motionState.Read(des,br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_motionState.Write(s, bw);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

