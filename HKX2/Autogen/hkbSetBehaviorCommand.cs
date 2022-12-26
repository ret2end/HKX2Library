using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbSetBehaviorCommand Signatire: 0xe18b74b9 size: 72 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_behavior m_class: hkbBehaviorGraph Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 24 flags:  enum: 
    // m_rootGenerator m_class: hkbGenerator Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    // m_referencedBehaviors m_class: hkbBehaviorGraph Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 40 flags:  enum: 
    // m_startStateIndex m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    // m_randomizeSimulation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 60 flags:  enum: 
    // m_padding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    
    public class hkbSetBehaviorCommand : hkReferencedObject
    {

        public ulong m_characterId;
        public hkbBehaviorGraph /*pointer struct*/ m_behavior;
        public hkbGenerator /*pointer struct*/ m_rootGenerator;
        public List<hkbBehaviorGraph> m_referencedBehaviors;
        public int m_startStateIndex;
        public bool m_randomizeSimulation;
        public int m_padding;

        public override uint Signature => 0xe18b74b9;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_behavior = des.ReadClassPointer<hkbBehaviorGraph>(br);
            m_rootGenerator = des.ReadClassPointer<hkbGenerator>(br);
            m_referencedBehaviors = des.ReadClassPointerArray<hkbBehaviorGraph>(br);
            m_startStateIndex = br.ReadInt32();
            m_randomizeSimulation = br.ReadBoolean();
            br.Position += 3;
            m_padding = br.ReadInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            s.WriteClassPointer(bw, m_behavior);
            s.WriteClassPointer(bw, m_rootGenerator);
            s.WriteClassPointerArray<hkbBehaviorGraph>(bw, m_referencedBehaviors);
            bw.WriteInt32(m_startStateIndex);
            bw.WriteBoolean(m_randomizeSimulation);
            bw.Position += 3;
            bw.WriteInt32(m_padding);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

