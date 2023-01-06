using System.Collections.Generic;
using System.Xml.Linq;

namespace HKX2
{
    // hkaFootstepAnalysisInfo Signatire: 0x824faf75 size: 208 flags: FLAGS_NONE

    // m_name m_class:  Type.TYPE_ARRAY Type.TYPE_CHAR arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_nameStrike m_class:  Type.TYPE_ARRAY Type.TYPE_CHAR arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_nameLift m_class:  Type.TYPE_ARRAY Type.TYPE_CHAR arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_nameLock m_class:  Type.TYPE_ARRAY Type.TYPE_CHAR arrSize: 0 offset: 64 flags: FLAGS_NONE enum: 
    // m_nameUnlock m_class:  Type.TYPE_ARRAY Type.TYPE_CHAR arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_minPos m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_maxPos m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_minVel m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_maxVel m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_allBonesDown m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 160 flags: FLAGS_NONE enum: 
    // m_anyBonesDown m_class:  Type.TYPE_ARRAY Type.TYPE_REAL arrSize: 0 offset: 176 flags: FLAGS_NONE enum: 
    // m_posTol m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 192 flags: FLAGS_NONE enum: 
    // m_velTol m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 196 flags: FLAGS_NONE enum: 
    // m_duration m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 200 flags: FLAGS_NONE enum: 
    public partial class hkaFootstepAnalysisInfo : hkReferencedObject
    {
        public string m_name;
        public string m_nameStrike;
        public string m_nameLift;
        public string m_nameLock;
        public string m_nameUnlock;
        public List<float> m_minPos;
        public List<float> m_maxPos;
        public List<float> m_minVel;
        public List<float> m_maxVel;
        public List<float> m_allBonesDown;
        public List<float> m_anyBonesDown;
        public float m_posTol;
        public float m_velTol;
        public float m_duration;

        public override uint Signature => 0x824faf75;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = br.ReadASCII();
            m_nameStrike = br.ReadASCII();
            m_nameLift = br.ReadASCII();
            m_nameLock = br.ReadASCII();
            m_nameUnlock = br.ReadASCII();
            m_minPos = des.ReadSingleArray(br);
            m_maxPos = des.ReadSingleArray(br);
            m_minVel = des.ReadSingleArray(br);
            m_maxVel = des.ReadSingleArray(br);
            m_allBonesDown = des.ReadSingleArray(br);
            m_anyBonesDown = des.ReadSingleArray(br);
            m_posTol = br.ReadSingle();
            m_velTol = br.ReadSingle();
            m_duration = br.ReadSingle();
            br.Position += 4;
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteASCII(m_name, true);
            bw.WriteASCII(m_nameStrike, true);
            bw.WriteASCII(m_nameLift, true);
            bw.WriteASCII(m_nameLock, true);
            bw.WriteASCII(m_nameUnlock, true);
            s.WriteSingleArray(bw, m_minPos);
            s.WriteSingleArray(bw, m_maxPos);
            s.WriteSingleArray(bw, m_minVel);
            s.WriteSingleArray(bw, m_maxVel);
            s.WriteSingleArray(bw, m_allBonesDown);
            s.WriteSingleArray(bw, m_anyBonesDown);
            bw.WriteSingle(m_posTol);
            bw.WriteSingle(m_velTol);
            bw.WriteSingle(m_duration);
            bw.Position += 4;
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_name = xd.ReadString(xe, nameof(m_name));
            m_nameStrike = xd.ReadString(xe, nameof(m_nameStrike));
            m_nameLift = xd.ReadString(xe, nameof(m_nameLift));
            m_nameLock = xd.ReadString(xe, nameof(m_nameLock));
            m_nameUnlock = xd.ReadString(xe, nameof(m_nameUnlock));
            m_minPos = xd.ReadSingleArray(xe, nameof(m_minPos));
            m_maxPos = xd.ReadSingleArray(xe, nameof(m_maxPos));
            m_minVel = xd.ReadSingleArray(xe, nameof(m_minVel));
            m_maxVel = xd.ReadSingleArray(xe, nameof(m_maxVel));
            m_allBonesDown = xd.ReadSingleArray(xe, nameof(m_allBonesDown));
            m_anyBonesDown = xd.ReadSingleArray(xe, nameof(m_anyBonesDown));
            m_posTol = xd.ReadSingle(xe, nameof(m_posTol));
            m_velTol = xd.ReadSingle(xe, nameof(m_velTol));
            m_duration = xd.ReadSingle(xe, nameof(m_duration));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteString(xe, nameof(m_name), m_name);
            xs.WriteString(xe, nameof(m_nameStrike), m_nameStrike);
            xs.WriteString(xe, nameof(m_nameLift), m_nameLift);
            xs.WriteString(xe, nameof(m_nameLock), m_nameLock);
            xs.WriteString(xe, nameof(m_nameUnlock), m_nameUnlock);
            xs.WriteFloatArray(xe, nameof(m_minPos), m_minPos);
            xs.WriteFloatArray(xe, nameof(m_maxPos), m_maxPos);
            xs.WriteFloatArray(xe, nameof(m_minVel), m_minVel);
            xs.WriteFloatArray(xe, nameof(m_maxVel), m_maxVel);
            xs.WriteFloatArray(xe, nameof(m_allBonesDown), m_allBonesDown);
            xs.WriteFloatArray(xe, nameof(m_anyBonesDown), m_anyBonesDown);
            xs.WriteFloat(xe, nameof(m_posTol), m_posTol);
            xs.WriteFloat(xe, nameof(m_velTol), m_velTol);
            xs.WriteFloat(xe, nameof(m_duration), m_duration);
        }
    }
}

