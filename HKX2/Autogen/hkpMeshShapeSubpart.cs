using System.Xml.Linq;

namespace HKX2
{
    // hkpMeshShapeSubpart Signatire: 0x27336e5d size: 80 flags: FLAGS_NONE

    // m_vertexBase m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_vertexStriding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_numVertices m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    // m_indexBase m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_stridingType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 24 flags: FLAGS_NONE enum: MeshShapeIndexStridingType
    // m_materialIndexStridingType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 25 flags: FLAGS_NONE enum: MeshShapeMaterialIndexStridingType
    // m_indexStriding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags: FLAGS_NONE enum: 
    // m_flipAlternateTriangles m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_numTriangles m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 36 flags: FLAGS_NONE enum: 
    // m_materialIndexBase m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 40 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_materialIndexStriding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_materialBase m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 56 flags: SERIALIZE_IGNORED|FLAGS_NONE enum: 
    // m_materialStriding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_numMaterials m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 68 flags: FLAGS_NONE enum: 
    // m_triangleOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 72 flags: FLAGS_NONE enum: 
    public partial class hkpMeshShapeSubpart : IHavokObject
    {
        public dynamic m_vertexBase;
        public int m_vertexStriding;
        public int m_numVertices;
        public dynamic m_indexBase;
        public sbyte m_stridingType;
        public sbyte m_materialIndexStridingType;
        public int m_indexStriding;
        public int m_flipAlternateTriangles;
        public int m_numTriangles;
        public dynamic m_materialIndexBase;
        public int m_materialIndexStriding;
        public dynamic m_materialBase;
        public int m_materialStriding;
        public int m_numMaterials;
        public int m_triangleOffset;

        public virtual uint Signature => 0x27336e5d;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            des.ReadEmptyPointer(br);
            m_vertexStriding = br.ReadInt32();
            m_numVertices = br.ReadInt32();
            des.ReadEmptyPointer(br);
            m_stridingType = br.ReadSByte();
            m_materialIndexStridingType = br.ReadSByte();
            br.Position += 2;
            m_indexStriding = br.ReadInt32();
            m_flipAlternateTriangles = br.ReadInt32();
            m_numTriangles = br.ReadInt32();
            des.ReadEmptyPointer(br);
            m_materialIndexStriding = br.ReadInt32();
            br.Position += 4;
            des.ReadEmptyPointer(br);
            m_materialStriding = br.ReadInt32();
            m_numMaterials = br.ReadInt32();
            m_triangleOffset = br.ReadInt32();
            br.Position += 4;
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVoidPointer(bw);
            bw.WriteInt32(m_vertexStriding);
            bw.WriteInt32(m_numVertices);
            s.WriteVoidPointer(bw);
            s.WriteSByte(bw, m_stridingType);
            s.WriteSByte(bw, m_materialIndexStridingType);
            bw.Position += 2;
            bw.WriteInt32(m_indexStriding);
            bw.WriteInt32(m_flipAlternateTriangles);
            bw.WriteInt32(m_numTriangles);
            s.WriteVoidPointer(bw);
            bw.WriteInt32(m_materialIndexStriding);
            bw.Position += 4;
            s.WriteVoidPointer(bw);
            bw.WriteInt32(m_materialStriding);
            bw.WriteInt32(m_numMaterials);
            bw.WriteInt32(m_triangleOffset);
            bw.Position += 4;
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteSerializeIgnored(xe, nameof(m_vertexBase));
            xs.WriteNumber(xe, nameof(m_vertexStriding), m_vertexStriding);
            xs.WriteNumber(xe, nameof(m_numVertices), m_numVertices);
            xs.WriteSerializeIgnored(xe, nameof(m_indexBase));
            xs.WriteEnum<MeshShapeIndexStridingType, sbyte>(xe, nameof(m_stridingType), m_stridingType);
            xs.WriteEnum<MeshShapeMaterialIndexStridingType, sbyte>(xe, nameof(m_materialIndexStridingType), m_materialIndexStridingType);
            xs.WriteNumber(xe, nameof(m_indexStriding), m_indexStriding);
            xs.WriteNumber(xe, nameof(m_flipAlternateTriangles), m_flipAlternateTriangles);
            xs.WriteNumber(xe, nameof(m_numTriangles), m_numTriangles);
            xs.WriteSerializeIgnored(xe, nameof(m_materialIndexBase));
            xs.WriteNumber(xe, nameof(m_materialIndexStriding), m_materialIndexStriding);
            xs.WriteSerializeIgnored(xe, nameof(m_materialBase));
            xs.WriteNumber(xe, nameof(m_materialStriding), m_materialStriding);
            xs.WriteNumber(xe, nameof(m_numMaterials), m_numMaterials);
            xs.WriteNumber(xe, nameof(m_triangleOffset), m_triangleOffset);
        }
    }
}

