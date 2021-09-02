using System.Collections.Generic;

namespace HKX2
{
    public class hkpVehicleInstance : hkpUnaryAction
    {
        public hkpVehicleAerodynamics m_aerodynamics;
        public hkpVehicleBrake m_brake;
        public float m_clutchDelayCountdown;
        public sbyte m_currentGear;

        public hkpVehicleData m_data;
        public bool m_delayed;
        public hkpVehicleDriverInputStatus m_deviceStatus;
        public hkpVehicleDriverInput m_driverInput;
        public hkpVehicleEngine m_engine;
        public List<bool> m_isFixed;
        public bool m_isReversing;
        public float m_mainSteeringAngle;
        public float m_mainSteeringAngleAssumingNoReduction;
        public float m_rpm;
        public hkpVehicleSteering m_steering;
        public hkpVehicleSuspension m_suspension;
        public float m_torque;
        public hkpVehicleTransmission m_transmission;
        public bool m_tryingToReverse;
        public hkpTyremarksInfo m_tyreMarks;
        public hkpVehicleSimulation m_vehicleSimulation;
        public hkpVehicleVelocityDamper m_velocityDamper;
        public hkpVehicleWheelCollide m_wheelCollide;
        public List<hkpVehicleInstanceWheelInfo> m_wheelsInfo;
        public List<float> m_wheelsSteeringAngle;
        public float m_wheelsTimeSinceMaxPedalInput;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_data = des.ReadClassPointer<hkpVehicleData>(br);
            m_driverInput = des.ReadClassPointer<hkpVehicleDriverInput>(br);
            m_steering = des.ReadClassPointer<hkpVehicleSteering>(br);
            m_engine = des.ReadClassPointer<hkpVehicleEngine>(br);
            m_transmission = des.ReadClassPointer<hkpVehicleTransmission>(br);
            m_brake = des.ReadClassPointer<hkpVehicleBrake>(br);
            m_suspension = des.ReadClassPointer<hkpVehicleSuspension>(br);
            m_aerodynamics = des.ReadClassPointer<hkpVehicleAerodynamics>(br);
            m_wheelCollide = des.ReadClassPointer<hkpVehicleWheelCollide>(br);
            m_tyreMarks = des.ReadClassPointer<hkpTyremarksInfo>(br);
            m_velocityDamper = des.ReadClassPointer<hkpVehicleVelocityDamper>(br);
            m_vehicleSimulation = des.ReadClassPointer<hkpVehicleSimulation>(br);
            m_wheelsInfo = des.ReadClassArray<hkpVehicleInstanceWheelInfo>(br);
            m_deviceStatus = des.ReadClassPointer<hkpVehicleDriverInputStatus>(br);
            m_isFixed = des.ReadBooleanArray(br);
            m_wheelsTimeSinceMaxPedalInput = br.ReadSingle();
            m_tryingToReverse = br.ReadBoolean();
            br.ReadUInt16();
            br.ReadByte();
            m_torque = br.ReadSingle();
            m_rpm = br.ReadSingle();
            m_mainSteeringAngle = br.ReadSingle();
            m_mainSteeringAngleAssumingNoReduction = br.ReadSingle();
            m_wheelsSteeringAngle = des.ReadSingleArray(br);
            m_isReversing = br.ReadBoolean();
            m_currentGear = br.ReadSByte();
            m_delayed = br.ReadBoolean();
            br.ReadByte();
            m_clutchDelayCountdown = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_data);
            s.WriteClassPointer(bw, m_driverInput);
            s.WriteClassPointer(bw, m_steering);
            s.WriteClassPointer(bw, m_engine);
            s.WriteClassPointer(bw, m_transmission);
            s.WriteClassPointer(bw, m_brake);
            s.WriteClassPointer(bw, m_suspension);
            s.WriteClassPointer(bw, m_aerodynamics);
            s.WriteClassPointer(bw, m_wheelCollide);
            s.WriteClassPointer(bw, m_tyreMarks);
            s.WriteClassPointer(bw, m_velocityDamper);
            s.WriteClassPointer(bw, m_vehicleSimulation);
            s.WriteClassArray(bw, m_wheelsInfo);
            s.WriteClassPointer(bw, m_deviceStatus);
            s.WriteBooleanArray(bw, m_isFixed);
            bw.WriteSingle(m_wheelsTimeSinceMaxPedalInput);
            bw.WriteBoolean(m_tryingToReverse);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteSingle(m_torque);
            bw.WriteSingle(m_rpm);
            bw.WriteSingle(m_mainSteeringAngle);
            bw.WriteSingle(m_mainSteeringAngleAssumingNoReduction);
            s.WriteSingleArray(bw, m_wheelsSteeringAngle);
            bw.WriteBoolean(m_isReversing);
            bw.WriteSByte(m_currentGear);
            bw.WriteBoolean(m_delayed);
            bw.WriteByte(0);
            bw.WriteSingle(m_clutchDelayCountdown);
        }
    }
}