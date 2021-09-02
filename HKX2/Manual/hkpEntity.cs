namespace HKX2
{
    public class hkpEntity : hkpWorldObject
    {
        public sbyte m_autoRemoveLevel;
        public ushort m_contactPointCallbackDelay;
        public float m_damageMultiplier;
        public hkLocalFrame m_localFrame;

        public hkpMaterial m_material;
        public hkpMaxSizeMotion m_motion;
        public uint m_npData;
        public byte m_numShapeKeysInContactPointProperties;
        public byte m_responseModifierFlags;
        public hkpEntitySpuCollisionCallback m_spuCollisionCallback;
        public ushort m_storageIndex;
        public uint m_uid;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_material = new hkpMaterial();
            m_material.Read(des, br);
            des.ReadEmptyPointer(br); // limitContactImpulseUtilAndFlag
            m_damageMultiplier = br.ReadSingle();
            des.ReadEmptyPointer(br); // breakableBody
            br.ReadUInt32(); // solverData
            m_storageIndex = br.ReadUInt16();
            m_contactPointCallbackDelay = br.ReadUInt16();
            new hkpEntitySmallArraySerializeOverrideType().Read(des, br); // constraintsMaster
            des.ReadEmptyArray(br); // constraintsSlave
            des.ReadEmptyArray(br); // constraintRuntime
            des.ReadEmptyPointer(br); // simulationIsland
            m_autoRemoveLevel = br.ReadSByte();
            m_numShapeKeysInContactPointProperties = br.ReadByte();
            m_responseModifierFlags = br.ReadByte();
            br.ReadByte();
            m_uid = br.ReadUInt32();
            m_spuCollisionCallback = new hkpEntitySpuCollisionCallback();
            m_spuCollisionCallback.Read(des, br);
            br.Pad(16);
            m_motion = new hkpMaxSizeMotion();
            m_motion.Read(des, br);
            new hkpEntitySmallArraySerializeOverrideType().Read(des, br); // contactListeners
            new hkpEntitySmallArraySerializeOverrideType().Read(des, br); // actions
            m_localFrame = des.ReadClassPointer<hkLocalFrame>(br);
            des.ReadEmptyPointer(br); // extendedListeners
            m_npData = br.ReadUInt32();
            br.Pad(16);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_material.Write(s, bw);
            s.WriteVoidPointer(bw); // limitContactImpulseUtilAndFlag
            bw.WriteSingle(m_damageMultiplier);
            s.WriteVoidPointer(bw); // breakableBody
            bw.WriteUInt32(0); // solverData
            bw.WriteUInt16(m_storageIndex);
            bw.WriteUInt16(m_contactPointCallbackDelay);
            new hkpEntitySmallArraySerializeOverrideType().Write(s, bw); // constraintsMaster
            s.WriteVoidArray(bw); // constraintsSlave
            s.WriteVoidArray(bw); // constraintRuntime
            s.WriteVoidPointer(bw); // simulationIsland
            bw.WriteSByte(m_autoRemoveLevel);
            bw.WriteByte(m_numShapeKeysInContactPointProperties);
            bw.WriteByte(m_responseModifierFlags);
            bw.WriteByte(0);
            bw.WriteUInt32(m_uid);
            m_spuCollisionCallback.Write(s, bw);
            bw.Pad(16);
            m_motion.Write(s, bw);
            new hkpEntitySmallArraySerializeOverrideType().Write(s, bw); // contactListeners
            new hkpEntitySmallArraySerializeOverrideType().Write(s, bw); // actions
            s.WriteClassPointer(bw, m_localFrame);
            s.WriteVoidPointer(bw); // extendedListeners
            bw.WriteUInt32(m_npData);
            bw.Pad(16);
        }
    }
}