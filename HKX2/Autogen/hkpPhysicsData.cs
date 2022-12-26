using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpPhysicsData Signatire: 0xc2a461e4 size: 40 flags: FLAGS_NONE

    // m_worldCinfo m_class: hkpWorldCinfo Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_systems m_class: hkpPhysicsSystem Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 24 flags:  enum: 
    
    public class hkpPhysicsData : hkReferencedObject
    {

        public hkpWorldCinfo /*pointer struct*/ m_worldCinfo;
        public List<hkpPhysicsSystem> m_systems;

        public override uint Signature => 0xc2a461e4;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_worldCinfo = des.ReadClassPointer<hkpWorldCinfo>(br);
            m_systems = des.ReadClassPointerArray<hkpPhysicsSystem>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_worldCinfo);
            s.WriteClassPointerArray<hkpPhysicsSystem>(bw, m_systems);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

