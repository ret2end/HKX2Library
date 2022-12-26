using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbCharacterAddedInfo Signatire: 0x3544e182 size: 128 flags: FLAGS_NONE

    // m_characterId m_class:  Type.TYPE_UINT64 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_instanceName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 24 flags:  enum: 
    // m_templateName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_fullPathToProject m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_skeleton m_class: hkaSkeleton Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags:  enum: 
    // m_worldFromModel m_class:  Type.TYPE_QSTRANSFORM Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_poseModelSpace m_class:  Type.TYPE_ARRAY Type.TYPE_QSTRANSFORM arrSize: 0 offset: 112 flags:  enum: 
    
    public class hkbCharacterAddedInfo : hkReferencedObject
    {

        public ulong m_characterId;
        public string m_instanceName;
        public string m_templateName;
        public string m_fullPathToProject;
        public hkaSkeleton /*pointer struct*/ m_skeleton;
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

            // throw new NotImplementedException("code generated. check first");
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

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

