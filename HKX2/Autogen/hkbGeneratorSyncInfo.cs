using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbGeneratorSyncInfo Signatire: 0xa3c341f8 size: 80 flags: FLAGS_NONE

    // m_syncPoints m_class: hkbGeneratorSyncInfoSyncPoint Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 8 offset: 0 flags:  enum: 
    // m_baseFrequency m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags:  enum: 
    // m_localTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 68 flags:  enum: 
    // m_playbackSpeed m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 72 flags:  enum: 
    // m_numSyncPoints m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 76 flags:  enum: 
    // m_isCyclic m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 77 flags:  enum: 
    // m_isMirrored m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 78 flags:  enum: 
    // m_isAdditive m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 79 flags:  enum: 

    public class hkbGeneratorSyncInfo : IHavokObject
    {

        public List<hkbGeneratorSyncInfoSyncPoint/*struct void*/> m_syncPoints;
        public float m_baseFrequency;
        public float m_localTime;
        public float m_playbackSpeed;
        public sbyte m_numSyncPoints;
        public bool m_isCyclic;
        public bool m_isMirrored;
        public bool m_isAdditive;

        public uint Signature => 0xa3c341f8;

        public void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_syncPoints = des.ReadStructCStyleArray<hkbGeneratorSyncInfoSyncPoint>(br, 8);
            //m_syncPoints = new hkbGeneratorSyncInfoSyncPoint();
            //m_syncPoints.Read(des, br);
            br.Position += 8;
            m_baseFrequency = br.ReadSingle();
            m_localTime = br.ReadSingle();
            m_playbackSpeed = br.ReadSingle();
            m_numSyncPoints = br.ReadSByte();
            m_isCyclic = br.ReadBoolean();
            m_isMirrored = br.ReadBoolean();
            m_isAdditive = br.ReadBoolean();

            // throw new NotImplementedException("code generated. check first");
        }

        public void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            s.WriteStructCStyleArray(bw, m_syncPoints);//m_syncPoints.Write(s, bw);
            bw.Position += 8;
            bw.WriteSingle(m_baseFrequency);
            bw.WriteSingle(m_localTime);
            bw.WriteSingle(m_playbackSpeed);
            bw.WriteSByte(m_numSyncPoints);
            bw.WriteBoolean(m_isCyclic);
            bw.WriteBoolean(m_isMirrored);
            bw.WriteBoolean(m_isAdditive);

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

