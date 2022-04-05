using FakeItEasy;
using NUnit.Framework;
using TechPrime.ComponentAddon;
using static TechPrime.Component<TechPrime.ComponentAddon.IMotherboardAddon>;

namespace TechPrime.Test
{
    [TestFixture]
    public class ComponentTest
    {
        [Test]
        public void Should_Price_A_Motherboard_With_An_Addon_Of_Hundred_At_Three_Hundred()
        {
            // Arrange
            var motherboardAddon = A.Fake<IComponentAddon<IMotherboardAddon>>();
            A.CallTo(() => motherboardAddon.Price()).Returns(100);

            var motherboard = Motherboard(motherboardAddon);

            // Act & Assert
            Assert.That(motherboard.Price(), Is.EqualTo(300));
        }

        [Test]
        public void Should_Price_A_Ram_With_An_Addon_Of_Hundred_At_Two_Hundred()
        {
            // Arrange
            var ramAddon = A.Fake<IComponentAddon<IRamAddon>>();
            A.CallTo(() => ramAddon.Price()).Returns(100);

            var ram = Ram(ramAddon);

            // Act & Assert
            Assert.That(ram.Price(), Is.EqualTo(200));
        }

        [Test]
        public void Should_Price_A_Cpu_With_An_Addon_Of_Hundred_At_Three_Hundred()
        {
            // Arrange
            var cpuAddon = A.Fake<IComponentAddon<ICpuAddon>>();
            A.CallTo(() => cpuAddon.Price()).Returns(100);

            var cpu = Cpu(cpuAddon);

            // Act & Assert
            Assert.That(cpu.Price(), Is.EqualTo(300));
        }

        [Test]
        public void Should_Price_A_Gpu_With_An_Addon_Of_Hundred_At_Four_Hundred()
        {
            // Arrange
            var gpuAddon = A.Fake<IComponentAddon<IGpuAddon>>();
            A.CallTo(() => gpuAddon.Price()).Returns(100);

            var gpu = Gpu(gpuAddon);

            // Act & Assert
            Assert.That(gpu.Price(), Is.EqualTo(400));
        }
    }
}
