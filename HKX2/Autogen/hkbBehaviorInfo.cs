using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbBehaviorInfo Signatire: 0xf7645395 size: 48 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_data m_class: hkbBehaviorGraphData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags:  enum: 
    // m_idToNamePairs m_class: hkbBehaviorInfoIdToNamePair Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    
    public class hkbBehaviorInfo : hkReferencedObject
    {

        public ulong m_characterId;
        public hkbBehaviorGraphData /*pointer struct*/ m_data;
        public List<hkbBehaviorInfoIdToNamePair> m_idToNamePairs;

        public override uint Signature => 0xf7645395;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_data = des.ReadClassPointer<hkbBehaviorGraphData>(br);
            m_idToNamePairs = des.ReadClassArray<hkbBehaviorInfoIdToNamePair>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            s.WriteClassPointer(bw, m_data);
            s.WriteClassArray<hkbBehaviorInfoIdToNamePair>(bw, m_idToNamePairs);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

