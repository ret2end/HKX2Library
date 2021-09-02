namespace HKX2
{
    public enum hkaReferenceFrameTypeEnum
    {
        REFERENCE_FRAME_UNKNOWN = 0,
        REFERENCE_FRAME_DEFAULT = 1,
        REFERENCE_FRAME_PARAMETRIC = 2
    }

    public class hkaAnimatedReferenceFrame : hkReferencedObject
    {
        public override uint Signature => 0x0;
    }
}