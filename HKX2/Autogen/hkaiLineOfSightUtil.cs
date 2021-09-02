namespace HKX2
{
    public enum UserEdgeFlagBits
    {
        USER_EDGE_IGNORE = 0,
        USER_EDGE_UNTRAVERSABLE_AS_BOUNDARY = 1,
        USER_EDGE_ALL_AS_BOUNDARY = 2,
        USER_EDGE_FOLLOW = 4,
        USER_EDGE_PRIORITIZE_REGULAR_EDGE = 8,
        USER_EDGE_IGNORE_WINDING = 16,
        USER_EDGE_IGNORE_BOUNDARIES_WHEN_TRAVERSING = 32,
        USER_EDGE_ROTATE_DIRECTION = 64,
        USER_EDGE_DISABLED_DEFAULT = 0,
        USER_EDGE_ENABLED_DEFAULT = 124
    }

    public enum LineOfSightResult
    {
        RESULT_INVALID_INPUT = 0,
        RESULT_CANT_ADVANCE = 1,
        RESULT_REACHED_BOUNDARY_CHECK_LIMIT = 2,
        RESULT_IN_PROGRESS = 3,
        RESULT_HIT_BOUNDARY_EDGE = 4,
        RESULT_HIT_REJECTED_EDGE = 5,
        RESULT_REACHED_RADIUS_LIMIT = 6,
        RESULT_REACHED_PATH_LENGTH_LIMIT = 7,
        RESULT_REACHED_ITERATION_LIMIT = 8,
        RESULT_REACHED_GOAL = 9
    }

    public class hkaiLineOfSightUtil : IHavokObject
    {
        public virtual uint Signature => 0;


        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteByte(0);
        }
    }
}