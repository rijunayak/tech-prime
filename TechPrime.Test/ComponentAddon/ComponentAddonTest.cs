using NUnit.Framework;
using static TechPrime.ComponentAddon.ComponentAddon<TechPrime.ComponentAddon.IMotherboardAddon>;

namespace TechPrime.Test.ComponentAddon
{
    [TestFixture]
    public class ComponentAddonTest
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

        [TestFixture]
        public class RamAddonTest
        {
            [Test]
            public void Should_Price_DDR_Chip_At_Two_Hundred()
            {
                var ramAddon = DdrChipType();

                Assert.That(ramAddon.Price(), Is.EqualTo(200));
            }

            [Test]
            public void Should_Price_DDR_Chip_And_Error_Checking_Parity_At_Three_Hundred()
            {
                var ramAddon = DdrChipType(ErrorCheckingParity());

                Assert.That(ramAddon.Price(), Is.EqualTo(300));
            }
        }

        [TestFixture]
        public class CpuAddonTest
        {
            [Test]
            public void Should_Price_L3_Cache_At_OneFifty()
            {
                var cpuAddon = L3Cache();

                Assert.That(cpuAddon.Price(), Is.EqualTo(150));
            }

            [Test]
            public void Should_Price_L3_Cache_And_Graphics_Accelerator_At_FourFifty()
            {
                var cpuAddon = L3Cache(GraphicsAccelerator());

                Assert.That(cpuAddon.Price(), Is.EqualTo(450));
            }

            [Test]
            public void Should_Price_Liquid_Cooling_At_Three_Hundred()
            {
                var cpuAddon = LiquidCooling();

                Assert.That(cpuAddon.Price(), Is.EqualTo(300));
            }
        }

        [TestFixture]
        public class GpuAddonTest
        {
            [Test]
            public void Should_Price_Concurrent_Processing_At_ThreeFifty()
            {
                var gpuAddon = ConcurrentProcessing();

                Assert.That(gpuAddon.Price(), Is.EqualTo(350));
            }

            [Test]
            public void Should_Price_Concurrent_Processing_And_Variable_Pixel_Shading_At_SevenFifty()
            {
                var gpuAddon = ConcurrentProcessing(VariablePixelShading());

                Assert.That(gpuAddon.Price(), Is.EqualTo(750));
            }
        }
    }
}
