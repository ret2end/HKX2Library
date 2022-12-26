using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkbCharacterSetup Signatire: 0xe5a2a413 size: 88 flags: FLAGS_NONE

    // m_retargetingSkeletonMappers m_class: hkaSkeletonMapper Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 16 flags:  enum: 
    // m_animationSkeleton m_class: hkaSkeleton Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 32 flags:  enum: 
    // m_ragdollToAnimationSkeletonMapper m_class: hkaSkeletonMapper Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 40 flags:  enum: 
    // m_animationToRagdollSkeletonMapper m_class: hkaSkeletonMapper Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 48 flags:  enum: 
    // m_animationBindingSet m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 56 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_data m_class: hkbCharacterData Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 64 flags:  enum: 
    // m_mirroredSkeleton m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 72 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_characterPropertyIdMap m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 80 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    
    public class hkbCharacterSetup : hkReferencedObject
    {

        public List<hkaSkeletonMapper> m_retargetingSkeletonMappers;
        public hkaSkeleton /*pointer struct*/ m_animationSkeleton;
        public hkaSkeletonMapper /*pointer struct*/ m_ragdollToAnimationSkeletonMapper;
        public hkaSkeletonMapper /*pointer struct*/ m_animationToRagdollSkeletonMapper;
        public dynamic /* POINTER VOID */ m_animationBindingSet;
        public hkbCharacterData /*pointer struct*/ m_data;
        public dynamic /* POINTER VOID */ m_mirroredSkeleton;
        public dynamic /* POINTER VOID */ m_characterPropertyIdMap;

        public override uint Signature => 0xe5a2a413;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_retargetingSkeletonMappers = des.ReadClassPointerArray<hkaSkeletonMapper>(br);
            m_animationSkeleton = des.ReadClassPointer<hkaSkeleton>(br);
            m_ragdollToAnimationSkeletonMapper = des.ReadClassPointer<hkaSkeletonMapper>(br);
            m_animationToRagdollSkeletonMapper = des.ReadClassPointer<hkaSkeletonMapper>(br);
            des.ReadEmptyPointer(br);/* m_animationBindingSet POINTER VOID */
            m_data = des.ReadClassPointer<hkbCharacterData>(br);
            des.ReadEmptyPointer(br);/* m_mirroredSkeleton POINTER VOID */
            des.ReadEmptyPointer(br);/* m_characterPropertyIdMap POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointerArray<hkaSkeletonMapper>(bw, m_retargetingSkeletonMappers);
            s.WriteClassPointer(bw, m_animationSkeleton);
            s.WriteClassPointer(bw, m_ragdollToAnimationSkeletonMapper);
            s.WriteClassPointer(bw, m_animationToRagdollSkeletonMapper);
            s.WriteVoidPointer(bw);/* m_animationBindingSet POINTER VOID */
            s.WriteClassPointer(bw, m_data);
            s.WriteVoidPointer(bw);/* m_mirroredSkeleton POINTER VOID */
            s.WriteVoidPointer(bw);/* m_characterPropertyIdMap POINTER VOID */

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

