using System.Collections.Generic;

namespace HKX2
{
    public enum ParameterType
    {
        UNKNOWN = 0,
        LINEAR_SPEED = 1,
        LINEAR_DIRECTION = 2,
        TURN_SPEED = 3
    }

    public class hkaParameterizedAnimationReferenceFrame : hkaDefaultAnimatedReferenceFrame
    {
        public List<int> m_parameterTypes;

        public List<float> m_parameterValues;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_parameterValues = des.ReadSingleArray(br);
            m_parameterTypes = des.ReadInt32Array(br);
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteSingleArray(bw, m_parameterValues);
            s.WriteInt32Array(bw, m_parameterTypes);
            bw.WriteUInt64(0);
        }
    }
}