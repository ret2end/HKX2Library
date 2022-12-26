using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpMeshShapeSubpart Signatire: 0x27336e5d size: 80 flags: FLAGS_NONE

    // m_vertexBase m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 0 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_vertexStriding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 8 flags:  enum: 
    // m_numVertices m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 12 flags:  enum: 
    // m_indexBase m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 16 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_stridingType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 24 flags:  enum: MeshShapeIndexStridingType
    // m_materialIndexStridingType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 25 flags:  enum: MeshShapeMaterialIndexStridingType
    // m_indexStriding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 28 flags:  enum: 
    // m_flipAlternateTriangles m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_numTriangles m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_materialIndexBase m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 40 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_materialIndexStriding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_materialBase m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 56 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_materialStriding m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_numMaterials m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 68 flags:  enum: 
    // m_triangleOffset m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    
    public class hkpMeshShapeSubpart : IHavokObject
    {

        public dynamic /* POINTER VOID */ m_vertexBase;
        public int m_vertexStriding;
        public int m_numVertices;
        public dynamic /* POINTER VOID */ m_indexBase;
        public sbyte m_stridingType;
        public sbyte m_materialIndexStridingType;
        public int m_indexStriding;
        public int m_flipAlternateTriangles;
        public int m_numTriangles;
        public dynamic /* POINTER VOID */ m_materialIndexBase;
        public int m_materialIndexStriding;
        public dynamic /* POINTER VOID */ m_materialBase;
        public int m_materialStriding;
        public int m_numMaterials;
        public int m_triangleOffset;

        public uint Signature => 0x27336e5d;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            des.ReadEmptyPointer(br);/* m_vertexBase POINTER VOID */
            m_vertexStriding = br.ReadInt32();
            m_numVertices = br.ReadInt32();
            des.ReadEmptyPointer(br);/* m_indexBase POINTER VOID */
            m_stridingType = br.ReadSByte();
            m_materialIndexStridingType = br.ReadSByte();
            br.Position += 2;
            m_indexStriding = br.ReadInt32();
            m_flipAlternateTriangles = br.ReadInt32();
            m_numTriangles = br.ReadInt32();
            des.ReadEmptyPointer(br);/* m_materialIndexBase POINTER VOID */
            m_materialIndexStriding = br.ReadInt32();
            br.Position += 4;
            des.ReadEmptyPointer(br);/* m_materialBase POINTER VOID */
            m_materialStriding = br.ReadInt32();
            m_numMaterials = br.ReadInt32();
            m_triangleOffset = br.ReadInt32();
            br.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteVoidPointer(bw);/* m_vertexBase POINTER VOID */
            bw.WriteInt32(m_vertexStriding);
            bw.WriteInt32(m_numVertices);
            s.WriteVoidPointer(bw);/* m_indexBase POINTER VOID */
            s.WriteSByte(bw, m_stridingType);
            s.WriteSByte(bw, m_materialIndexStridingType);
            bw.Position += 2;
            bw.WriteInt32(m_indexStriding);
            bw.WriteInt32(m_flipAlternateTriangles);
            bw.WriteInt32(m_numTriangles);
            s.WriteVoidPointer(bw);/* m_materialIndexBase POINTER VOID */
            bw.WriteInt32(m_materialIndexStriding);
            bw.Position += 4;
            s.WriteVoidPointer(bw);/* m_materialBase POINTER VOID */
            bw.WriteInt32(m_materialStriding);
            bw.WriteInt32(m_numMaterials);
            bw.WriteInt32(m_triangleOffset);
            bw.Position += 4;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

