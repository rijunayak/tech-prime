using FakeItEasy;
using NUnit.Framework;
using TechPrime.ComponentAddon;
using static TechPrime.Component<TechPrime.ComponentAddon.IMotherboard>;
using static TechPrime.Location;

namespace TechPrime.Test
{
    [TestFixture]
    public class ComponentTest
    {
        [TestFixture]
        public class MotherboardTest
        {
            [Test]
            public void Should_Price_A_Motherboard_With_No_Addons_At_Two_Hundred()
            {
                var motherboard = Motherboard();

                Assert.That(motherboard.Price(), Is.EqualTo(200));
            }

            [Test]
            public void Should_Price_A_Motherboard_With_An_Addon_Of_Hundred_At_Three_Hundred()
            {
                // Arrange
                var motherboardAddon = A.Fake<IComponentAddon<IMotherboard>>();
                A.CallTo(() => motherboardAddon.Price()).Returns(100);

                var motherboard = Motherboard(motherboardAddon);

                // Act & Assert
                Assert.That(motherboard.Price(), Is.EqualTo(300));
            }

            [Test]
            public void Should_Tax_Motherboard_In_Locations_Correctly()
            {
                var motherboardAddon = Motherboard();

                Assert.That(motherboardAddon.LocationTax(ByteSpace), Is.EqualTo(0.02m));
                Assert.That(motherboardAddon.LocationTax(Encryptionia), Is.EqualTo(0.03m));
                Assert.That(motherboardAddon.LocationTax(CompressionLand), Is.EqualTo(0.025m));
            }
        }

        [TestFixture]
        public class RamTest
        {
            [Test]
            public void Should_Price_A_Ram_With_No_Addons_At_One_Hundred()
            {
                var ram = Ram();

                Assert.That(ram.Price(), Is.EqualTo(100));
            }

            [Test]
            public void Should_Price_A_Ram_With_An_Addon_Of_Hundred_At_Two_Hundred()
            {
                // Arrange
                var ramAddon = A.Fake<IComponentAddon<IRam>>();
                A.CallTo(() => ramAddon.Price()).Returns(100);

                var ram = Ram(ramAddon);

                // Act & Assert
                Assert.That(ram.Price(), Is.EqualTo(200));
            }

            [Test]
            public void Should_Tax_Ram_In_Locations_Correctly()
            {
                var ram = Ram();

                Assert.That(ram.LocationTax(ByteSpace), Is.EqualTo(0.025m));
                Assert.That(ram.LocationTax(Encryptionia), Is.EqualTo(0.03m));
                Assert.That(ram.LocationTax(CompressionLand), Is.EqualTo(0.015m));
            }
        }

        [TestFixture]
        public class CpuTest
        {
            [Test]
            public void Should_Price_A_Cpu_With_No_Addons_At_Two_Hundred()
            {
                var cpu = Cpu();

                Assert.That(cpu.Price(), Is.EqualTo(200));
            }

            [Test]
            public void Should_Price_A_Cpu_With_An_Addon_Of_Hundred_At_Three_Hundred()
            {
                // Arrange
                var cpuAddon = A.Fake<IComponentAddon<ICpu>>();
                A.CallTo(() => cpuAddon.Price()).Returns(100);

                var cpu = Cpu(cpuAddon);

                // Act & Assert
                Assert.That(cpu.Price(), Is.EqualTo(300));
            }

            [Test]
            public void Should_Tax_Cpu_In_Locations_Correctly()
            {
                var cpu = Cpu();

                Assert.That(cpu.LocationTax(ByteSpace), Is.EqualTo(0.03m));
                Assert.That(cpu.LocationTax(Encryptionia), Is.EqualTo(0.02m));
                Assert.That(cpu.LocationTax(CompressionLand), Is.EqualTo(0.04m));
            }
        }

        [TestFixture]
        public class GpuTest
        {
            [Test]
            public void Should_Price_A_Gpu_With_No_Addons_At_Three_Hundred()
            {
                var gpu = Gpu();

                Assert.That(gpu.Price(), Is.EqualTo(300));
            }

            [Test]
            public void Should_Price_A_Gpu_With_An_Addon_Of_Hundred_At_Four_Hundred()
            {
                // Arrange
                var gpuAddon = A.Fake<IComponentAddon<IGpu>>();
                A.CallTo(() => gpuAddon.Price()).Returns(100);

                var gpu = Gpu(gpuAddon);

                // Act & Assert
                Assert.That(gpu.Price(), Is.EqualTo(400));
            }

            [Test]
            public void Should_Tax_Gpu_In_Locations_Correctly()
            {
                var gpu = Gpu();

                Assert.That(gpu.LocationTax(ByteSpace), Is.EqualTo(0.04m));
                Assert.That(gpu.LocationTax(Encryptionia), Is.EqualTo(0.03m));
                Assert.That(gpu.LocationTax(CompressionLand), Is.EqualTo(0.05m));
            }
        }
    }
}
