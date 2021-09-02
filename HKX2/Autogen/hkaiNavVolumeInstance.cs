using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkaiNavVolumeInstance : hkReferencedObject
    {
        public List<int> m_cellMap;
        public List<hkaiNavVolumeInstanceCellInstance> m_instancedCells;
        public uint m_layer;

        public hkaiNavVolume m_originalVolume;
        public List<hkaiNavVolumeEdge> m_ownedEdges;
        public int m_runtimeId;
        public uint m_sectionUid;
        public Vector4 m_translation;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            m_originalVolume = des.ReadClassPointer<hkaiNavVolume>(br);
            m_cellMap = des.ReadInt32Array(br);
            m_instancedCells = des.ReadClassArray<hkaiNavVolumeInstanceCellInstance>(br);
            m_ownedEdges = des.ReadClassArray<hkaiNavVolumeEdge>(br);
            m_sectionUid = br.ReadUInt32();
            m_runtimeId = br.ReadInt32();
            m_layer = br.ReadUInt32();
            br.ReadUInt64();
            br.ReadUInt32();
            m_translation = des.ReadVector4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            s.WriteClassPointer(bw, m_originalVolume);
            s.WriteInt32Array(bw, m_cellMap);
            s.WriteClassArray(bw, m_instancedCells);
            s.WriteClassArray(bw, m_ownedEdges);
            bw.WriteUInt32(m_sectionUid);
            bw.WriteInt32(m_runtimeId);
            bw.WriteUInt32(m_layer);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            s.WriteVector4(bw, m_translation);
        }
    }
}