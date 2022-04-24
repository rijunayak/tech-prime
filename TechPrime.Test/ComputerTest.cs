using NUnit.Framework;
using static TechPrime.Component<TechPrime.ComponentAddon.IMotherboard>;
using static TechPrime.Location;
using static TechPrime.ComponentAddon.ComponentAddon<TechPrime.ComponentAddon.IMotherboard>;

namespace TechPrime.Test
{
    [TestFixture]
    public class ComputerTest
    {
        [Test]
        public void Should_Price_A_Computer_At_1224_Point_5_For_Basic_Components_In_Byte_Space()
        {
            var motherboard = Motherboard();
            var cpu = Cpu();
            var ram = Ram();
            var gpu = Gpu();

            var computer = new Computer(motherboard, cpu, ram, gpu, ByteSpace);

            Assert.That(computer.Price(), Is.EqualTo(1224.5m));
        }

        [Test]
        public void Should_Price_A_Customized_Computer_Accordingly()
        {
            var motherboard = Motherboard(SwitchLEDs(GPUBridge()));
            var cpu = Cpu(LiquidCooling());
            var ram = Ram(DdrChipType());
            var gpu = Gpu(VariablePixelShading());

            var computer = new Computer(motherboard, cpu, ram, gpu, CompressionLand);

            Assert.That(computer.Price(), Is.EqualTo(2895.75m));
        }
    }
}
