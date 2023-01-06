using System.Numerics;
using System.Xml.Linq;

namespace HKX2
{
    // hkpWorldCinfo Signatire: 0xa5255445 size: 256 flags: FLAGS_NONE

    // m_gravity m_class:  Type.TYPE_VECTOR4 Type.TYPE_VOID arrSize: 0 offset: 16 flags: FLAGS_NONE enum: 
    // m_broadPhaseQuerySize m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 32 flags: FLAGS_NONE enum: 
    // m_contactRestingVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 36 flags: FLAGS_NONE enum: 
    // m_broadPhaseBorderBehaviour m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 40 flags: FLAGS_NONE enum: BroadPhaseBorderBehaviour
    // m_mtPostponeAndSortBroadPhaseBorderCallbacks m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 41 flags: FLAGS_NONE enum: 
    // m_broadPhaseWorldAabb m_class: hkAabb Type.TYPE_STRUCT Type.TYPE_VOID arrSize: 0 offset: 48 flags: FLAGS_NONE enum: 
    // m_useKdTree m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 80 flags: FLAGS_NONE enum: 
    // m_useMultipleTree m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 81 flags: FLAGS_NONE enum: 
    // m_treeUpdateType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 82 flags: FLAGS_NONE enum: TreeUpdateType
    // m_autoUpdateKdTree m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 83 flags: FLAGS_NONE enum: 
    // m_collisionTolerance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 84 flags: FLAGS_NONE enum: 
    // m_collisionFilter m_class: hkpCollisionFilter Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 88 flags: FLAGS_NONE enum: 
    // m_convexListFilter m_class: hkpConvexListFilter Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 96 flags: FLAGS_NONE enum: 
    // m_expectedMaxLinearVelocity m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 104 flags: FLAGS_NONE enum: 
    // m_sizeOfToiEventQueue m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 108 flags: FLAGS_NONE enum: 
    // m_expectedMinPsiDeltaTime m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 112 flags: FLAGS_NONE enum: 
    // m_memoryWatchDog m_class: hkWorldMemoryAvailableWatchDog Type.TYPE_POINTER Type.TYPE_STRUCT arrSize: 0 offset: 120 flags: FLAGS_NONE enum: 
    // m_broadPhaseNumMarkers m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 128 flags: FLAGS_NONE enum: 
    // m_contactPointGeneration m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 132 flags: FLAGS_NONE enum: ContactPointGeneration
    // m_allowToSkipConfirmedCallbacks m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 133 flags: FLAGS_NONE enum: 
    // m_useHybridBroadphase m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 134 flags: FLAGS_NONE enum: 
    // m_solverTau m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 136 flags: FLAGS_NONE enum: 
    // m_solverDamp m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 140 flags: FLAGS_NONE enum: 
    // m_solverIterations m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 144 flags: FLAGS_NONE enum: 
    // m_solverMicrosteps m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 148 flags: FLAGS_NONE enum: 
    // m_maxConstraintViolation m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 152 flags: FLAGS_NONE enum: 
    // m_forceCoherentConstraintOrderingInSolver m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 156 flags: FLAGS_NONE enum: 
    // m_snapCollisionToConvexEdgeThreshold m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 160 flags: FLAGS_NONE enum: 
    // m_snapCollisionToConcaveEdgeThreshold m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 164 flags: FLAGS_NONE enum: 
    // m_enableToiWeldRejection m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 168 flags: FLAGS_NONE enum: 
    // m_enableDeprecatedWelding m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 169 flags: FLAGS_NONE enum: 
    // m_iterativeLinearCastEarlyOutDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 172 flags: FLAGS_NONE enum: 
    // m_iterativeLinearCastMaxIterations m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 176 flags: FLAGS_NONE enum: 
    // m_deactivationNumInactiveFramesSelectFlag0 m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 180 flags: FLAGS_NONE enum: 
    // m_deactivationNumInactiveFramesSelectFlag1 m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 181 flags: FLAGS_NONE enum: 
    // m_deactivationIntegrateCounter m_class:  Type.TYPE_UINT8 Type.TYPE_VOID arrSize: 0 offset: 182 flags: FLAGS_NONE enum: 
    // m_shouldActivateOnRigidBodyTransformChange m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 183 flags: FLAGS_NONE enum: 
    // m_deactivationReferenceDistance m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 184 flags: FLAGS_NONE enum: 
    // m_toiCollisionResponseRotateNormal m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 188 flags: FLAGS_NONE enum: 
    // m_maxSectorsPerMidphaseCollideTask m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 192 flags: FLAGS_NONE enum: 
    // m_maxSectorsPerNarrowphaseCollideTask m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 196 flags: FLAGS_NONE enum: 
    // m_processToisMultithreaded m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 200 flags: FLAGS_NONE enum: 
    // m_maxEntriesPerToiMidphaseCollideTask m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 204 flags: FLAGS_NONE enum: 
    // m_maxEntriesPerToiNarrowphaseCollideTask m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 208 flags: FLAGS_NONE enum: 
    // m_maxNumToiCollisionPairsSinglethreaded m_class:  Type.TYPE_INT32 Type.TYPE_VOID arrSize: 0 offset: 212 flags: FLAGS_NONE enum: 
    // m_numToisTillAllowedPenetrationSimplifiedToi m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 216 flags: FLAGS_NONE enum: 
    // m_numToisTillAllowedPenetrationToi m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 220 flags: FLAGS_NONE enum: 
    // m_numToisTillAllowedPenetrationToiHigher m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 224 flags: FLAGS_NONE enum: 
    // m_numToisTillAllowedPenetrationToiForced m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 228 flags: FLAGS_NONE enum: 
    // m_enableDeactivation m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 232 flags: FLAGS_NONE enum: 
    // m_simulationType m_class:  Type.TYPE_ENUM Type.TYPE_INT8 arrSize: 0 offset: 233 flags: FLAGS_NONE enum: SimulationType
    // m_enableSimulationIslands m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 234 flags: FLAGS_NONE enum: 
    // m_minDesiredIslandSize m_class:  Type.TYPE_UINT32 Type.TYPE_VOID arrSize: 0 offset: 236 flags: FLAGS_NONE enum: 
    // m_processActionsInSingleThread m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 240 flags: FLAGS_NONE enum: 
    // m_allowIntegrationOfIslandsWithoutConstraintsInASeparateJob m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 241 flags: FLAGS_NONE enum: 
    // m_frameMarkerPsiSnap m_class:  Type.TYPE_REAL Type.TYPE_VOID arrSize: 0 offset: 244 flags: FLAGS_NONE enum: 
    // m_fireCollisionCallbacks m_class:  Type.TYPE_BOOL Type.TYPE_VOID arrSize: 0 offset: 248 flags: FLAGS_NONE enum: 
    public partial class hkpWorldCinfo : hkReferencedObject
    {
        public Vector4 m_gravity;
        public int m_broadPhaseQuerySize;
        public float m_contactRestingVelocity;
        public sbyte m_broadPhaseBorderBehaviour;
        public bool m_mtPostponeAndSortBroadPhaseBorderCallbacks;
        public hkAabb m_broadPhaseWorldAabb = new hkAabb();
        public bool m_useKdTree;
        public bool m_useMultipleTree;
        public sbyte m_treeUpdateType;
        public bool m_autoUpdateKdTree;
        public float m_collisionTolerance;
        public hkpCollisionFilter m_collisionFilter;
        public hkpConvexListFilter m_convexListFilter;
        public float m_expectedMaxLinearVelocity;
        public int m_sizeOfToiEventQueue;
        public float m_expectedMinPsiDeltaTime;
        public hkWorldMemoryAvailableWatchDog m_memoryWatchDog;
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
            m_broadPhaseWorldAabb.Read(des, br);
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
        }

        public override void ReadXml(XmlDeserializer xd, XElement xe)
        {
            base.ReadXml(xd, xe);
            m_gravity = xd.ReadVector4(xe, nameof(m_gravity));
            m_broadPhaseQuerySize = xd.ReadInt32(xe, nameof(m_broadPhaseQuerySize));
            m_contactRestingVelocity = xd.ReadSingle(xe, nameof(m_contactRestingVelocity));
            m_broadPhaseBorderBehaviour = xd.ReadFlag<BroadPhaseBorderBehaviour, sbyte>(xe, nameof(m_broadPhaseBorderBehaviour));
            m_mtPostponeAndSortBroadPhaseBorderCallbacks = xd.ReadBoolean(xe, nameof(m_mtPostponeAndSortBroadPhaseBorderCallbacks));
            m_broadPhaseWorldAabb = xd.ReadClass<hkAabb>(xe, nameof(m_broadPhaseWorldAabb));
            m_useKdTree = xd.ReadBoolean(xe, nameof(m_useKdTree));
            m_useMultipleTree = xd.ReadBoolean(xe, nameof(m_useMultipleTree));
            m_treeUpdateType = xd.ReadFlag<TreeUpdateType, sbyte>(xe, nameof(m_treeUpdateType));
            m_autoUpdateKdTree = xd.ReadBoolean(xe, nameof(m_autoUpdateKdTree));
            m_collisionTolerance = xd.ReadSingle(xe, nameof(m_collisionTolerance));
            m_collisionFilter = xd.ReadClassPointer<hkpCollisionFilter>(xe, nameof(m_collisionFilter));
            m_convexListFilter = xd.ReadClassPointer<hkpConvexListFilter>(xe, nameof(m_convexListFilter));
            m_expectedMaxLinearVelocity = xd.ReadSingle(xe, nameof(m_expectedMaxLinearVelocity));
            m_sizeOfToiEventQueue = xd.ReadInt32(xe, nameof(m_sizeOfToiEventQueue));
            m_expectedMinPsiDeltaTime = xd.ReadSingle(xe, nameof(m_expectedMinPsiDeltaTime));
            m_memoryWatchDog = xd.ReadClassPointer<hkWorldMemoryAvailableWatchDog>(xe, nameof(m_memoryWatchDog));
            m_broadPhaseNumMarkers = xd.ReadInt32(xe, nameof(m_broadPhaseNumMarkers));
            m_contactPointGeneration = xd.ReadFlag<ContactPointGeneration, sbyte>(xe, nameof(m_contactPointGeneration));
            m_allowToSkipConfirmedCallbacks = xd.ReadBoolean(xe, nameof(m_allowToSkipConfirmedCallbacks));
            m_useHybridBroadphase = xd.ReadBoolean(xe, nameof(m_useHybridBroadphase));
            m_solverTau = xd.ReadSingle(xe, nameof(m_solverTau));
            m_solverDamp = xd.ReadSingle(xe, nameof(m_solverDamp));
            m_solverIterations = xd.ReadInt32(xe, nameof(m_solverIterations));
            m_solverMicrosteps = xd.ReadInt32(xe, nameof(m_solverMicrosteps));
            m_maxConstraintViolation = xd.ReadSingle(xe, nameof(m_maxConstraintViolation));
            m_forceCoherentConstraintOrderingInSolver = xd.ReadBoolean(xe, nameof(m_forceCoherentConstraintOrderingInSolver));
            m_snapCollisionToConvexEdgeThreshold = xd.ReadSingle(xe, nameof(m_snapCollisionToConvexEdgeThreshold));
            m_snapCollisionToConcaveEdgeThreshold = xd.ReadSingle(xe, nameof(m_snapCollisionToConcaveEdgeThreshold));
            m_enableToiWeldRejection = xd.ReadBoolean(xe, nameof(m_enableToiWeldRejection));
            m_enableDeprecatedWelding = xd.ReadBoolean(xe, nameof(m_enableDeprecatedWelding));
            m_iterativeLinearCastEarlyOutDistance = xd.ReadSingle(xe, nameof(m_iterativeLinearCastEarlyOutDistance));
            m_iterativeLinearCastMaxIterations = xd.ReadInt32(xe, nameof(m_iterativeLinearCastMaxIterations));
            m_deactivationNumInactiveFramesSelectFlag0 = xd.ReadByte(xe, nameof(m_deactivationNumInactiveFramesSelectFlag0));
            m_deactivationNumInactiveFramesSelectFlag1 = xd.ReadByte(xe, nameof(m_deactivationNumInactiveFramesSelectFlag1));
            m_deactivationIntegrateCounter = xd.ReadByte(xe, nameof(m_deactivationIntegrateCounter));
            m_shouldActivateOnRigidBodyTransformChange = xd.ReadBoolean(xe, nameof(m_shouldActivateOnRigidBodyTransformChange));
            m_deactivationReferenceDistance = xd.ReadSingle(xe, nameof(m_deactivationReferenceDistance));
            m_toiCollisionResponseRotateNormal = xd.ReadSingle(xe, nameof(m_toiCollisionResponseRotateNormal));
            m_maxSectorsPerMidphaseCollideTask = xd.ReadInt32(xe, nameof(m_maxSectorsPerMidphaseCollideTask));
            m_maxSectorsPerNarrowphaseCollideTask = xd.ReadInt32(xe, nameof(m_maxSectorsPerNarrowphaseCollideTask));
            m_processToisMultithreaded = xd.ReadBoolean(xe, nameof(m_processToisMultithreaded));
            m_maxEntriesPerToiMidphaseCollideTask = xd.ReadInt32(xe, nameof(m_maxEntriesPerToiMidphaseCollideTask));
            m_maxEntriesPerToiNarrowphaseCollideTask = xd.ReadInt32(xe, nameof(m_maxEntriesPerToiNarrowphaseCollideTask));
            m_maxNumToiCollisionPairsSinglethreaded = xd.ReadInt32(xe, nameof(m_maxNumToiCollisionPairsSinglethreaded));
            m_numToisTillAllowedPenetrationSimplifiedToi = xd.ReadSingle(xe, nameof(m_numToisTillAllowedPenetrationSimplifiedToi));
            m_numToisTillAllowedPenetrationToi = xd.ReadSingle(xe, nameof(m_numToisTillAllowedPenetrationToi));
            m_numToisTillAllowedPenetrationToiHigher = xd.ReadSingle(xe, nameof(m_numToisTillAllowedPenetrationToiHigher));
            m_numToisTillAllowedPenetrationToiForced = xd.ReadSingle(xe, nameof(m_numToisTillAllowedPenetrationToiForced));
            m_enableDeactivation = xd.ReadBoolean(xe, nameof(m_enableDeactivation));
            m_simulationType = xd.ReadFlag<SimulationType, sbyte>(xe, nameof(m_simulationType));
            m_enableSimulationIslands = xd.ReadBoolean(xe, nameof(m_enableSimulationIslands));
            m_minDesiredIslandSize = xd.ReadUInt32(xe, nameof(m_minDesiredIslandSize));
            m_processActionsInSingleThread = xd.ReadBoolean(xe, nameof(m_processActionsInSingleThread));
            m_allowIntegrationOfIslandsWithoutConstraintsInASeparateJob = xd.ReadBoolean(xe, nameof(m_allowIntegrationOfIslandsWithoutConstraintsInASeparateJob));
            m_frameMarkerPsiSnap = xd.ReadSingle(xe, nameof(m_frameMarkerPsiSnap));
            m_fireCollisionCallbacks = xd.ReadBoolean(xe, nameof(m_fireCollisionCallbacks));
        }

        public override void WriteXml(XmlSerializer xs, XElement xe)
        {
            base.WriteXml(xs, xe);
            xs.WriteVector4(xe, nameof(m_gravity), m_gravity);
            xs.WriteNumber(xe, nameof(m_broadPhaseQuerySize), m_broadPhaseQuerySize);
            xs.WriteFloat(xe, nameof(m_contactRestingVelocity), m_contactRestingVelocity);
            xs.WriteEnum<BroadPhaseBorderBehaviour, sbyte>(xe, nameof(m_broadPhaseBorderBehaviour), m_broadPhaseBorderBehaviour);
            xs.WriteBoolean(xe, nameof(m_mtPostponeAndSortBroadPhaseBorderCallbacks), m_mtPostponeAndSortBroadPhaseBorderCallbacks);
            xs.WriteClass<hkAabb>(xe, nameof(m_broadPhaseWorldAabb), m_broadPhaseWorldAabb);
            xs.WriteBoolean(xe, nameof(m_useKdTree), m_useKdTree);
            xs.WriteBoolean(xe, nameof(m_useMultipleTree), m_useMultipleTree);
            xs.WriteEnum<TreeUpdateType, sbyte>(xe, nameof(m_treeUpdateType), m_treeUpdateType);
            xs.WriteBoolean(xe, nameof(m_autoUpdateKdTree), m_autoUpdateKdTree);
            xs.WriteFloat(xe, nameof(m_collisionTolerance), m_collisionTolerance);
            xs.WriteClassPointer(xe, nameof(m_collisionFilter), m_collisionFilter);
            xs.WriteClassPointer(xe, nameof(m_convexListFilter), m_convexListFilter);
            xs.WriteFloat(xe, nameof(m_expectedMaxLinearVelocity), m_expectedMaxLinearVelocity);
            xs.WriteNumber(xe, nameof(m_sizeOfToiEventQueue), m_sizeOfToiEventQueue);
            xs.WriteFloat(xe, nameof(m_expectedMinPsiDeltaTime), m_expectedMinPsiDeltaTime);
            xs.WriteClassPointer(xe, nameof(m_memoryWatchDog), m_memoryWatchDog);
            xs.WriteNumber(xe, nameof(m_broadPhaseNumMarkers), m_broadPhaseNumMarkers);
            xs.WriteEnum<ContactPointGeneration, sbyte>(xe, nameof(m_contactPointGeneration), m_contactPointGeneration);
            xs.WriteBoolean(xe, nameof(m_allowToSkipConfirmedCallbacks), m_allowToSkipConfirmedCallbacks);
            xs.WriteBoolean(xe, nameof(m_useHybridBroadphase), m_useHybridBroadphase);
            xs.WriteFloat(xe, nameof(m_solverTau), m_solverTau);
            xs.WriteFloat(xe, nameof(m_solverDamp), m_solverDamp);
            xs.WriteNumber(xe, nameof(m_solverIterations), m_solverIterations);
            xs.WriteNumber(xe, nameof(m_solverMicrosteps), m_solverMicrosteps);
            xs.WriteFloat(xe, nameof(m_maxConstraintViolation), m_maxConstraintViolation);
            xs.WriteBoolean(xe, nameof(m_forceCoherentConstraintOrderingInSolver), m_forceCoherentConstraintOrderingInSolver);
            xs.WriteFloat(xe, nameof(m_snapCollisionToConvexEdgeThreshold), m_snapCollisionToConvexEdgeThreshold);
            xs.WriteFloat(xe, nameof(m_snapCollisionToConcaveEdgeThreshold), m_snapCollisionToConcaveEdgeThreshold);
            xs.WriteBoolean(xe, nameof(m_enableToiWeldRejection), m_enableToiWeldRejection);
            xs.WriteBoolean(xe, nameof(m_enableDeprecatedWelding), m_enableDeprecatedWelding);
            xs.WriteFloat(xe, nameof(m_iterativeLinearCastEarlyOutDistance), m_iterativeLinearCastEarlyOutDistance);
            xs.WriteNumber(xe, nameof(m_iterativeLinearCastMaxIterations), m_iterativeLinearCastMaxIterations);
            xs.WriteNumber(xe, nameof(m_deactivationNumInactiveFramesSelectFlag0), m_deactivationNumInactiveFramesSelectFlag0);
            xs.WriteNumber(xe, nameof(m_deactivationNumInactiveFramesSelectFlag1), m_deactivationNumInactiveFramesSelectFlag1);
            xs.WriteNumber(xe, nameof(m_deactivationIntegrateCounter), m_deactivationIntegrateCounter);
            xs.WriteBoolean(xe, nameof(m_shouldActivateOnRigidBodyTransformChange), m_shouldActivateOnRigidBodyTransformChange);
            xs.WriteFloat(xe, nameof(m_deactivationReferenceDistance), m_deactivationReferenceDistance);
            xs.WriteFloat(xe, nameof(m_toiCollisionResponseRotateNormal), m_toiCollisionResponseRotateNormal);
            xs.WriteNumber(xe, nameof(m_maxSectorsPerMidphaseCollideTask), m_maxSectorsPerMidphaseCollideTask);
            xs.WriteNumber(xe, nameof(m_maxSectorsPerNarrowphaseCollideTask), m_maxSectorsPerNarrowphaseCollideTask);
            xs.WriteBoolean(xe, nameof(m_processToisMultithreaded), m_processToisMultithreaded);
            xs.WriteNumber(xe, nameof(m_maxEntriesPerToiMidphaseCollideTask), m_maxEntriesPerToiMidphaseCollideTask);
            xs.WriteNumber(xe, nameof(m_maxEntriesPerToiNarrowphaseCollideTask), m_maxEntriesPerToiNarrowphaseCollideTask);
            xs.WriteNumber(xe, nameof(m_maxNumToiCollisionPairsSinglethreaded), m_maxNumToiCollisionPairsSinglethreaded);
            xs.WriteFloat(xe, nameof(m_numToisTillAllowedPenetrationSimplifiedToi), m_numToisTillAllowedPenetrationSimplifiedToi);
            xs.WriteFloat(xe, nameof(m_numToisTillAllowedPenetrationToi), m_numToisTillAllowedPenetrationToi);
            xs.WriteFloat(xe, nameof(m_numToisTillAllowedPenetrationToiHigher), m_numToisTillAllowedPenetrationToiHigher);
            xs.WriteFloat(xe, nameof(m_numToisTillAllowedPenetrationToiForced), m_numToisTillAllowedPenetrationToiForced);
            xs.WriteBoolean(xe, nameof(m_enableDeactivation), m_enableDeactivation);
            xs.WriteEnum<SimulationType, sbyte>(xe, nameof(m_simulationType), m_simulationType);
            xs.WriteBoolean(xe, nameof(m_enableSimulationIslands), m_enableSimulationIslands);
            xs.WriteNumber(xe, nameof(m_minDesiredIslandSize), m_minDesiredIslandSize);
            xs.WriteBoolean(xe, nameof(m_processActionsInSingleThread), m_processActionsInSingleThread);
            xs.WriteBoolean(xe, nameof(m_allowIntegrationOfIslandsWithoutConstraintsInASeparateJob), m_allowIntegrationOfIslandsWithoutConstraintsInASeparateJob);
            xs.WriteFloat(xe, nameof(m_frameMarkerPsiSnap), m_frameMarkerPsiSnap);
            xs.WriteBoolean(xe, nameof(m_fireCollisionCallbacks), m_fireCollisionCallbacks);
        }
    }
}

