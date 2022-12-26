using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkxMaterialShader Signatire: 0x28515eff size: 72 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_type m_class:  Type.TYPE_ENUM Type.TYPE_UINT8 arrSize: 0 offset: 24 flags:  enum: ShaderType
    // m_vertexEntryName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_geomEntryName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 40 flags:  enum: 
    // m_pixelEntryName m_class:  Type.TYPE_STRINGPTR Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_data m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 56 flags:  enum: 
    
    public class hkxMaterialShader : hkReferencedObject
    {

        public string m_name;
        public byte m_type;
        public string m_vertexEntryName;
        public string m_geomEntryName;
        public string m_pixelEntryName;
        public List<byte> m_data;

        public override uint Signature => 0x28515eff;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_type = br.ReadByte();
            br.Position += 7;
            m_vertexEntryName = des.ReadStringPointer(br);
            m_geomEntryName = des.ReadStringPointer(br);
            m_pixelEntryName = des.ReadStringPointer(br);
            m_data = des.ReadByteArray(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteByte(bw, m_type);
            bw.Position += 7;
            s.WriteStringPointer(bw, m_vertexEntryName);
            s.WriteStringPointer(bw, m_geomEntryName);
            s.WriteStringPointer(bw, m_pixelEntryName);
            s.WriteByteArray(bw, m_data);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

