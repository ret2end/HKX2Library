using System.Collections.Generic;
using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkbCharacterAddedInfo Signatire: 0x3544e182 size: 128 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_instanceName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_templateName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_fullPathToProject m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_skeleton m_class: hkaSkeleton Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_worldFromModel m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_poseModelSpace m_class:  Type.TYPE_ARRAY Type.TYPE_QSTRANSFORM arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    public partial class hkbCharacterAddedInfo : hkReferencedObject
    {
        public ulong m_characterId;
        public string m_instanceName;
        public string m_templateName;
        public string m_fullPathToProject;
        public hkaSkeleton m_skeleton;
        public Matrix4x4 m_worldFromModel;
        public List<Matrix4x4> m_poseModelSpace;

        public override uint Signature => 0x3544e182;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_characterId = br.ReadUInt64();
            m_instanceName = des.ReadStringPointer(br);
            m_templateName = des.ReadStringPointer(br);
            m_fullPathToProject = des.ReadStringPointer(br);
            m_skeleton = des.ReadClassPointer<hkaSkeleton>(br);
            br.Position += 8;
            m_worldFromModel = des.ReadQSTransform(br);
            m_poseModelSpace = des.ReadQSTransformArray(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(m_characterId);
            s.WriteStringPointer(bw, m_instanceName);
            s.WriteStringPointer(bw, m_templateName);
            s.WriteStringPointer(bw, m_fullPathToProject);
            s.WriteClassPointer(bw, m_skeleton);
            bw.Position += 8;
            s.WriteQSTransform(bw, m_worldFromModel);
            s.WriteQSTransformArray(bw, m_poseModelSpace);
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_characterId = xd.ReadUInt64(xe, nameof(m_characterId));
            m_instanceName = xd.ReadString(xe, nameof(m_instanceName));
            m_templateName = xd.ReadString(xe, nameof(m_templateName));
            m_fullPathToProject = xd.ReadString(xe, nameof(m_fullPathToProject));
            m_skeleton = xd.ReadClassPointer<hkaSkeleton>(xe, nameof(m_skeleton));
            m_worldFromModel = xd.ReadQSTransform(xe, nameof(m_worldFromModel));
            m_poseModelSpace = xd.ReadQSTransformArray(xe, nameof(m_poseModelSpace));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteNumber(xe, nameof(m_characterId), m_characterId);
            xs.WriteString(xe, nameof(m_instanceName), m_instanceName);
            xs.WriteString(xe, nameof(m_templateName), m_templateName);
            xs.WriteString(xe, nameof(m_fullPathToProject), m_fullPathToProject);
            xs.WriteClassPointer(xe, nameof(m_skeleton), m_skeleton);
            xs.WriteQSTransform(xe, nameof(m_worldFromModel), m_worldFromModel);
            xs.WriteQSTransformArray(xe, nameof(m_poseModelSpace), m_poseModelSpace);
        }
    }
}

