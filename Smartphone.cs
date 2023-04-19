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
        //Default constuctor
        public Smartphone()
        {
            YearModel = FIRST_MOBILE_YEAR;
            Make = string.Empty;
            BatteryLevel = 0;
            StorageCapacity = 0;
            _usedCapacity = 0;
        }
        //Parameterized constuctor
        public Smartphone(ushort yearModel_, string make_, byte batterylevel_, float storageCapacity_)
        {
            YearModel = yearModel_;
            Make = make_;
            BatteryLevel = batterylevel_;
            StorageCapacity = storageCapacity_;
            _usedCapacity = 0;
        }
        //Parameterized constuctor
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
        //YearModel property throws an exception if year < FIRST_MOBILE_YEAR or > now
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

        //Make property
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        //Battery level property throws an exception if level < 0 or > FULLY_CHARGED
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

        // Storage capacity property throws an exception if capacity > MAX_CAPACITY 
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

        //Read only used capacity property
        public float UsedCapacity
        {
            get { return _usedCapacity; }
        }
        #endregion

        #region Methods
        // Checks if there is still space to install an app, updates the capacity used. Throws an exception if enough space is not available
        public void InstallApp(ushort size)
        {
            if (UsedCapacity + size > StorageCapacity)
                throw new InvalidOperationException("Not enough storage space");

            _usedCapacity += size;


        }
        // Checks if there is still space to install an app, updates the capacity used. Throws an exception if enough space is not available
        //Method overloading with the above method
        public void InstallApp(float size)
        {
            if (UsedCapacity + size > StorageCapacity)
                throw new InvalidOperationException("Not enough storage space");


            _usedCapacity += size;


        }

        //Charges battery if <100
        public void ChargeBattery()
        {
            if (BatteryLevel < 100)
                BatteryLevel++;
        }
        //Discharges battery if >0
        public void DischargeBattery()
        {

            if (BatteryLevel > 0)
                BatteryLevel--;

        }

        //ToStringmethod overriden
        public override string ToString()
        {
            return $"Year Model: {YearModel} Make: {Make} Battery Level: {BatteryLevel} Storage Capacity: {StorageCapacity} Used Capacity: {UsedCapacity}";
        }

        #endregion
    }
}
