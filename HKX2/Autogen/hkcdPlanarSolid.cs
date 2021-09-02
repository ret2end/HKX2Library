namespace HKX2
{
    public enum BuildResult
    {
        BUILD_SUCCESS = 0,
        BUILD_SUCCESS_CYCLIC_MAT = 1,
        BUILD_WITH_DOUBLED_POLYS = 2,
        BUILD_FAILURE = 3
    }

    public enum NodeTypesEnum
    {
        NODE_TYPE_INTERNAL = 0,
        NODE_TYPE_IN = 1,
        NODE_TYPE_OUT = 2,
        NODE_TYPE_UNKNOWN = 3,
        NODE_TYPE_INVALID = 4,
        NODE_TYPE_FREE = 15
    }

    public class hkcdPlanarSolid : hkcdPlanarEntity
    {
        public hkcdPlanarSolidNodeStorage m_nodes;
        public hkcdPlanarGeometryPlanesCollection m_planes;
        public uint m_rootNodeId;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_nodes = des.ReadClassPointer<hkcdPlanarSolidNodeStorage>(br);
            m_planes = des.ReadClassPointer<hkcdPlanarGeometryPlanesCollection>(br);
            m_rootNodeId = br.ReadUInt32();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_nodes);
            s.WriteClassPointer(bw, m_planes);
            bw.WriteUInt32(m_rootNodeId);
            bw.WriteUInt32(0);
        }
    }
}