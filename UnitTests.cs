namespace Assignment4_Start
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void SmartphoneDefaultConstructor()
        {
            try
            {
                Smartphone s = new Smartphone();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        [TestMethod]
        public void SmartphoneParamaterizedConstructorYearLessthan1992()
        {
            try
            {
                Smartphone s = new Smartphone(125, "iphone 7", 75, 128);
            }
            catch (Exception e)
            {
                return;
            }

            Assert.Fail("Model cannot be less than 1992");
        }
        [TestMethod]
        public void SmartphoneParamaterizedConstructorYearModelGreaterthan()
        {
            try
            {
                Smartphone s = new Smartphone(2024, "iphone 7", 75, 128);
            }
            catch (Exception e)
            {
                return;
            }

            Assert.Fail("Model cannot be greater than 2023");
        }
        [TestMethod]
        public void SmartphoneYearModelProperty()
        {
            try
            {
                Smartphone s = new Smartphone();
                s.YearModel = 123;

            }
            catch (Exception e)
            {
                return;
            }

            Assert.Fail("Model cannot be less than 1992");
        }
        [TestMethod]
        public void SmartphoneYearModelPropertyTwo()
        {
            try
            {
                Smartphone s = new Smartphone();
                s.YearModel = 2024;

            }
            catch (Exception e)
            {
                return;
            }

            Assert.Fail("Model cannot be greater than 2023");
        }
        [TestMethod]
        public void SmartphoneYearModelPropertyValid()
        {
            try
            {
                Smartphone s = new Smartphone();
                s.YearModel = 2023;
                Assert.AreEqual(s.YearModel, 2023);

            }
            catch (Exception e)
            {
                Assert.Fail("YearModel Property");
            }


        }
        [TestMethod]
        public void SmartphoneParamaterizedConstructorBatteryGreaterthan100()
        {
            try
            {
                Smartphone s = new Smartphone(2023, "iphone 7", 101, 128);
            }
            catch (Exception e)
            {
                return;
            }

            Assert.Fail("Battery cannot be greater than 100");
        }
        [TestMethod]
        public void SmartphoneBatteryProperty()
        {
            try
            {
                Smartphone s = new Smartphone();
                s.BatteryLevel = 101;

            }
            catch (Exception e)
            {
                return;
            }

            Assert.Fail("Battery cannot be greater than 100");
        }
        [TestMethod]
        public void SmartphoneBatteryPropertyValid()
        {
            try
            {
                Smartphone s = new Smartphone();
                s.BatteryLevel = 88;
                Assert.AreEqual(s.BatteryLevel, 88);

            }
            catch (Exception e)
            {
                Assert.Fail("BatteryLevel Property");
            }

        }

        [TestMethod]
        public void SmartphoneParamaterizedConstructorStorageCapacityGreaterthan1000()
        {
            try
            {
                Smartphone s = new Smartphone(2023, "iphone 7", 75, 10001);
            }
            catch (Exception e)
            {
                return;
            }

            Assert.Fail("Capacity cannot be greater than 1000");
        }

        [TestMethod]
        public void SmartphoneParamaterizedConstructorStorageCapacityTwoLessthan0()
        {
            try
            {
                Smartphone s = new Smartphone(2023, "iphone 7", 75, -10);
            }
            catch (Exception e)
            {
                return;
            }

            Assert.Fail("Capacity cannot be less than zero");
        }

        [TestMethod]
        public void SmartphoneCapacityProperty()
        {
            try
            {
                Smartphone s = new Smartphone();
                s.StorageCapacity = 10001;

            }
            catch (Exception e)
            {
                return;
            }

            Assert.Fail("Capacity cannot be greater than 1000");
        }

        [TestMethod]
        public void SmartphoneCapacityPropertyTwo()
        {
            try
            {
                Smartphone s = new Smartphone();
                s.StorageCapacity = -10;

            }
            catch (Exception e)
            {
                return;
            }

            Assert.Fail("Capacity cannot be less than 0");
        }

        [TestMethod]
        public void SmartphoneCapacityPropertyValid()
        {
            try
            {
                Smartphone s = new Smartphone();
                s.StorageCapacity = 512;
                Assert.AreEqual(s.StorageCapacity, 512);

            }
            catch (Exception e)
            {
                Assert.Fail("StorageCapacity Property");
            }


        }

        [TestMethod]
        public void SmartphoneMakePropertyValid()
        {
            try
            {
                Smartphone s = new Smartphone();
                s.Make = "Samsung";
                Assert.AreEqual(s.Make, "Samsung");

            }
            catch (Exception e)
            {
                Assert.Fail("Make Property");
            }


        }
        [TestMethod]
        public void SmartphoneParamaterizedConstructorAllFields()
        {
            try
            {
                Smartphone s = new Smartphone(2023, "iphone 7", 75, 256, 128);
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }


        }

        [TestMethod]
        public void SmartphoneParamaterizedConstructorInstallAppNoSpace()
        {
            try
            {
                Smartphone s = new Smartphone(2023, "iphone 7", 75, 256, 256);
                s.InstallApp(1);
            }
            catch (Exception e)
            {
                return;
            }

            Assert.Fail("No space");
        }

        [TestMethod]
        public void SmartphoneParamaterizedConstructorInstallApp()
        {
            try
            {
                Smartphone s = new Smartphone(2023, "iphone 7", 75, 256, 128);
                s.InstallApp(10);
                Assert.AreEqual(s.UsedCapacity, 138);
            }
            catch (Exception e)
            {
                Assert.Fail("Installation process wrong!");
            }
        }
        [TestMethod]
        public void SmartphoneParamaterizedConstructorInstallApptwo()
        {
            try
            {
                Smartphone s = new Smartphone(2023, "iphone 7", 75, 256, 128);
                s.InstallApp(10.5f);
                Assert.AreEqual(s.UsedCapacity, 138.5);
            }
            catch (Exception e)
            {
                Assert.Fail("Installation process wrong!");
            }
        }
        [TestMethod]
        public void SmartphoneParamaterizedConstructorChargeBattery()
        {
            try
            {
                Smartphone s = new Smartphone(2023, "iphone 7", 75, 256, 128);
                s.ChargeBattery();
                Assert.AreEqual(s.BatteryLevel, 76);
            }
            catch (Exception e)
            {
                Assert.Fail("Charging process wrong!");
            }
        }

        [TestMethod]
        public void SmartphoneParamaterizedConstructorChargeBatteryFull()
        {
            try
            {
                Smartphone s = new Smartphone(2023, "iphone 7", 100, 256, 128);
                s.ChargeBattery();
                Assert.AreEqual(s.BatteryLevel, 100);
            }
            catch (Exception e)
            {
                Assert.Fail("Charging process full!");
            }
        }

        [TestMethod]
        public void SmartphoneParamaterizedConstructorDisChargeBattery()
        {
            try
            {
                Smartphone s = new Smartphone(2023, "iphone 7", 75, 256, 128);
                s.DischargeBattery();
                Assert.AreEqual(s.BatteryLevel, 74);
            }
            catch (Exception e)
            {
                Assert.Fail("Charging process wrong!");
            }
        }

        [TestMethod]
        public void SmartphoneParamaterizedConstructorDisChargeBatteryZero()
        {
            try
            {
                Smartphone s = new Smartphone(2023, "iphone 7", 0, 256, 128);
                s.DischargeBattery();
                Assert.AreEqual(s.BatteryLevel, 0);
            }
            catch (Exception e)
            {
                Assert.Fail("Battery dead already!");
            }
        }

        [TestMethod]
        public void SmartphoneToString()
        {

            Smartphone s = new Smartphone(2023, "iphone 7", 100, 256, 128);

            Assert.IsTrue(s.ToString().Contains("iphone 7") &&
                            s.ToString().Contains(s.YearModel.ToString()) &&
                            s.ToString().Contains(s.UsedCapacity.ToString()) &&
                            s.ToString().Contains(s.StorageCapacity.ToString()) &&
                            s.ToString().Contains(s.BatteryLevel.ToString()));
        }
    }
}