using System.Collections.Generic;

namespace HKX2
{
    public class hkpVehicleManager : hkReferencedObject
    {
        public List<hkpVehicleInstance> m_registeredVehicles;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_registeredVehicles = des.ReadClassPointerArray<hkpVehicleInstance>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointerArray(bw, m_registeredVehicles);
        }
    }
}