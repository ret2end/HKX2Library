using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkbProjectStringData Signatire: 0x76ad60a size: 120 flags: FLAGS_NONE

    // m_animationFilenames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_behaviorFilenames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_characterFilenames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_eventNames m_class:  Type.TYPE_ARRAY Type.TYPE_STRINGPTR arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_animationPath m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_behaviorPath m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_characterPath m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_fullPathToSource m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // m_rootPath m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 112 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    public partial class hkbProjectStringData : hkReferencedObject
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
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteStringArray(xe, nameof(m_animationFilenames), m_animationFilenames);
            xs.WriteStringArray(xe, nameof(m_behaviorFilenames), m_behaviorFilenames);
            xs.WriteStringArray(xe, nameof(m_characterFilenames), m_characterFilenames);
            xs.WriteStringArray(xe, nameof(m_eventNames), m_eventNames);
            xs.WriteString(xe, nameof(m_animationPath), m_animationPath);
            xs.WriteString(xe, nameof(m_behaviorPath), m_behaviorPath);
            xs.WriteString(xe, nameof(m_characterPath), m_characterPath);
            xs.WriteString(xe, nameof(m_fullPathToSource), m_fullPathToSource);
            xs.WriteSerializeIgnored(xe, nameof(m_rootPath));
        }
    }
}

