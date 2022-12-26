using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpConvexVerticesShape Signatire: 0x28726ad8 size: 144 flags: FLAGS_NONE

    // m_aabbHalfExtents m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_aabbCenter m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_rotatedVertices m_class: hkpConvexVerticesShapeFourVectors Type.TYPE_ARRAY Type.TYPE_STRUCT arrSize: 0 offset: 80 flags:  enum: 
    // m_numVertices m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 96 flags:  enum: 
    // m_externalObject m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 104 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_getFaceNormals m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 112 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_planeEquations m_class:  Type.TYPE_ARRAY Type.TYPE_VECTOR4 arrSize: 0 offset: 120 flags:  enum: 
    // m_connectivity m_class: hkpConvexVerticesConnectivity Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 136 flags:  enum: 
    
    public class hkpConvexVerticesShape : hkpConvexShape
    {

        public Vector4 m_aabbHalfExtents;
        public Vector4 m_aabbCenter;
        public List<hkpConvexVerticesShapeFourVectors> m_rotatedVertices;
        public int m_numVertices;
        public dynamic /* POINTER VOID */ m_externalObject;
        public dynamic /* POINTER VOID */ m_getFaceNormals;
        public List<Vector4> m_planeEquations;
        public hkpConvexVerticesConnectivity /*pointer struct*/ m_connectivity;

        public override uint Signature => 0x28726ad8;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            br.Position += 8;
            m_aabbHalfExtents = br.ReadVector4();
            m_aabbCenter = br.ReadVector4();
            m_rotatedVertices = des.ReadClassArray<hkpConvexVerticesShapeFourVectors>(br);
            m_numVertices = br.ReadInt32();
            br.Position += 4;
            des.ReadEmptyPointer(br);/* m_externalObject POINTER VOID */
            des.ReadEmptyPointer(br);/* m_getFaceNormals POINTER VOID */
            m_planeEquations = des.ReadVector4Array(br);
            m_connectivity = des.ReadClassPointer<hkpConvexVerticesConnectivity>(br);

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.Position += 8;
            bw.WriteVector4(m_aabbHalfExtents);
            bw.WriteVector4(m_aabbCenter);
            s.WriteClassArray<hkpConvexVerticesShapeFourVectors>(bw, m_rotatedVertices);
            bw.WriteInt32(m_numVertices);
            bw.Position += 4;
            s.WriteVoidPointer(bw);/* m_externalObject POINTER VOID */
            s.WriteVoidPointer(bw);/* m_getFaceNormals POINTER VOID */
            s.WriteVector4Array(bw, m_planeEquations);
            s.WriteClassPointer(bw, m_connectivity);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

