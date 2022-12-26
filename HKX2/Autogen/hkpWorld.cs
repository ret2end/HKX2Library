using System;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    // hkpWorld Signatire: 0xaadcec37 size: 1072 flags: FLAGS_NOT_SERIALIZABLE

    // m_simulation m_class: hkpSimulation Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 16 flags:  enum: 
    // m_gravity m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 32 flags:  enum: 
    // m_fixedIsland m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 48 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_fixedRigidBody m_class: hkpRigidBody Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 56 flags:  enum: 
    // m_activeSimulationIslands m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 64 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_inactiveSimulationIslands m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 80 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_dirtySimulationIslands m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 96 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_maintenanceMgr m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 112 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_memoryWatchDog m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 120 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_assertOnRunningOutOfSolverMemory m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 128 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_broadPhase m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 136 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_kdTreeManager m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 144 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_autoUpdateTree m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 152 flags:  enum: 
    // m_broadPhaseDispatcher m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 160 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_phantomBroadPhaseListener m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 168 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_entityEntityBroadPhaseListener m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 176 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_broadPhaseBorderListener m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 184 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_multithreadedSimulationJobData m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 192 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_collisionInput m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 200 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_collisionFilter m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 208 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_collisionDispatcher m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 216 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_convexListFilter m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 224 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_pendingOperations m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 232 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_pendingOperationsCount m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 240 flags:  enum: 
    // m_pendingBodyOperationsCount m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 244 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_criticalOperationsLockCount m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 248 flags:  enum: 
    // m_criticalOperationsLockCountForPhantoms m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 252 flags:  enum: 
    // m_blockExecutingPendingOperations m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 256 flags:  enum: 
    // m_criticalOperationsAllowed m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 257 flags:  enum: 
    // m_pendingOperationQueues m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 264 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_pendingOperationQueueCount m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 272 flags:  enum: 
    // m_multiThreadCheck m_class: hkMultiThreadCheck Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 276 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_processActionsInSingleThread m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 288 flags:  enum: 
    // m_allowIntegrationOfIslandsWithoutConstraintsInASeparateJob m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 289 flags:  enum: 
    // m_minDesiredIslandSize m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 292 flags:  enum: 
    // m_modifyConstraintCriticalSection m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 296 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_isLocked m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 304 flags:  enum: 
    // m_islandDirtyListCriticalSection m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 312 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_propertyMasterLock m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 320 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_wantSimulationIslands m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 328 flags:  enum: 
    // m_useHybridBroadphase m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 329 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_snapCollisionToConvexEdgeThreshold m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 332 flags:  enum: 
    // m_snapCollisionToConcaveEdgeThreshold m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 336 flags:  enum: 
    // m_enableToiWeldRejection m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 340 flags:  enum: 
    // m_wantDeactivation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 341 flags:  enum: 
    // m_shouldActivateOnRigidBodyTransformChange m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 342 flags:  enum: 
    // m_deactivationReferenceDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 344 flags:  enum: 
    // m_toiCollisionResponseRotateNormal m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 348 flags:  enum: 
    // m_maxSectorsPerMidphaseCollideTask m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 352 flags:  enum: 
    // m_maxSectorsPerNarrowphaseCollideTask m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 356 flags:  enum: 
    // m_processToisMultithreaded m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 360 flags:  enum: 
    // m_maxEntriesPerToiMidphaseCollideTask m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 364 flags:  enum: 
    // m_maxEntriesPerToiNarrowphaseCollideTask m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 368 flags:  enum: 
    // m_maxNumToiCollisionPairsSinglethreaded m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 372 flags:  enum: 
    // m_simulationType m_class:  Type.TYPE_ENUM Type.TYPE_INT32 arrSize: 0 offset: 376 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_numToisTillAllowedPenetrationSimplifiedToi m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 380 flags:  enum: 
    // m_numToisTillAllowedPenetrationToi m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 384 flags:  enum: 
    // m_numToisTillAllowedPenetrationToiHigher m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 388 flags:  enum: 
    // m_numToisTillAllowedPenetrationToiForced m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 392 flags:  enum: 
    // m_lastEntityUid m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 396 flags:  enum: 
    // m_lastIslandUid m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 400 flags:  enum: 
    // m_lastConstraintUid m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 404 flags:  enum: 
    // m_phantoms m_class: hkpPhantom Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 408 flags:  enum: 
    // m_actionListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 424 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_entityListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 440 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_phantomListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 456 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_constraintListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 472 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_worldDeletionListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 488 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_islandActivationListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 504 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_worldPostSimulationListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 520 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_worldPostIntegrateListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 536 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_worldPostCollideListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 552 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_islandPostIntegrateListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 568 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_islandPostCollideListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 584 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_contactListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 600 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_contactImpulseLimitBreachedListeners m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 616 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_worldExtensions m_class:  Type.TYPE_ARRAY Type.TYPE_POINTER arrSize: 0 offset: 632 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_violatedConstraintArray m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 648 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_broadPhaseBorder m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 656 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_destructionWorld m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 664 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_npWorld m_class:  Type.TYPE_POINTER Type.TYPE_VOID arrSize: 0 offset: 672 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 
    // m_broadPhaseExtents m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 2 offset: 1008 flags:  enum: 
    // m_broadPhaseNumMarkers m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 1040 flags:  enum: 
    // m_sizeOfToiEventQueue m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 1044 flags:  enum: 
    // m_broadPhaseQuerySize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 1048 flags:  enum: 
    // m_broadPhaseUpdateSize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 1052 flags:  enum: 
    // m_contactPointGeneration m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 1056 flags: NOT_OWNED|ALIGN_16|ALIGN_8|FLAGS_NONE enum: 

    public class hkpWorld : hkReferencedObject
    {

        public hkpSimulation /*pointer struct*/ m_simulation;
        public Vector4 m_gravity;
        public dynamic /* POINTER VOID */ m_fixedIsland;
        public hkpRigidBody /*pointer struct*/ m_fixedRigidBody;
        //public List<> m_activeSimulationIslands;
        //public List<> m_inactiveSimulationIslands;
        //public List<> m_dirtySimulationIslands;
        public dynamic /* POINTER VOID */ m_maintenanceMgr;
        public dynamic /* POINTER VOID */ m_memoryWatchDog;
        public bool m_assertOnRunningOutOfSolverMemory;
        public dynamic /* POINTER VOID */ m_broadPhase;
        public dynamic /* POINTER VOID */ m_kdTreeManager;
        public bool m_autoUpdateTree;
        public dynamic /* POINTER VOID */ m_broadPhaseDispatcher;
        public dynamic /* POINTER VOID */ m_phantomBroadPhaseListener;
        public dynamic /* POINTER VOID */ m_entityEntityBroadPhaseListener;
        public dynamic /* POINTER VOID */ m_broadPhaseBorderListener;
        public dynamic /* POINTER VOID */ m_multithreadedSimulationJobData;
        public dynamic /* POINTER VOID */ m_collisionInput;
        public dynamic /* POINTER VOID */ m_collisionFilter;
        public dynamic /* POINTER VOID */ m_collisionDispatcher;
        public dynamic /* POINTER VOID */ m_convexListFilter;
        public dynamic /* POINTER VOID */ m_pendingOperations;
        public int m_pendingOperationsCount;
        public int m_pendingBodyOperationsCount;
        public int m_criticalOperationsLockCount;
        public int m_criticalOperationsLockCountForPhantoms;
        public bool m_blockExecutingPendingOperations;
        public bool m_criticalOperationsAllowed;
        public dynamic /* POINTER VOID */ m_pendingOperationQueues;
        public int m_pendingOperationQueueCount;
        public hkMultiThreadCheck/*struct void*/ m_multiThreadCheck;
        public bool m_processActionsInSingleThread;
        public bool m_allowIntegrationOfIslandsWithoutConstraintsInASeparateJob;
        public uint m_minDesiredIslandSize;
        public dynamic /* POINTER VOID */ m_modifyConstraintCriticalSection;
        public int m_isLocked;
        public dynamic /* POINTER VOID */ m_islandDirtyListCriticalSection;
        public dynamic /* POINTER VOID */ m_propertyMasterLock;
        public bool m_wantSimulationIslands;
        public bool m_useHybridBroadphase;
        public float m_snapCollisionToConvexEdgeThreshold;
        public float m_snapCollisionToConcaveEdgeThreshold;
        public bool m_enableToiWeldRejection;
        public bool m_wantDeactivation;
        public bool m_shouldActivateOnRigidBodyTransformChange;
        public float m_deactivationReferenceDistance;
        public float m_toiCollisionResponseRotateNormal;
        public int m_maxSectorsPerMidphaseCollideTask;
        public int m_maxSectorsPerNarrowphaseCollideTask;
        public bool m_processToisMultithreaded;
        public int m_maxEntriesPerToiMidphaseCollideTask;
        public int m_maxEntriesPerToiNarrowphaseCollideTask;
        public int m_maxNumToiCollisionPairsSinglethreaded;
        public int m_simulationType;
        public float m_numToisTillAllowedPenetrationSimplifiedToi;
        public float m_numToisTillAllowedPenetrationToi;
        public float m_numToisTillAllowedPenetrationToiHigher;
        public float m_numToisTillAllowedPenetrationToiForced;
        public uint m_lastEntityUid;
        public uint m_lastIslandUid;
        public uint m_lastConstraintUid;
        public List<hkpPhantom> m_phantoms;
        //public List<> m_actionListeners;
        //public List<> m_entityListeners;
        //public List<> m_phantomListeners;
        //public List<> m_constraintListeners;
        //public List<> m_worldDeletionListeners;
        //public List<> m_islandActivationListeners;
        //public List<> m_worldPostSimulationListeners;
        //public List<> m_worldPostIntegrateListeners;
        //public List<> m_worldPostCollideListeners;
        //public List<> m_islandPostIntegrateListeners;
        //public List<> m_islandPostCollideListeners;
        //public List<> m_contactListeners;
        //public List<> m_contactImpulseLimitBreachedListeners;
        //public List<> m_worldExtensions;
        public dynamic /* POINTER VOID */ m_violatedConstraintArray;
        public dynamic /* POINTER VOID */ m_broadPhaseBorder;
        public dynamic /* POINTER VOID */ m_destructionWorld;
        public dynamic /* POINTER VOID */ m_npWorld;
        public List<Vector4> m_broadPhaseExtents;
        public int m_broadPhaseNumMarkers;
        public int m_sizeOfToiEventQueue;
        public int m_broadPhaseQuerySize;
        public int m_broadPhaseUpdateSize;
        public sbyte m_contactPointGeneration;

        public override uint Signature => 0xaadcec37;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {

            base.Read(des, br);
            m_simulation = des.ReadClassPointer<hkpSimulation>(br);
            br.Position += 8;
            m_gravity = br.ReadVector4();
            des.ReadEmptyPointer(br);/* m_fixedIsland POINTER VOID */
            m_fixedRigidBody = des.ReadClassPointer<hkpRigidBody>(br);
            des.ReadEmptyArray(br);//m_activeSimulationIslands = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_inactiveSimulationIslands = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_dirtySimulationIslands = des.ReadClassPointerArray<>(br);
            des.ReadEmptyPointer(br);/* m_maintenanceMgr POINTER VOID */
            des.ReadEmptyPointer(br);/* m_memoryWatchDog POINTER VOID */
            m_assertOnRunningOutOfSolverMemory = br.ReadBoolean();
            br.Position += 7;
            des.ReadEmptyPointer(br);/* m_broadPhase POINTER VOID */
            des.ReadEmptyPointer(br);/* m_kdTreeManager POINTER VOID */
            m_autoUpdateTree = br.ReadBoolean();
            br.Position += 7;
            des.ReadEmptyPointer(br);/* m_broadPhaseDispatcher POINTER VOID */
            des.ReadEmptyPointer(br);/* m_phantomBroadPhaseListener POINTER VOID */
            des.ReadEmptyPointer(br);/* m_entityEntityBroadPhaseListener POINTER VOID */
            des.ReadEmptyPointer(br);/* m_broadPhaseBorderListener POINTER VOID */
            des.ReadEmptyPointer(br);/* m_multithreadedSimulationJobData POINTER VOID */
            des.ReadEmptyPointer(br);/* m_collisionInput POINTER VOID */
            des.ReadEmptyPointer(br);/* m_collisionFilter POINTER VOID */
            des.ReadEmptyPointer(br);/* m_collisionDispatcher POINTER VOID */
            des.ReadEmptyPointer(br);/* m_convexListFilter POINTER VOID */
            des.ReadEmptyPointer(br);/* m_pendingOperations POINTER VOID */
            m_pendingOperationsCount = br.ReadInt32();
            m_pendingBodyOperationsCount = br.ReadInt32();
            m_criticalOperationsLockCount = br.ReadInt32();
            m_criticalOperationsLockCountForPhantoms = br.ReadInt32();
            m_blockExecutingPendingOperations = br.ReadBoolean();
            m_criticalOperationsAllowed = br.ReadBoolean();
            br.Position += 6;
            des.ReadEmptyPointer(br);/* m_pendingOperationQueues POINTER VOID */
            m_pendingOperationQueueCount = br.ReadInt32();
            m_multiThreadCheck = new hkMultiThreadCheck();
            m_multiThreadCheck.Read(des, br);
            m_processActionsInSingleThread = br.ReadBoolean();
            m_allowIntegrationOfIslandsWithoutConstraintsInASeparateJob = br.ReadBoolean();
            br.Position += 2;
            m_minDesiredIslandSize = br.ReadUInt32();
            des.ReadEmptyPointer(br);/* m_modifyConstraintCriticalSection POINTER VOID */
            m_isLocked = br.ReadInt32();
            br.Position += 4;
            des.ReadEmptyPointer(br);/* m_islandDirtyListCriticalSection POINTER VOID */
            des.ReadEmptyPointer(br);/* m_propertyMasterLock POINTER VOID */
            m_wantSimulationIslands = br.ReadBoolean();
            m_useHybridBroadphase = br.ReadBoolean();
            br.Position += 2;
            m_snapCollisionToConvexEdgeThreshold = br.ReadSingle();
            m_snapCollisionToConcaveEdgeThreshold = br.ReadSingle();
            m_enableToiWeldRejection = br.ReadBoolean();
            m_wantDeactivation = br.ReadBoolean();
            m_shouldActivateOnRigidBodyTransformChange = br.ReadBoolean();
            br.Position += 1;
            m_deactivationReferenceDistance = br.ReadSingle();
            m_toiCollisionResponseRotateNormal = br.ReadSingle();
            m_maxSectorsPerMidphaseCollideTask = br.ReadInt32();
            m_maxSectorsPerNarrowphaseCollideTask = br.ReadInt32();
            m_processToisMultithreaded = br.ReadBoolean();
            br.Position += 3;
            m_maxEntriesPerToiMidphaseCollideTask = br.ReadInt32();
            m_maxEntriesPerToiNarrowphaseCollideTask = br.ReadInt32();
            m_maxNumToiCollisionPairsSinglethreaded = br.ReadInt32();
            m_simulationType = br.ReadInt32();
            m_numToisTillAllowedPenetrationSimplifiedToi = br.ReadSingle();
            m_numToisTillAllowedPenetrationToi = br.ReadSingle();
            m_numToisTillAllowedPenetrationToiHigher = br.ReadSingle();
            m_numToisTillAllowedPenetrationToiForced = br.ReadSingle();
            m_lastEntityUid = br.ReadUInt32();
            m_lastIslandUid = br.ReadUInt32();
            m_lastConstraintUid = br.ReadUInt32();
            m_phantoms = des.ReadClassPointerArray<hkpPhantom>(br);
            des.ReadEmptyArray(br);//m_actionListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_entityListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_phantomListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_constraintListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_worldDeletionListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_islandActivationListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_worldPostSimulationListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_worldPostIntegrateListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_worldPostCollideListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_islandPostIntegrateListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_islandPostCollideListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_contactListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_contactImpulseLimitBreachedListeners = des.ReadClassPointerArray<>(br);
            des.ReadEmptyArray(br);//m_worldExtensions = des.ReadClassPointerArray<>(br);
            des.ReadEmptyPointer(br);/* m_violatedConstraintArray POINTER VOID */
            des.ReadEmptyPointer(br);/* m_broadPhaseBorder POINTER VOID */
            des.ReadEmptyPointer(br);/* m_destructionWorld POINTER VOID */
            des.ReadEmptyPointer(br);/* m_npWorld POINTER VOID */
            br.Position += 328;
            m_broadPhaseExtents = des.ReadVector4CStyleArray(br, 2);
            m_broadPhaseNumMarkers = br.ReadInt32();
            m_sizeOfToiEventQueue = br.ReadInt32();
            m_broadPhaseQuerySize = br.ReadInt32();
            m_broadPhaseUpdateSize = br.ReadInt32();
            m_contactPointGeneration = br.ReadSByte();
            br.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {

            base.Write(s, bw);
            s.WriteClassPointer(bw, m_simulation);
            bw.Position += 8;
            bw.WriteVector4(m_gravity);
            s.WriteVoidPointer(bw);/* m_fixedIsland POINTER VOID */
            s.WriteClassPointer(bw, m_fixedRigidBody);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_activeSimulationIslands);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_inactiveSimulationIslands);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_dirtySimulationIslands);
            s.WriteVoidPointer(bw);/* m_maintenanceMgr POINTER VOID */
            s.WriteVoidPointer(bw);/* m_memoryWatchDog POINTER VOID */
            bw.WriteBoolean(m_assertOnRunningOutOfSolverMemory);
            bw.Position += 7;
            s.WriteVoidPointer(bw);/* m_broadPhase POINTER VOID */
            s.WriteVoidPointer(bw);/* m_kdTreeManager POINTER VOID */
            bw.WriteBoolean(m_autoUpdateTree);
            bw.Position += 7;
            s.WriteVoidPointer(bw);/* m_broadPhaseDispatcher POINTER VOID */
            s.WriteVoidPointer(bw);/* m_phantomBroadPhaseListener POINTER VOID */
            s.WriteVoidPointer(bw);/* m_entityEntityBroadPhaseListener POINTER VOID */
            s.WriteVoidPointer(bw);/* m_broadPhaseBorderListener POINTER VOID */
            s.WriteVoidPointer(bw);/* m_multithreadedSimulationJobData POINTER VOID */
            s.WriteVoidPointer(bw);/* m_collisionInput POINTER VOID */
            s.WriteVoidPointer(bw);/* m_collisionFilter POINTER VOID */
            s.WriteVoidPointer(bw);/* m_collisionDispatcher POINTER VOID */
            s.WriteVoidPointer(bw);/* m_convexListFilter POINTER VOID */
            s.WriteVoidPointer(bw);/* m_pendingOperations POINTER VOID */
            bw.WriteInt32(m_pendingOperationsCount);
            bw.WriteInt32(m_pendingBodyOperationsCount);
            bw.WriteInt32(m_criticalOperationsLockCount);
            bw.WriteInt32(m_criticalOperationsLockCountForPhantoms);
            bw.WriteBoolean(m_blockExecutingPendingOperations);
            bw.WriteBoolean(m_criticalOperationsAllowed);
            bw.Position += 6;
            s.WriteVoidPointer(bw);/* m_pendingOperationQueues POINTER VOID */
            bw.WriteInt32(m_pendingOperationQueueCount);
            m_multiThreadCheck.Write(s, bw);
            bw.WriteBoolean(m_processActionsInSingleThread);
            bw.WriteBoolean(m_allowIntegrationOfIslandsWithoutConstraintsInASeparateJob);
            bw.Position += 2;
            bw.WriteUInt32(m_minDesiredIslandSize);
            s.WriteVoidPointer(bw);/* m_modifyConstraintCriticalSection POINTER VOID */
            bw.WriteInt32(m_isLocked);
            bw.Position += 4;
            s.WriteVoidPointer(bw);/* m_islandDirtyListCriticalSection POINTER VOID */
            s.WriteVoidPointer(bw);/* m_propertyMasterLock POINTER VOID */
            bw.WriteBoolean(m_wantSimulationIslands);
            bw.WriteBoolean(m_useHybridBroadphase);
            bw.Position += 2;
            bw.WriteSingle(m_snapCollisionToConvexEdgeThreshold);
            bw.WriteSingle(m_snapCollisionToConcaveEdgeThreshold);
            bw.WriteBoolean(m_enableToiWeldRejection);
            bw.WriteBoolean(m_wantDeactivation);
            bw.WriteBoolean(m_shouldActivateOnRigidBodyTransformChange);
            bw.Position += 1;
            bw.WriteSingle(m_deactivationReferenceDistance);
            bw.WriteSingle(m_toiCollisionResponseRotateNormal);
            bw.WriteInt32(m_maxSectorsPerMidphaseCollideTask);
            bw.WriteInt32(m_maxSectorsPerNarrowphaseCollideTask);
            bw.WriteBoolean(m_processToisMultithreaded);
            bw.Position += 3;
            bw.WriteInt32(m_maxEntriesPerToiMidphaseCollideTask);
            bw.WriteInt32(m_maxEntriesPerToiNarrowphaseCollideTask);
            bw.WriteInt32(m_maxNumToiCollisionPairsSinglethreaded);
            s.WriteInt32(bw, m_simulationType);
            bw.WriteSingle(m_numToisTillAllowedPenetrationSimplifiedToi);
            bw.WriteSingle(m_numToisTillAllowedPenetrationToi);
            bw.WriteSingle(m_numToisTillAllowedPenetrationToiHigher);
            bw.WriteSingle(m_numToisTillAllowedPenetrationToiForced);
            bw.WriteUInt32(m_lastEntityUid);
            bw.WriteUInt32(m_lastIslandUid);
            bw.WriteUInt32(m_lastConstraintUid);
            s.WriteClassPointerArray<hkpPhantom>(bw, m_phantoms);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_actionListeners);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_entityListeners);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_phantomListeners);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_constraintListeners);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_worldDeletionListeners);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_islandActivationListeners);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_worldPostSimulationListeners);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_worldPostIntegrateListeners);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_worldPostCollideListeners);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_islandPostIntegrateListeners);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_islandPostCollideListeners);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_contactListeners);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_contactImpulseLimitBreachedListeners);
            s.WriteVoidArray(bw);//s.WriteClassPointerArray<>(bw, m_worldExtensions);
            s.WriteVoidPointer(bw);/* m_violatedConstraintArray POINTER VOID */
            s.WriteVoidPointer(bw);/* m_broadPhaseBorder POINTER VOID */
            s.WriteVoidPointer(bw);/* m_destructionWorld POINTER VOID */
            s.WriteVoidPointer(bw);/* m_npWorld POINTER VOID */
            bw.Position += 328;
            s.WriteVector4CStyleArray(bw, m_broadPhaseExtents);//bw.WriteVector4(m_broadPhaseExtents);
            bw.WriteInt32(m_broadPhaseNumMarkers);
            bw.WriteInt32(m_sizeOfToiEventQueue);
            bw.WriteInt32(m_broadPhaseQuerySize);
            bw.WriteInt32(m_broadPhaseUpdateSize);
            s.WriteSByte(bw, m_contactPointGeneration);
            bw.Position += 15;

            // throw new NotImplementedException("code generated. check first");
        }
    }
}

