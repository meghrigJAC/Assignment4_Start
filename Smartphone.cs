using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Start
{
    public class Smartphone
    {
        private ushort _yearModel;
        private string _make;
        private byte _batteryLevel;
        private float _storageCapacity;
        private float _usedCapacity;

        public const ushort FIRST_MOBILE_YEAR = 1992;
        public const float MAX_CAPACITY = 1000;
        public const byte FULLY_CHARGED = 100;


        #region CONSTRUCTORS
        public Smartphone()
        {
            YearModel = FIRST_MOBILE_YEAR;
            Make = string.Empty;
            BatteryLevel = 0;
            StorageCapacity = 0;
            _usedCapacity = 0;
        }

        public Smartphone(ushort yearModel_, string make_, byte batterylevel_, float storageCapacity_)
        {
            YearModel = yearModel_;
            Make = make_;
            BatteryLevel = batterylevel_;
            StorageCapacity = storageCapacity_;
            _usedCapacity = 0;
        }

        public Smartphone(ushort yearModel_, string make_, byte batterylevel_, float storageCapacity_, float usedCapacity_)
        {
            YearModel = yearModel_;
            Make = make_;
            BatteryLevel = batterylevel_;
            StorageCapacity = storageCapacity_;
            _usedCapacity = usedCapacity_;
        }

        #endregion

        #region PROPERTIES
        public ushort YearModel
        {
            get { return _yearModel; }
            set
            {
                if (value < FIRST_MOBILE_YEAR || value > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException(YearModel.ToString(), "Invalid year model");
                }
                _yearModel = value;
            }
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public byte BatteryLevel
        {
            get { return _batteryLevel; }
            set
            {
                if (value < 0 || value > FULLY_CHARGED)
                {
                    throw new ArgumentOutOfRangeException(BatteryLevel.ToString(), "Invalid battery level");
                }
                _batteryLevel = value;
            }
        }

        public float StorageCapacity
        {
            get { return _storageCapacity; }
            set
            {
                if (value < 0 || value > MAX_CAPACITY)
                {
                    throw new ArgumentOutOfRangeException(StorageCapacity.ToString(), "Invalid storage capacity");
                }
                _storageCapacity = value;
            }
        }

        public float UsedCapacity
        {
            get { return _usedCapacity; }
        }
        #endregion

        #region Methods

        public void InstallApp(ushort size)
        {
            if (UsedCapacity + size > StorageCapacity)
                throw new InvalidOperationException("Not enough storage space");

            _usedCapacity += size;


        }
        public void InstallApp(float size)
        {
            if (UsedCapacity + size > StorageCapacity)
                throw new InvalidOperationException("Not enough storage space");


            _usedCapacity += size;


        }


        public void ChargeBattery()
        {
            if (BatteryLevel < 100)
                BatteryLevel++;
        }

        public void DischargeBattery()
        {

            if (BatteryLevel > 0)
                BatteryLevel--;

        }


        public override string ToString()
        {
            return $"Year Model: {YearModel} Make: {Make} Battery Level: {BatteryLevel} Storage Capacity: {StorageCapacity} Used Capacity: {UsedCapacity}";
        }

        #endregion
    }
}
