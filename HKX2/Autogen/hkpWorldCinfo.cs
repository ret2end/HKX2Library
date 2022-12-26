using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpWorldCinfo Signatire: 0xa5255445 size: 256 flags: FLAGS_NONE

    // m_gravity m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags:  enum: 
    // m_broadPhaseQuerySize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_contactRestingVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags:  enum: 
    // m_broadPhaseBorderBehaviour m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 40 flags:  enum: BroadPhaseBorderBehaviour
    // m_mtPostponeAndSortBroadPhaseBorderCallbacks m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 41 flags:  enum: 
    // m_broadPhaseWorldAabb m_class: hkAabb Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 48 flags:  enum: 
    // m_useKdTree m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 80 flags:  enum: 
    // m_useMultipleTree m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 81 flags:  enum: 
    // m_treeUpdateType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 82 flags:  enum: TreeUpdateType
    // m_autoUpdateKdTree m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 83 flags:  enum: 
    // m_collisionTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags:  enum: 
    // m_collisionFilter m_class: hkpCollisionFilter Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 88 flags:  enum: 
    // m_convexListFilter m_class: hkpConvexListFilter Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 96 flags:  enum: 
    // m_expectedMaxLinearVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags:  enum: 
    // m_sizeOfToiEventQueue m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 108 flags:  enum: 
    // m_expectedMinPsiDeltaTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags:  enum: 
    // m_memoryWatchDog m_class: hkWorldMemoryAvailableWatchDog Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 120 flags:  enum: 
    // m_broadPhaseNumMarkers m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 128 flags:  enum: 
    // m_contactPointGeneration m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 132 flags:  enum: ContactPointGeneration
    // m_allowToSkipConfirmedCallbacks m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 133 flags:  enum: 
    // m_useHybridBroadphase m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 134 flags:  enum: 
    // m_solverTau m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 136 flags:  enum: 
    // m_solverDamp m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 140 flags:  enum: 
    // m_solverIterations m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 144 flags:  enum: 
    // m_solverMicrosteps m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 148 flags:  enum: 
    // m_maxConstraintViolation m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 152 flags:  enum: 
    // m_forceCoherentConstraintOrderingInSolver m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 156 flags:  enum: 
    // m_snapCollisionToConvexEdgeThreshold m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 160 flags:  enum: 
    // m_snapCollisionToConcaveEdgeThreshold m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 164 flags:  enum: 
    // m_enableToiWeldRejection m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 168 flags:  enum: 
    // m_enableDeprecatedWelding m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 169 flags:  enum: 
    // m_iterativeLinearCastEarlyOutDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 172 flags:  enum: 
    // m_iterativeLinearCastMaxIterations m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 176 flags:  enum: 
    // m_deactivationNumInactiveFramesSelectFlag0 m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 180 flags:  enum: 
    // m_deactivationNumInactiveFramesSelectFlag1 m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 181 flags:  enum: 
    // m_deactivationIntegrateCounter m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 182 flags:  enum: 
    // m_shouldActivateOnRigidBodyTransformChange m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 183 flags:  enum: 
    // m_deactivationReferenceDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 184 flags:  enum: 
    // m_toiCollisionResponseRotateNormal m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 188 flags:  enum: 
    // m_maxSectorsPerMidphaseCollideTask m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 192 flags:  enum: 
    // m_maxSectorsPerNarrowphaseCollideTask m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 196 flags:  enum: 
    // m_processToisMultithreaded m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 200 flags:  enum: 
    // m_maxEntriesPerToiMidphaseCollideTask m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 204 flags:  enum: 
    // m_maxEntriesPerToiNarrowphaseCollideTask m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 208 flags:  enum: 
    // m_maxNumToiCollisionPairsSinglethreaded m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 212 flags:  enum: 
    // m_numToisTillAllowedPenetrationSimplifiedToi m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 216 flags:  enum: 
    // m_numToisTillAllowedPenetrationToi m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 220 flags:  enum: 
    // m_numToisTillAllowedPenetrationToiHigher m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 224 flags:  enum: 
    // m_numToisTillAllowedPenetrationToiForced m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 228 flags:  enum: 
    // m_enableDeactivation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 232 flags:  enum: 
    // m_simulationType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 233 flags:  enum: SimulationType
    // m_enableSimulationIslands m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 234 flags:  enum: 
    // m_minDesiredIslandSize m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 236 flags:  enum: 
    // m_processActionsInSingleThread m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 240 flags:  enum: 
    // m_allowIntegrationOfIslandsWithoutConstraintsInASeparateJob m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 241 flags:  enum: 
    // m_frameMarkerPsiSnap m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 244 flags:  enum: 
    // m_fireCollisionCallbacks m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 248 flags:  enum: 
    
    public class hkpWorldCinfo : hkReferencedObject
    {

        public Vector4 m_gravity;
        public int m_broadPhaseQuerySize;
        public float m_contactRestingVelocity;
        public sbyte m_broadPhaseBorderBehaviour;
        public bool m_mtPostponeAndSortBroadPhaseBorderCallbacks;
        public hkAabb/*struct void*/ m_broadPhaseWorldAabb;
        public bool m_useKdTree;
        public bool m_useMultipleTree;
        public sbyte m_treeUpdateType;
        public bool m_autoUpdateKdTree;
        public float m_collisionTolerance;
        public hkpCollisionFilter /*pointer struct*/ m_collisionFilter;
        public hkpConvexListFilter /*pointer struct*/ m_convexListFilter;
        public float m_expectedMaxLinearVelocity;
        public int m_sizeOfToiEventQueue;
        public float m_expectedMinPsiDeltaTime;
        public hkWorldMemoryAvailableWatchDog /*pointer struct*/ m_memoryWatchDog;
        public int m_broadPhaseNumMarkers;
        public sbyte m_contactPointGeneration;
        public bool m_allowToSkipConfirmedCallbacks;
        public bool m_useHybridBroadphase;
        public float m_solverTau;
        public float m_solverDamp;
        public int m_solverIterations;
        public int m_solverMicrosteps;
        public float m_maxConstraintViolation;
        public bool m_forceCoherentConstraintOrderingInSolver;
        public float m_snapCollisionToConvexEdgeThreshold;
        public float m_snapCollisionToConcaveEdgeThreshold;
        public bool m_enableToiWeldRejection;
        public bool m_enableDeprecatedWelding;
        public float m_iterativeLinearCastEarlyOutDistance;
        public int m_iterativeLinearCastMaxIterations;
        public byte m_deactivationNumInactiveFramesSelectFlag0;
        public byte m_deactivationNumInactiveFramesSelectFlag1;
        public byte m_deactivationIntegrateCounter;
        public bool m_shouldActivateOnRigidBodyTransformChange;
        public float m_deactivationReferenceDistance;
        public float m_toiCollisionResponseRotateNormal;
        public int m_maxSectorsPerMidphaseCollideTask;
        public int m_maxSectorsPerNarrowphaseCollideTask;
        public bool m_processToisMultithreaded;
        public int m_maxEntriesPerToiMidphaseCollideTask;
        public int m_maxEntriesPerToiNarrowphaseCollideTask;
        public int m_maxNumToiCollisionPairsSinglethreaded;
        public float m_numToisTillAllowedPenetrationSimplifiedToi;
        public float m_numToisTillAllowedPenetrationToi;
        public float m_numToisTillAllowedPenetrationToiHigher;
        public float m_numToisTillAllowedPenetrationToiForced;
        public bool m_enableDeactivation;
        public sbyte m_simulationType;
        public bool m_enableSimulationIslands;
        public uint m_minDesiredIslandSize;
        public bool m_processActionsInSingleThread;
        public bool m_allowIntegrationOfIslandsWithoutConstraintsInASeparateJob;
        public float m_frameMarkerPsiSnap;
        public bool m_fireCollisionCallbacks;

        public override uint Signature => 0xa5255445;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_gravity = br.ReadVector4();
            m_broadPhaseQuerySize = br.ReadInt32();
            m_contactRestingVelocity = br.ReadSingle();
            m_broadPhaseBorderBehaviour = br.ReadSByte();
            m_mtPostponeAndSortBroadPhaseBorderCallbacks = br.ReadBoolean();
            br.Position += 6;
            m_broadPhaseWorldAabb = new hkAabb();
            m_broadPhaseWorldAabb.Read(des,br);
            m_useKdTree = br.ReadBoolean();
            m_useMultipleTree = br.ReadBoolean();
            m_treeUpdateType = br.ReadSByte();
            m_autoUpdateKdTree = br.ReadBoolean();
            m_collisionTolerance = br.ReadSingle();
            m_collisionFilter = des.ReadClassPointer<hkpCollisionFilter>(br);
            m_convexListFilter = des.ReadClassPointer<hkpConvexListFilter>(br);
            m_expectedMaxLinearVelocity = br.ReadSingle();
            m_sizeOfToiEventQueue = br.ReadInt32();
            m_expectedMinPsiDeltaTime = br.ReadSingle();
            br.Position += 4;
            m_memoryWatchDog = des.ReadClassPointer<hkWorldMemoryAvailableWatchDog>(br);
            m_broadPhaseNumMarkers = br.ReadInt32();
            m_contactPointGeneration = br.ReadSByte();
            m_allowToSkipConfirmedCallbacks = br.ReadBoolean();
            m_useHybridBroadphase = br.ReadBoolean();
            br.Position += 1;
            m_solverTau = br.ReadSingle();
            m_solverDamp = br.ReadSingle();
            m_solverIterations = br.ReadInt32();
            m_solverMicrosteps = br.ReadInt32();
            m_maxConstraintViolation = br.ReadSingle();
            m_forceCoherentConstraintOrderingInSolver = br.ReadBoolean();
            br.Position += 3;
            m_snapCollisionToConvexEdgeThreshold = br.ReadSingle();
            m_snapCollisionToConcaveEdgeThreshold = br.ReadSingle();
            m_enableToiWeldRejection = br.ReadBoolean();
            m_enableDeprecatedWelding = br.ReadBoolean();
            br.Position += 2;
            m_iterativeLinearCastEarlyOutDistance = br.ReadSingle();
            m_iterativeLinearCastMaxIterations = br.ReadInt32();
            m_deactivationNumInactiveFramesSelectFlag0 = br.ReadByte();
            m_deactivationNumInactiveFramesSelectFlag1 = br.ReadByte();
            m_deactivationIntegrateCounter = br.ReadByte();
            m_shouldActivateOnRigidBodyTransformChange = br.ReadBoolean();
            m_deactivationReferenceDistance = br.ReadSingle();
            m_toiCollisionResponseRotateNormal = br.ReadSingle();
            m_maxSectorsPerMidphaseCollideTask = br.ReadInt32();
            m_maxSectorsPerNarrowphaseCollideTask = br.ReadInt32();
            m_processToisMultithreaded = br.ReadBoolean();
            br.Position += 3;
            m_maxEntriesPerToiMidphaseCollideTask = br.ReadInt32();
            m_maxEntriesPerToiNarrowphaseCollideTask = br.ReadInt32();
            m_maxNumToiCollisionPairsSinglethreaded = br.ReadInt32();
            m_numToisTillAllowedPenetrationSimplifiedToi = br.ReadSingle();
            m_numToisTillAllowedPenetrationToi = br.ReadSingle();
            m_numToisTillAllowedPenetrationToiHigher = br.ReadSingle();
            m_numToisTillAllowedPenetrationToiForced = br.ReadSingle();
            m_enableDeactivation = br.ReadBoolean();
            m_simulationType = br.ReadSByte();
            m_enableSimulationIslands = br.ReadBoolean();
            br.Position += 1;
            m_minDesiredIslandSize = br.ReadUInt32();
            m_processActionsInSingleThread = br.ReadBoolean();
            m_allowIntegrationOfIslandsWithoutConstraintsInASeparateJob = br.ReadBoolean();
            br.Position += 2;
            m_frameMarkerPsiSnap = br.ReadSingle();
            m_fireCollisionCallbacks = br.ReadBoolean();
            br.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            bw.WriteVector4(m_gravity);
            bw.WriteInt32(m_broadPhaseQuerySize);
            bw.WriteSingle(m_contactRestingVelocity);
            s.WriteSByte(bw, m_broadPhaseBorderBehaviour);
            bw.WriteBoolean(m_mtPostponeAndSortBroadPhaseBorderCallbacks);
            bw.Position += 6;
            m_broadPhaseWorldAabb.Write(s, bw);
            bw.WriteBoolean(m_useKdTree);
            bw.WriteBoolean(m_useMultipleTree);
            s.WriteSByte(bw, m_treeUpdateType);
            bw.WriteBoolean(m_autoUpdateKdTree);
            bw.WriteSingle(m_collisionTolerance);
            s.WriteClassPointer(bw, m_collisionFilter);
            s.WriteClassPointer(bw, m_convexListFilter);
            bw.WriteSingle(m_expectedMaxLinearVelocity);
            bw.WriteInt32(m_sizeOfToiEventQueue);
            bw.WriteSingle(m_expectedMinPsiDeltaTime);
            bw.Position += 4;
            s.WriteClassPointer(bw, m_memoryWatchDog);
            bw.WriteInt32(m_broadPhaseNumMarkers);
            s.WriteSByte(bw, m_contactPointGeneration);
            bw.WriteBoolean(m_allowToSkipConfirmedCallbacks);
            bw.WriteBoolean(m_useHybridBroadphase);
            bw.Position += 1;
            bw.WriteSingle(m_solverTau);
            bw.WriteSingle(m_solverDamp);
            bw.WriteInt32(m_solverIterations);
            bw.WriteInt32(m_solverMicrosteps);
            bw.WriteSingle(m_maxConstraintViolation);
            bw.WriteBoolean(m_forceCoherentConstraintOrderingInSolver);
            bw.Position += 3;
            bw.WriteSingle(m_snapCollisionToConvexEdgeThreshold);
            bw.WriteSingle(m_snapCollisionToConcaveEdgeThreshold);
            bw.WriteBoolean(m_enableToiWeldRejection);
            bw.WriteBoolean(m_enableDeprecatedWelding);
            bw.Position += 2;
            bw.WriteSingle(m_iterativeLinearCastEarlyOutDistance);
            bw.WriteInt32(m_iterativeLinearCastMaxIterations);
            bw.WriteByte(m_deactivationNumInactiveFramesSelectFlag0);
            bw.WriteByte(m_deactivationNumInactiveFramesSelectFlag1);
            bw.WriteByte(m_deactivationIntegrateCounter);
            bw.WriteBoolean(m_shouldActivateOnRigidBodyTransformChange);
            bw.WriteSingle(m_deactivationReferenceDistance);
            bw.WriteSingle(m_toiCollisionResponseRotateNormal);
            bw.WriteInt32(m_maxSectorsPerMidphaseCollideTask);
            bw.WriteInt32(m_maxSectorsPerNarrowphaseCollideTask);
            bw.WriteBoolean(m_processToisMultithreaded);
            bw.Position += 3;
            bw.WriteInt32(m_maxEntriesPerToiMidphaseCollideTask);
            bw.WriteInt32(m_maxEntriesPerToiNarrowphaseCollideTask);
            bw.WriteInt32(m_maxNumToiCollisionPairsSinglethreaded);
            bw.WriteSingle(m_numToisTillAllowedPenetrationSimplifiedToi);
            bw.WriteSingle(m_numToisTillAllowedPenetrationToi);
            bw.WriteSingle(m_numToisTillAllowedPenetrationToiHigher);
            bw.WriteSingle(m_numToisTillAllowedPenetrationToiForced);
            bw.WriteBoolean(m_enableDeactivation);
            s.WriteSByte(bw, m_simulationType);
            bw.WriteBoolean(m_enableSimulationIslands);
            bw.Position += 1;
            bw.WriteUInt32(m_minDesiredIslandSize);
            bw.WriteBoolean(m_processActionsInSingleThread);
            bw.WriteBoolean(m_allowIntegrationOfIslandsWithoutConstraintsInASeparateJob);
            bw.Position += 2;
            bw.WriteSingle(m_frameMarkerPsiSnap);
            bw.WriteBoolean(m_fireCollisionCallbacks);
            bw.Position += 7;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

