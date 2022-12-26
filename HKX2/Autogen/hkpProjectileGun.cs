using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpProjectileGun Signatire: 0xb4f30148 size: 104 flags: FLAGS_NONE

    // m_maxProjectiles m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 56 flags:  enum: 
    // m_reloadTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 60 flags:  enum: 
    // m_reload m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 64 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_projectiles m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 72 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_world m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 88 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_destructionWorld m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 96 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkpProjectileGun : hkpFirstPersonGun
    {

        public int m_maxProjectiles;
        public float m_reloadTime;
        public float m_reload;
        //public List<> m_projectiles;
        public dynamic /* POINTER VOID */ m_world;
        public dynamic /* POINTER VOID */ m_destructionWorld;

        public override uint Signature => 0xb4f30148;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_maxProjectiles = br.ReadInt32();
            m_reloadTime = br.ReadSingle();
            m_reload = br.ReadSingle();
            br.Position += 4;
            des.ReadEmptyArray(br); //m_projectiles = des.ReadClassPointerArray<>(br);
            des.ReadEmptyPointer(br);/* m_world POINTER VOID */
            des.ReadEmptyPointer(br);/* m_destructionWorld POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteInt32(m_maxProjectiles);
            bw.WriteSingle(m_reloadTime);
            bw.WriteSingle(m_reload);
            bw.Position += 4;
            s.WriteVoidArray(bw); //s.WriteClassPointerArray<>(bw, m_projectiles);
            s.WriteVoidPointer(bw);/* m_world POINTER VOID */
            s.WriteVoidPointer(bw);/* m_destructionWorld POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

