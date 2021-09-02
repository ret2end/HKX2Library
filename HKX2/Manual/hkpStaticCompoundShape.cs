using System.Collections.Generic;

namespace HKX2
{
    public class hkpStaticCompoundShape : hkpBvTreeShape
    {
        public enum Config
        {
            NUM_BYTES_FOR_TREE = 48
        }

        public hkpShapeKeyTable m_disabledLargeShapeKeyTable;
        public List<ushort> m_instanceExtraInfos;
        public List<hkpStaticCompoundShapeInstance> m_instances;

        public sbyte m_numBitsForChildShapeKey;
        public hkcdStaticTreeDefaultTreeStorage6 m_tree;
        public override uint Signature => 0xD029071E;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUSize();
            m_numBitsForChildShapeKey = br.ReadSByte();
            br.ReadByte(); // referencePolicy
            br.ReadUInt16();
            br.ReadUInt32(); // childShapeKeyMask
            m_instances = des.ReadClassArray<hkpStaticCompoundShapeInstance>(br);
            m_instanceExtraInfos = des.ReadUInt16Array(br);
            m_disabledLargeShapeKeyTable = new hkpShapeKeyTable();
            m_disabledLargeShapeKeyTable.Read(des, br);
            m_tree = new hkcdStaticTreeDefaultTreeStorage6();
            m_tree.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUSize(0);
            bw.WriteSByte(m_numBitsForChildShapeKey);
            bw.WriteByte(0); // referencePolicy
            bw.WriteUInt16(0);
            bw.WriteUInt32(0); // childShapeKeyMask
            s.WriteClassArray(bw, m_instances);
            s.WriteUInt16Array(bw, m_instanceExtraInfos);
            m_disabledLargeShapeKeyTable.Write(s, bw);
            m_tree.Write(s, bw);
        }
    }
}