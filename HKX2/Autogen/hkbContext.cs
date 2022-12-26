using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbContext Signatire: 0xe0c4d4a7 size: 80 flags: FLAGS_NONE

    // m_character m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_behavior m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 8 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_nodeToIndexMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_eventQueue m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 24 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_sharedEventQueue m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 32 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_generatorOutputListener m_class: hkbGeneratorOutputListener Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 40 flags:  enum: 
    // m_eventTriggeredTransition m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 48 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_world m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 56 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_attachmentManager m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 64 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_animationCache m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 72 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbContext : IHavokObject
    {

        public dynamic /* POINTER VOID */ m_character;
        public dynamic /* POINTER VOID */ m_behavior;
        public dynamic /* POINTER VOID */ m_nodeToIndexMap;
        public dynamic /* POINTER VOID */ m_eventQueue;
        public dynamic /* POINTER VOID */ m_sharedEventQueue;
        public hkbGeneratorOutputListener /*pointer struct*/ m_generatorOutputListener;
        public bool m_eventTriggeredTransition;
        public dynamic /* POINTER VOID */ m_world;
        public dynamic /* POINTER VOID */ m_attachmentManager;
        public dynamic /* POINTER VOID */ m_animationCache;

        public uint Signature => 0xe0c4d4a7;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            des.ReadEmptyPointer(br);/* m_character POINTER VOID */
            des.ReadEmptyPointer(br);/* m_behavior POINTER VOID */
            des.ReadEmptyPointer(br);/* m_nodeToIndexMap POINTER VOID */
            des.ReadEmptyPointer(br);/* m_eventQueue POINTER VOID */
            des.ReadEmptyPointer(br);/* m_sharedEventQueue POINTER VOID */
            m_generatorOutputListener = des.ReadClassPointer<hkbGeneratorOutputListener>(br);
            m_eventTriggeredTransition = br.ReadBoolean();
            br.Position += 7;
            des.ReadEmptyPointer(br);/* m_world POINTER VOID */
            des.ReadEmptyPointer(br);/* m_attachmentManager POINTER VOID */
            des.ReadEmptyPointer(br);/* m_animationCache POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteVoidPointer(bw);/* m_character POINTER VOID */
            s.WriteVoidPointer(bw);/* m_behavior POINTER VOID */
            s.WriteVoidPointer(bw);/* m_nodeToIndexMap POINTER VOID */
            s.WriteVoidPointer(bw);/* m_eventQueue POINTER VOID */
            s.WriteVoidPointer(bw);/* m_sharedEventQueue POINTER VOID */
            s.WriteClassPointer(bw, m_generatorOutputListener);
            bw.WriteBoolean(m_eventTriggeredTransition);
            bw.Position += 7;
            s.WriteVoidPointer(bw);/* m_world POINTER VOID */
            s.WriteVoidPointer(bw);/* m_attachmentManager POINTER VOID */
            s.WriteVoidPointer(bw);/* m_animationCache POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

