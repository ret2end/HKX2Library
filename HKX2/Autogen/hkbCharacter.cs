using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbCharacter Signatire: 0x3088a5c5 size: 160 flags: FLAGS_NONE

    // m_nearbyCharacters m_class: hkbCharacter Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags:  enum: 
    // m_currentLod m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_numTracksInLod m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 34 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_ragdollDriver m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 48 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_characterControllerDriver m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 56 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_footIkDriver m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 64 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_handIkDriver m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 72 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_setup m_class: hkbCharacterSetup Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags:  enum: 
    // m_behaviorGraph m_class: hkbBehaviorGraph Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 88 flags:  enum: 
    // m_projectData m_class: hkbProjectData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 96 flags:  enum: 
    // m_animationBindingSet m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 104 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_raycastInterface m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 112 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_world m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 120 flags: SERIALIZE_IGNORED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_eventQueue m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 128 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_worldFromModel m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 136 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_poseLocal m_class:  Type.TYPE_SIMPLEARRAY Type.TYPE_VOID arrSize: 0 offset: 144 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_deleteWorldFromModel m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 156 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_deletePoseLocal m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 157 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbCharacter : hkReferencedObject
    {

        public List<hkbCharacter> m_nearbyCharacters;
        public short m_currentLod;
        public short m_numTracksInLod;
        public string m_name;
        public dynamic /* POINTER VOID */ m_ragdollDriver;
        public dynamic /* POINTER VOID */ m_characterControllerDriver;
        public dynamic /* POINTER VOID */ m_footIkDriver;
        public dynamic /* POINTER VOID */ m_handIkDriver;
        public hkbCharacterSetup /*pointer struct*/ m_setup;
        public hkbBehaviorGraph /*pointer struct*/ m_behaviorGraph;
        public hkbProjectData /*pointer struct*/ m_projectData;
        public dynamic /* POINTER VOID */ m_animationBindingSet;
        public dynamic /* POINTER VOID */ m_raycastInterface;
        public dynamic /* POINTER VOID */ m_world;
        public dynamic /* POINTER VOID */ m_eventQueue;
        public dynamic /* POINTER VOID */ m_worldFromModel;
        public dynamic /*simpleArray void*/ m_poseLocal;
        public bool m_deleteWorldFromModel;
        public bool m_deletePoseLocal;

        public override uint Signature => 0x3088a5c5;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_nearbyCharacters = des.ReadClassPointerArray<hkbCharacter>(br);
            m_currentLod = br.ReadInt16();
            m_numTracksInLod = br.ReadInt16();
            br.Position += 4;
            m_name = des.ReadStringPointer(br);
            des.ReadEmptyPointer(br);/* m_ragdollDriver POINTER VOID */
            des.ReadEmptyPointer(br);/* m_characterControllerDriver POINTER VOID */
            des.ReadEmptyPointer(br);/* m_footIkDriver POINTER VOID */
            des.ReadEmptyPointer(br);/* m_handIkDriver POINTER VOID */
            m_setup = des.ReadClassPointer<hkbCharacterSetup>(br);
            m_behaviorGraph = des.ReadClassPointer<hkbBehaviorGraph>(br);
            m_projectData = des.ReadClassPointer<hkbProjectData>(br);
            des.ReadEmptyPointer(br);/* m_animationBindingSet POINTER VOID */
            des.ReadEmptyPointer(br);/* m_raycastInterface POINTER VOID */
            des.ReadEmptyPointer(br);/* m_world POINTER VOID */
            des.ReadEmptyPointer(br);/* m_eventQueue POINTER VOID */
            des.ReadEmptyPointer(br);/* m_worldFromModel POINTER VOID */
            throw new NotImplementedException("TPYE_SIMPLEARRAY");/*simple array*/
            m_deleteWorldFromModel = br.ReadBoolean();
            m_deletePoseLocal = br.ReadBoolean();

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkbCharacter>(bw, m_nearbyCharacters);
            bw.WriteInt16(m_currentLod);
            bw.WriteInt16(m_numTracksInLod);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_name);
            s.WriteVoidPointer(bw);/* m_ragdollDriver POINTER VOID */
            s.WriteVoidPointer(bw);/* m_characterControllerDriver POINTER VOID */
            s.WriteVoidPointer(bw);/* m_footIkDriver POINTER VOID */
            s.WriteVoidPointer(bw);/* m_handIkDriver POINTER VOID */
            s.WriteClassPointer(bw, m_setup);
            s.WriteClassPointer(bw, m_behaviorGraph);
            s.WriteClassPointer(bw, m_projectData);
            s.WriteVoidPointer(bw);/* m_animationBindingSet POINTER VOID */
            s.WriteVoidPointer(bw);/* m_raycastInterface POINTER VOID */
            s.WriteVoidPointer(bw);/* m_world POINTER VOID */
            s.WriteVoidPointer(bw);/* m_eventQueue POINTER VOID */
            s.WriteVoidPointer(bw);/* m_worldFromModel POINTER VOID */
            throw new NotImplementedException("TPYE_SIMPLEARRAY");/*simple array*/
            bw.WriteBoolean(m_deleteWorldFromModel);
            bw.WriteBoolean(m_deletePoseLocal);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

