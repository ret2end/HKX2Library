namespace HKX2
{
    public enum SplitResult
    {
        SPLIT_SUCCESS = 0,
        SPLIT_FAILURE = 1,
        SPLIT_FAILURE_INSIDE = 2,
        SPLIT_FAILURE_OUTSIDE = 3
    }

    public enum ExecutionFlagValues
    {
        CREATE_PHYSICS_SHAPES = 1,
        CREATE_GRAPHICS_SHAPES = 2,
        RECOMPUTE_INSIDE_TRANSFORM = 4,
        RECOMPUTE_OUTSIDE_TRANSFORM = 8,
        COMPUTE_INSIDE_SHAPES = 16,
        COMPUTE_OUTSIDE_SHAPES = 32,
        FRACTURE_PHYSICS = 64,
        FRACTURE_GRAPHICS = 128,
        DYNAMIC_SPLIT = 256,
        DEFAULT_EXECUTION_FLAGS = 255
    }

    public enum Topology
    {
        TOPOLOGY_CLOSED_MANIFOLD = 0,
        TOPOLOGY_OPEN_SELF_INTERSECTING = 1,
        TOPOLOGY_UNKNOWN = 2
    }

    public class hkcdFractureEngine : hkReferencedObject
    {
        public enum Type
        {
            TYPE_EXACT = 0,
            TYPE_USER_0 = 16
        }

        public override uint Signature => 0;


        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
        }
    }
}