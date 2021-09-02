namespace HKX2
{
    public class hkTraceStreamTitle : IHavokObject
    {
        public sbyte m_value_0;
        public sbyte m_value_1;
        public sbyte m_value_10;
        public sbyte m_value_11;
        public sbyte m_value_12;
        public sbyte m_value_13;
        public sbyte m_value_14;
        public sbyte m_value_15;
        public sbyte m_value_16;
        public sbyte m_value_17;
        public sbyte m_value_18;
        public sbyte m_value_19;
        public sbyte m_value_2;
        public sbyte m_value_20;
        public sbyte m_value_21;
        public sbyte m_value_22;
        public sbyte m_value_23;
        public sbyte m_value_24;
        public sbyte m_value_25;
        public sbyte m_value_26;
        public sbyte m_value_27;
        public sbyte m_value_28;
        public sbyte m_value_29;
        public sbyte m_value_3;
        public sbyte m_value_30;
        public sbyte m_value_31;
        public sbyte m_value_4;
        public sbyte m_value_5;
        public sbyte m_value_6;
        public sbyte m_value_7;
        public sbyte m_value_8;
        public sbyte m_value_9;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_value_0 = br.ReadSByte();
            m_value_1 = br.ReadSByte();
            m_value_2 = br.ReadSByte();
            m_value_3 = br.ReadSByte();
            m_value_4 = br.ReadSByte();
            m_value_5 = br.ReadSByte();
            m_value_6 = br.ReadSByte();
            m_value_7 = br.ReadSByte();
            m_value_8 = br.ReadSByte();
            m_value_9 = br.ReadSByte();
            m_value_10 = br.ReadSByte();
            m_value_11 = br.ReadSByte();
            m_value_12 = br.ReadSByte();
            m_value_13 = br.ReadSByte();
            m_value_14 = br.ReadSByte();
            m_value_15 = br.ReadSByte();
            m_value_16 = br.ReadSByte();
            m_value_17 = br.ReadSByte();
            m_value_18 = br.ReadSByte();
            m_value_19 = br.ReadSByte();
            m_value_20 = br.ReadSByte();
            m_value_21 = br.ReadSByte();
            m_value_22 = br.ReadSByte();
            m_value_23 = br.ReadSByte();
            m_value_24 = br.ReadSByte();
            m_value_25 = br.ReadSByte();
            m_value_26 = br.ReadSByte();
            m_value_27 = br.ReadSByte();
            m_value_28 = br.ReadSByte();
            m_value_29 = br.ReadSByte();
            m_value_30 = br.ReadSByte();
            m_value_31 = br.ReadSByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSByte(m_value_0);
            bw.WriteSByte(m_value_1);
            bw.WriteSByte(m_value_2);
            bw.WriteSByte(m_value_3);
            bw.WriteSByte(m_value_4);
            bw.WriteSByte(m_value_5);
            bw.WriteSByte(m_value_6);
            bw.WriteSByte(m_value_7);
            bw.WriteSByte(m_value_8);
            bw.WriteSByte(m_value_9);
            bw.WriteSByte(m_value_10);
            bw.WriteSByte(m_value_11);
            bw.WriteSByte(m_value_12);
            bw.WriteSByte(m_value_13);
            bw.WriteSByte(m_value_14);
            bw.WriteSByte(m_value_15);
            bw.WriteSByte(m_value_16);
            bw.WriteSByte(m_value_17);
            bw.WriteSByte(m_value_18);
            bw.WriteSByte(m_value_19);
            bw.WriteSByte(m_value_20);
            bw.WriteSByte(m_value_21);
            bw.WriteSByte(m_value_22);
            bw.WriteSByte(m_value_23);
            bw.WriteSByte(m_value_24);
            bw.WriteSByte(m_value_25);
            bw.WriteSByte(m_value_26);
            bw.WriteSByte(m_value_27);
            bw.WriteSByte(m_value_28);
            bw.WriteSByte(m_value_29);
            bw.WriteSByte(m_value_30);
            bw.WriteSByte(m_value_31);
        }
    }
}