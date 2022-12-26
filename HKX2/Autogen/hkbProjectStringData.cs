using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbProjectStringData Signatire: 0x76ad60a size: 120 flags: FLAGS_NONE

    // m_animationFilenames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 16 flags:  enum: 
    // m_behaviorFilenames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 32 flags:  enum: 
    // m_characterFilenames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 48 flags:  enum: 
    // m_eventNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 64 flags:  enum: 
    // m_animationPath m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_behaviorPath m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 88 flags:  enum: 
    // m_characterPath m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_fullPathToSource m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_rootPath m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 112 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbProjectStringData : hkReferencedObject
    {

        public List<string> m_animationFilenames;
        public List<string> m_behaviorFilenames;
        public List<string> m_characterFilenames;
        public List<string> m_eventNames;
        public string m_animationPath;
        public string m_behaviorPath;
        public string m_characterPath;
        public string m_fullPathToSource;
        public string m_rootPath;

        public override uint Signature => 0x76ad60a;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_animationFilenames = des.ReadStringPointerArray(br);
            m_behaviorFilenames = des.ReadStringPointerArray(br);
            m_characterFilenames = des.ReadStringPointerArray(br);
            m_eventNames = des.ReadStringPointerArray(br);
            m_animationPath = des.ReadStringPointer(br);
            m_behaviorPath = des.ReadStringPointer(br);
            m_characterPath = des.ReadStringPointer(br);
            m_fullPathToSource = des.ReadStringPointer(br);
            m_rootPath = des.ReadStringPointer(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointerArray(bw, m_animationFilenames);
            s.WriteStringPointerArray(bw, m_behaviorFilenames);
            s.WriteStringPointerArray(bw, m_characterFilenames);
            s.WriteStringPointerArray(bw, m_eventNames);
            s.WriteStringPointer(bw, m_animationPath);
            s.WriteStringPointer(bw, m_behaviorPath);
            s.WriteStringPointer(bw, m_characterPath);
            s.WriteStringPointer(bw, m_fullPathToSource);
            s.WriteStringPointer(bw, m_rootPath);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

