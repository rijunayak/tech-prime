using NUnit.Framework;
using static TechPrime.ComponentAddon.MotherboardAddon;

namespace TechPrime.Test.ComponentAddon
{
    [TestFixture]
    public class MotherboardAddonTest
    {
        [Test]
        public void Should_Price_Switch_LEDs_At_Fifty()
        {
            var motherboardAddon = SwitchLEDs();

            Assert.That(motherboardAddon.Price(), Is.EqualTo(50));
        }

        [Test]
        public void Should_Price_Switch_LEDs_And_DDR5_Memory_At_TwoFifty()
        {
            var motherboardAddon = SwitchLEDs(DDR5MemoryModules());

            Assert.That(motherboardAddon.Price(), Is.EqualTo(250));
        }

        [Test]
        public void Should_Price_Switch_LEDs_DDR5_Memory_And_GPU_Bridge_At_SixFifty()
        {
            var motherboardAddon = SwitchLEDs(DDR5MemoryModules(GPUBridge()));

            Assert.That(motherboardAddon.Price(), Is.EqualTo(650));
        }

        [Test]
        public void Should_Price_Dedicated_Water_Pump_Headers_At_ThreeHundred()
        {
            var motherboardAddon = DedicatedWaterPumpHeaders();

            Assert.That(motherboardAddon.Price(), Is.EqualTo(300));
        }
    }
}
