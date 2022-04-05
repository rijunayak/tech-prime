using TechPrime.ComponentAddon;

namespace TechPrime
{
    public class Component<T> : IComponent<T> where T : ISingularAddon
    {
        private const int MotherboardBasePrice = 200;
        private const int RamBasePrice = 100;
        private const int CpuBasePrice = 200;
        private const int GpuBasePrice = 300;

        private readonly decimal basePrice;
        private readonly IComponentAddon<T> componentAddon;

        private Component(decimal basePrice, IComponentAddon<T> componentAddon)
        {
            this.basePrice = basePrice;
            this.componentAddon = componentAddon;
        }

        public static Component<IMotherboardAddon> Motherboard(IComponentAddon<IMotherboardAddon> motherboardAddon)
        {
            return new Component<IMotherboardAddon>(MotherboardBasePrice, motherboardAddon);
        }

        public static Component<IRamAddon> Ram(IComponentAddon<IRamAddon> ramAddon)
        {
            return new Component<IRamAddon>(RamBasePrice, ramAddon);
        }

        public static Component<ICpuAddon> Cpu(IComponentAddon<ICpuAddon> cpuAddon)
        {
            return new Component<ICpuAddon>(CpuBasePrice, cpuAddon);
        }

        public static Component<IGpuAddon> Gpu(IComponentAddon<IGpuAddon> gpuAddon)
        {
            return new Component<IGpuAddon>(GpuBasePrice, gpuAddon);
        }

        public decimal Price()
        {
            return basePrice + componentAddon.Price();
        }
    }
}
