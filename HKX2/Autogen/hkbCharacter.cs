using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbCharacter Signatire: 0x3088a5c5 size: 160 flags: FLAGS_NONE

    // m_nearbyCharacters m_class: hkbCharacter Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_currentLod m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_numTracksInLod m_class:  Type.TYPE_INT16 Type.TYPE_VOID arrSize: 0 offset: 34 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_ragdollDriver m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 48 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_characterControllerDriver m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 56 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_footIkDriver m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 64 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_handIkDriver m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 72 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_setup m_class: hkbCharacterSetup Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_behaviorGraph m_class: hkbBehaviorGraph Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_projectData m_class: hkbProjectData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_animationBindingSet m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 104 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_raycastInterface m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 112 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_world m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 120 flags: SERIALIZE_IGNORED|NOT_OWNED|FLAGS_NONE enum: 
    // m_eventQueue m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 128 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_worldFromModel m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 136 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_poseLocal m_class:  Type.TYPE_SIMPLEARRAY Type.TYPE_VOID arrSize: 0 offset: 144 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_deleteWorldFromModel m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 156 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_deletePoseLocal m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 157 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbCharacter : hkReferencedObject
    {
        public List<hkbCharacter> m_nearbyCharacters = new List<hkbCharacter>();
        public short m_currentLod;
        public short m_numTracksInLod;
        public string m_name;
        public dynamic m_ragdollDriver;
        public dynamic m_characterControllerDriver;
        public dynamic m_footIkDriver;
        public dynamic m_handIkDriver;
        public hkbCharacterSetup m_setup;
        public hkbBehaviorGraph m_behaviorGraph;
        public hkbProjectData m_projectData;
        public dynamic m_animationBindingSet;
        public dynamic m_raycastInterface;
        public dynamic m_world;
        public dynamic m_eventQueue;
        public dynamic m_worldFromModel;
        public dynamic m_poseLocal;
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
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            m_setup = des.ReadClassPointer<hkbCharacterSetup>(br);
            m_behaviorGraph = des.ReadClassPointer<hkbBehaviorGraph>(br);
            m_projectData = des.ReadClassPointer<hkbProjectData>(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            des.ReadEmptyPointer(br);
            throw new NotImplementedException("TPYE_SIMPLEARRAY");
            m_deleteWorldFromModel = br.ReadBoolean();
            m_deletePoseLocal = br.ReadBoolean();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray<hkbCharacter>(bw, m_nearbyCharacters);
            bw.WriteInt16(m_currentLod);
            bw.WriteInt16(m_numTracksInLod);
            bw.Position += 4;
            s.WriteStringPointer(bw, m_name);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteClassPointer(bw, m_setup);
            s.WriteClassPointer(bw, m_behaviorGraph);
            s.WriteClassPointer(bw, m_projectData);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            s.WriteVoidPointer(bw);
            throw new NotImplementedException("TPYE_SIMPLEARRAY");
            bw.WriteBoolean(m_deleteWorldFromModel);
            bw.WriteBoolean(m_deletePoseLocal);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_nearbyCharacters = xd.ReadClassPointerArray<hkbCharacter>(xe, nameof(m_nearbyCharacters));
            m_currentLod = xd.ReadInt16(xe, nameof(m_currentLod));
            m_numTracksInLod = default;
            m_name = xd.ReadString(xe, nameof(m_name));
            m_ragdollDriver = default;
            m_characterControllerDriver = default;
            m_footIkDriver = default;
            m_handIkDriver = default;
            m_setup = xd.ReadClassPointer<hkbCharacterSetup>(xe, nameof(m_setup));
            m_behaviorGraph = xd.ReadClassPointer<hkbBehaviorGraph>(xe, nameof(m_behaviorGraph));
            m_projectData = xd.ReadClassPointer<hkbProjectData>(xe, nameof(m_projectData));
            m_animationBindingSet = default;
            m_raycastInterface = default;
            m_world = default;
            m_eventQueue = default;
            m_worldFromModel = default;
            m_poseLocal = default;
            m_deleteWorldFromModel = default;
            m_deletePoseLocal = default;
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteClassPointerArray<hkbCharacter>(xe, nameof(m_nearbyCharacters), m_nearbyCharacters);
            xs.WriteNumber(xe, nameof(m_currentLod), m_currentLod);
            xs.WriteSerializeIgnored(xe, nameof(m_numTracksInLod));
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteSerializeIgnored(xe, nameof(m_ragdollDriver));
            xs.WriteSerializeIgnored(xe, nameof(m_characterControllerDriver));
            xs.WriteSerializeIgnored(xe, nameof(m_footIkDriver));
            xs.WriteSerializeIgnored(xe, nameof(m_handIkDriver));
            xs.WriteClassPointer(xe, nameof(m_setup), m_setup);
            xs.WriteClassPointer(xe, nameof(m_behaviorGraph), m_behaviorGraph);
            xs.WriteClassPointer(xe, nameof(m_projectData), m_projectData);
            xs.WriteSerializeIgnored(xe, nameof(m_animationBindingSet));
            xs.WriteSerializeIgnored(xe, nameof(m_raycastInterface));
            xs.WriteSerializeIgnored(xe, nameof(m_world));
            xs.WriteSerializeIgnored(xe, nameof(m_eventQueue));
            xs.WriteSerializeIgnored(xe, nameof(m_worldFromModel));
            xs.WriteSerializeIgnored(xe, nameof(m_poseLocal));
            xs.WriteSerializeIgnored(xe, nameof(m_deleteWorldFromModel));
            xs.WriteSerializeIgnored(xe, nameof(m_deletePoseLocal));
        }
    }
}

