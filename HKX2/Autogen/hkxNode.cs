using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkxNode : hkxAttributeHolder
    {
        public List<hkxNodeAnnotationData> m_annotations;
        public bool m_bone;
        public List<hkxNode> m_children;
        public List<Matrix4x4> m_keyFrames;
        public List<float> m_linearKeyFrameHints;

        public string m_name;
        public hkReferencedObject m_object;
        public bool m_selected;
        public string m_userProperties;
        public hkUuid m_uuid;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_uuid = new hkUuid();
            m_uuid.Read(des, br);
            m_object = des.ReadClassPointer<hkReferencedObject>(br);
            m_keyFrames = des.ReadMatrix4Array(br);
            m_children = des.ReadClassPointerArray<hkxNode>(br);
            m_annotations = des.ReadClassArray<hkxNodeAnnotationData>(br);
            m_linearKeyFrameHints = des.ReadSingleArray(br);
            m_userProperties = des.ReadStringPointer(br);
            m_selected = br.ReadBoolean();
            m_bone = br.ReadBoolean();
            br.ReadUInt32();
            br.ReadUInt16();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            m_uuid.Write(s, bw);
            s.WriteClassPointer(bw, m_object);
            s.WriteMatrix4Array(bw, m_keyFrames);
            s.WriteClassPointerArray(bw, m_children);
            s.WriteClassArray(bw, m_annotations);
            s.WriteSingleArray(bw, m_linearKeyFrameHints);
            s.WriteStringPointer(bw, m_userProperties);
            bw.WriteBoolean(m_selected);
            bw.WriteBoolean(m_bone);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
        }
    }
}