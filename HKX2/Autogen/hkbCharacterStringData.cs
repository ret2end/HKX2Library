using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbCharacterStringData Signatire: 0x655b42bc size: 192 flags: FLAGS_NONE

    // m_deformableSkinNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_rigidSkinNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_animationNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_animationFilenames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_characterPropertyNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_retargetingSkeletonMapperFilenames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_lodNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_mirroredSyncPointSubstringsA m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_mirroredSyncPointSubstringsB m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 160 flags: FLAGS_NONE enum: 
    // m_rigName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 168 flags: FLAGS_NONE enum: 
    // m_ragdollName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 176 flags: FLAGS_NONE enum: 
    // m_behaviorFilename m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 184 flags: FLAGS_NONE enum: 
    public partial class hkbCharacterStringData : hkReferencedObject
    {
        public List<string> m_deformableSkinNames;
        public List<string> m_rigidSkinNames;
        public List<string> m_animationNames;
        public List<string> m_animationFilenames;
        public List<string> m_characterPropertyNames;
        public List<string> m_retargetingSkeletonMapperFilenames;
        public List<string> m_lodNames;
        public List<string> m_mirroredSyncPointSubstringsA;
        public List<string> m_mirroredSyncPointSubstringsB;
        public string m_name;
        public string m_rigName;
        public string m_ragdollName;
        public string m_behaviorFilename;

        public override uint Signature => 0x655b42bc;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_deformableSkinNames = des.ReadStringPointerArray(br);
            m_rigidSkinNames = des.ReadStringPointerArray(br);
            m_animationNames = des.ReadStringPointerArray(br);
            m_animationFilenames = des.ReadStringPointerArray(br);
            m_characterPropertyNames = des.ReadStringPointerArray(br);
            m_retargetingSkeletonMapperFilenames = des.ReadStringPointerArray(br);
            m_lodNames = des.ReadStringPointerArray(br);
            m_mirroredSyncPointSubstringsA = des.ReadStringPointerArray(br);
            m_mirroredSyncPointSubstringsB = des.ReadStringPointerArray(br);
            m_name = des.ReadStringPointer(br);
            m_rigName = des.ReadStringPointer(br);
            m_ragdollName = des.ReadStringPointer(br);
            m_behaviorFilename = des.ReadStringPointer(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointerArray(bw, m_deformableSkinNames);
            s.WriteStringPointerArray(bw, m_rigidSkinNames);
            s.WriteStringPointerArray(bw, m_animationNames);
            s.WriteStringPointerArray(bw, m_animationFilenames);
            s.WriteStringPointerArray(bw, m_characterPropertyNames);
            s.WriteStringPointerArray(bw, m_retargetingSkeletonMapperFilenames);
            s.WriteStringPointerArray(bw, m_lodNames);
            s.WriteStringPointerArray(bw, m_mirroredSyncPointSubstringsA);
            s.WriteStringPointerArray(bw, m_mirroredSyncPointSubstringsB);
            s.WriteStringPointer(bw, m_name);
            s.WriteStringPointer(bw, m_rigName);
            s.WriteStringPointer(bw, m_ragdollName);
            s.WriteStringPointer(bw, m_behaviorFilename);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_deformableSkinNames = xd.ReadStringArray(xe, nameof(m_deformableSkinNames));
            m_rigidSkinNames = xd.ReadStringArray(xe, nameof(m_rigidSkinNames));
            m_animationNames = xd.ReadStringArray(xe, nameof(m_animationNames));
            m_animationFilenames = xd.ReadStringArray(xe, nameof(m_animationFilenames));
            m_characterPropertyNames = xd.ReadStringArray(xe, nameof(m_characterPropertyNames));
            m_retargetingSkeletonMapperFilenames = xd.ReadStringArray(xe, nameof(m_retargetingSkeletonMapperFilenames));
            m_lodNames = xd.ReadStringArray(xe, nameof(m_lodNames));
            m_mirroredSyncPointSubstringsA = xd.ReadStringArray(xe, nameof(m_mirroredSyncPointSubstringsA));
            m_mirroredSyncPointSubstringsB = xd.ReadStringArray(xe, nameof(m_mirroredSyncPointSubstringsB));
            m_name = xd.ReadString(xe, nameof(m_name));
            m_rigName = xd.ReadString(xe, nameof(m_rigName));
            m_ragdollName = xd.ReadString(xe, nameof(m_ragdollName));
            m_behaviorFilename = xd.ReadString(xe, nameof(m_behaviorFilename));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteStringArray(xe, nameof(m_deformableSkinNames), m_deformableSkinNames);
            xs.WriteStringArray(xe, nameof(m_rigidSkinNames), m_rigidSkinNames);
            xs.WriteStringArray(xe, nameof(m_animationNames), m_animationNames);
            xs.WriteStringArray(xe, nameof(m_animationFilenames), m_animationFilenames);
            xs.WriteStringArray(xe, nameof(m_characterPropertyNames), m_characterPropertyNames);
            xs.WriteStringArray(xe, nameof(m_retargetingSkeletonMapperFilenames), m_retargetingSkeletonMapperFilenames);
            xs.WriteStringArray(xe, nameof(m_lodNames), m_lodNames);
            xs.WriteStringArray(xe, nameof(m_mirroredSyncPointSubstringsA), m_mirroredSyncPointSubstringsA);
            xs.WriteStringArray(xe, nameof(m_mirroredSyncPointSubstringsB), m_mirroredSyncPointSubstringsB);
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteString(xe, nameof(m_rigName), m_rigName);
            xs.WriteString(xe, nameof(m_ragdollName), m_ragdollName);
            xs.WriteString(xe, nameof(m_behaviorFilename), m_behaviorFilename);
        }
    }
}

