using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbCharacterStringData Signatire: 0x655b42bc size: 192 flags: FLAGS_NONE

    // m_deformableSkinNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 16 flags:  enum: 
    // m_rigidSkinNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 32 flags:  enum: 
    // m_animationNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 48 flags:  enum: 
    // m_animationFilenames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 64 flags:  enum: 
    // m_characterPropertyNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 80 flags:  enum: 
    // m_retargetingSkeletonMapperFilenames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 96 flags:  enum: 
    // m_lodNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 112 flags:  enum: 
    // m_mirroredSyncPointSubstringsA m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 128 flags:  enum: 
    // m_mirroredSyncPointSubstringsB m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 144 flags:  enum: 
    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 160 flags:  enum: 
    // m_rigName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 168 flags:  enum: 
    // m_ragdollName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 176 flags:  enum: 
    // m_behaviorFilename m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 184 flags:  enum: 
    
    public class hkbCharacterStringData : hkReferencedObject
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

            // throw new NotImplementedException("code generated. check first");
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

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

