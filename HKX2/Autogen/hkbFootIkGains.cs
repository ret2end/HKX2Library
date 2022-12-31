using System.Xml.Linq;

namespace HKX2
{
    // hkbFootIkGains Signatire: 0xa681b7f0 size: 48 flags: FLAGS_NONE

    // m_onOffGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 0 flags: FLAGS_NONE enum: 
    // m_groundAscendingGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 4 flags: FLAGS_NONE enum: 
    // m_groundDescendingGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 8 flags: FLAGS_NONE enum: 
    // m_footPlantedGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 12 flags: FLAGS_NONE enum: 
    // m_footRaisedGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_footUnlockGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 20 flags: FLAGS_NONE enum: 
    // m_worldFromModelFeedbackGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 24 flags: FLAGS_NONE enum: 
    // m_errorUpDownBias m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 28 flags: FLAGS_NONE enum: 
    // m_alignWorldFromModelGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_hipOrientationGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags: FLAGS_NONE enum: 
    // m_maxKneeAngleDifference m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 40 flags: FLAGS_NONE enum: 
    // m_ankleOrientationGain m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 44 flags: FLAGS_NONE enum: 
    public partial class hkbFootIkGains : IHavokObject
    {
        public float m_onOffGain;
        public float m_groundAscendingGain;
        public float m_groundDescendingGain;
        public float m_footPlantedGain;
        public float m_footRaisedGain;
        public float m_footUnlockGain;
        public float m_worldFromModelFeedbackGain;
        public float m_errorUpDownBias;
        public float m_alignWorldFromModelGain;
        public float m_hipOrientationGain;
        public float m_maxKneeAngleDifference;
        public float m_ankleOrientationGain;

        public virtual uint Signature => 0xa681b7f0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_onOffGain = br.ReadSingle();
            m_groundAscendingGain = br.ReadSingle();
            m_groundDescendingGain = br.ReadSingle();
            m_footPlantedGain = br.ReadSingle();
            m_footRaisedGain = br.ReadSingle();
            m_footUnlockGain = br.ReadSingle();
            m_worldFromModelFeedbackGain = br.ReadSingle();
            m_errorUpDownBias = br.ReadSingle();
            m_alignWorldFromModelGain = br.ReadSingle();
            m_hipOrientationGain = br.ReadSingle();
            m_maxKneeAngleDifference = br.ReadSingle();
            m_ankleOrientationGain = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_onOffGain);
            bw.WriteSingle(m_groundAscendingGain);
            bw.WriteSingle(m_groundDescendingGain);
            bw.WriteSingle(m_footPlantedGain);
            bw.WriteSingle(m_footRaisedGain);
            bw.WriteSingle(m_footUnlockGain);
            bw.WriteSingle(m_worldFromModelFeedbackGain);
            bw.WriteSingle(m_errorUpDownBias);
            bw.WriteSingle(m_alignWorldFromModelGain);
            bw.WriteSingle(m_hipOrientationGain);
            bw.WriteSingle(m_maxKneeAngleDifference);
            bw.WriteSingle(m_ankleOrientationGain);
        }

        public virtual void ReadXml(XmlDeserializer xd, XElement xe)
        {

        }

        public virtual void WriteXml(XmlSerializer xs, XElement xe)
        {
            xs.WriteFloat(xe, nameof(m_onOffGain), m_onOffGain);
            xs.WriteFloat(xe, nameof(m_groundAscendingGain), m_groundAscendingGain);
            xs.WriteFloat(xe, nameof(m_groundDescendingGain), m_groundDescendingGain);
            xs.WriteFloat(xe, nameof(m_footPlantedGain), m_footPlantedGain);
            xs.WriteFloat(xe, nameof(m_footRaisedGain), m_footRaisedGain);
            xs.WriteFloat(xe, nameof(m_footUnlockGain), m_footUnlockGain);
            xs.WriteFloat(xe, nameof(m_worldFromModelFeedbackGain), m_worldFromModelFeedbackGain);
            xs.WriteFloat(xe, nameof(m_errorUpDownBias), m_errorUpDownBias);
            xs.WriteFloat(xe, nameof(m_alignWorldFromModelGain), m_alignWorldFromModelGain);
            xs.WriteFloat(xe, nameof(m_hipOrientationGain), m_hipOrientationGain);
            xs.WriteFloat(xe, nameof(m_maxKneeAngleDifference), m_maxKneeAngleDifference);
            xs.WriteFloat(xe, nameof(m_ankleOrientationGain), m_ankleOrientationGain);
        }
    }
}

