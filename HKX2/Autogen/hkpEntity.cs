using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpEntity Signatire: 0xa03c774b size: 720 flags: FLAGS_NONE

    // m_material m_class: hkpMaterial Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 208 flags:  enum: 
    // m_limitContactImpulseUtilAndFlag m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 224 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_damageMultiplier m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 232 flags:  enum: 
    // m_breakableBody m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 240 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_solverData m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 248 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_storageIndex m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 252 flags:  enum: 
    // m_contactPointCallbackDelay m_class:  Type.TYPE_UINT16 Type.TYPE_VOID arrSize: 0 offset: 254 flags:  enum: 
    // m_constraintsMaster m_class: hkpEntitySmallArraySerializeOverrideType Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 256 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_constraintsSlave m_class: hkpConstraintInstance Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 272 flags: SERIALIZE_IGNORED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_constraintRuntime m_class:  Type.TYPE_ARRAY Type.TYPE_UINT8 arrSize: 0 offset: 288 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_simulationIsland m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 304 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_autoRemoveLevel m_class:  Type.TYPE_INT8 Type.TYPE_VOID arrSize: 0 offset: 312 flags:  enum: 
    // m_numShapeKeysInContactPointProperties m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 313 flags:  enum: 
    // m_responseModifierFlags m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 314 flags:  enum: 
    // m_uid m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 316 flags:  enum: 
    // m_spuCollisionCallback m_class: hkpEntitySpuCollisionCallback Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 320 flags:  enum: 
    // m_motion m_class: hkpMaxSizeMotion Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 336 flags:  enum: 
    // m_contactListeners m_class: hkpEntitySmallArraySerializeOverrideType Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 656 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_actions m_class: hkpEntitySmallArraySerializeOverrideType Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 672 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_localFrame m_class: hkLocalFrame Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 688 flags:  enum: 
    // m_extendedListeners m_class: hkpEntityExtendedListeners Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 696 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_npData m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 704 flags:  enum: 
    
    public class hkpEntity : hkpWorldObject
    {

        public hkpMaterial/*struct void*/ m_material;
        public dynamic /* POINTER VOID */ m_limitContactImpulseUtilAndFlag;
        public float m_damageMultiplier;
        public dynamic /* POINTER VOID */ m_breakableBody;
        public uint m_solverData;
        public ushort m_storageIndex;
        public ushort m_contactPointCallbackDelay;
        public hkpEntitySmallArraySerializeOverrideType/*struct void*/ m_constraintsMaster;
        public List<hkpConstraintInstance> m_constraintsSlave;
        public List<byte> m_constraintRuntime;
        public dynamic /* POINTER VOID */ m_simulationIsland;
        public sbyte m_autoRemoveLevel;
        public byte m_numShapeKeysInContactPointProperties;
        public byte m_responseModifierFlags;
        public uint m_uid;
        public hkpEntitySpuCollisionCallback/*struct void*/ m_spuCollisionCallback;
        public hkpMaxSizeMotion/*struct void*/ m_motion;
        public hkpEntitySmallArraySerializeOverrideType/*struct void*/ m_contactListeners;
        public hkpEntitySmallArraySerializeOverrideType/*struct void*/ m_actions;
        public hkLocalFrame /*pointer struct*/ m_localFrame;
        public hkpEntityExtendedListeners /*pointer struct*/ m_extendedListeners;
        public uint m_npData;

        public override uint Signature => 0xa03c774b;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_material = new hkpMaterial();
            m_material.Read(des, br);
            br.Position += 4;
            des.ReadEmptyPointer(br);/* m_limitContactImpulseUtilAndFlag POINTER VOID */
            m_damageMultiplier = br.ReadSingle();
            br.Position += 4;
            des.ReadEmptyPointer(br);/* m_breakableBody POINTER VOID */
            m_solverData = br.ReadUInt32();
            m_storageIndex = br.ReadUInt16();
            m_contactPointCallbackDelay = br.ReadUInt16();
            m_constraintsMaster = new hkpEntitySmallArraySerializeOverrideType();
            m_constraintsMaster.Read(des,br);
            m_constraintsSlave = des.ReadClassPointerArray<hkpConstraintInstance>(br);
            m_constraintRuntime = des.ReadByteArray(br);
            des.ReadEmptyPointer(br);/* m_simulationIsland POINTER VOID */
            m_autoRemoveLevel = br.ReadSByte();
            m_numShapeKeysInContactPointProperties = br.ReadByte();
            m_responseModifierFlags = br.ReadByte();
            br.Position += 1;
            m_uid = br.ReadUInt32();
            m_spuCollisionCallback = new hkpEntitySpuCollisionCallback();
            m_spuCollisionCallback.Read(des,br);
            m_motion = new hkpMaxSizeMotion();
            m_motion.Read(des,br);
            m_contactListeners = new hkpEntitySmallArraySerializeOverrideType();
            m_contactListeners.Read(des,br);
            m_actions = new hkpEntitySmallArraySerializeOverrideType();
            m_actions.Read(des,br);
            m_localFrame = des.ReadClassPointer<hkLocalFrame>(br);
            m_extendedListeners = des.ReadClassPointer<hkpEntityExtendedListeners>(br);
            m_npData = br.ReadUInt32();
            br.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            m_material.Write(s, bw);
            bw.Position += 4;
            s.WriteVoidPointer(bw);/* m_limitContactImpulseUtilAndFlag POINTER VOID */
            bw.WriteSingle(m_damageMultiplier);
            bw.Position += 4;
            s.WriteVoidPointer(bw);/* m_breakableBody POINTER VOID */
            bw.WriteUInt32(m_solverData);
            bw.WriteUInt16(m_storageIndex);
            bw.WriteUInt16(m_contactPointCallbackDelay);
            m_constraintsMaster.Write(s, bw);
            s.WriteClassPointerArray<hkpConstraintInstance>(bw, m_constraintsSlave);
            s.WriteByteArray(bw, m_constraintRuntime);
            s.WriteVoidPointer(bw);/* m_simulationIsland POINTER VOID */
            bw.WriteSByte(m_autoRemoveLevel);
            bw.WriteByte(m_numShapeKeysInContactPointProperties);
            bw.WriteByte(m_responseModifierFlags);
            bw.Position += 1;
            bw.WriteUInt32(m_uid);
            m_spuCollisionCallback.Write(s, bw);
            m_motion.Write(s, bw);
            m_contactListeners.Write(s, bw);
            m_actions.Write(s, bw);
            s.WriteClassPointer(bw, m_localFrame);
            s.WriteClassPointer(bw, m_extendedListeners);
            bw.WriteUInt32(m_npData);
            bw.Position += 12;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

