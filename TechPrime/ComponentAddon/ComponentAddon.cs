// ReSharper disable InconsistentNaming
namespace TechPrime.ComponentAddon
{
    public class ComponentAddon<T> where T : IComponentAddon
    {
        private readonly decimal price;
        private readonly ComponentAddon<T> componentAddon;

        private ComponentAddon(decimal price, ComponentAddon<T> componentAddon = null)
        {
            this.price = price;
            this.componentAddon = componentAddon;
        }

        #region MotherboardAddons

        public static ComponentAddon<IMotherboardAddon> SwitchLEDs(
            ComponentAddon<IMotherboardAddon> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboardAddon>(50, motherboardAddon);
        }

        public static ComponentAddon<IMotherboardAddon> DDR5MemoryModules(
            ComponentAddon<IMotherboardAddon> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboardAddon>(200, motherboardAddon);
        }

        public static ComponentAddon<IMotherboardAddon> GPUBridge(
            ComponentAddon<IMotherboardAddon> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboardAddon>(400, motherboardAddon);
        }

        public static ComponentAddon<IMotherboardAddon> DedicatedWaterPumpHeaders(
            ComponentAddon<IMotherboardAddon> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboardAddon>(300, motherboardAddon);
        }

        #endregion

        #region RamAddons

        public static ComponentAddon<IRamAddon> DdrChipType(ComponentAddon<IRamAddon> ramAddon = null)
        {
            return new ComponentAddon<IRamAddon>(200, ramAddon);
        }

        public static ComponentAddon<IRamAddon> ErrorCheckingParity(ComponentAddon<IRamAddon> ramAddon = null)
        {
            return new ComponentAddon<IRamAddon>(100, ramAddon);
        }

        #endregion

        #region CpuAddons

        public static ComponentAddon<ICpuAddon> L3Cache(ComponentAddon<ICpuAddon> cpuAddon = null)
        {
            return new ComponentAddon<ICpuAddon>(150, cpuAddon);
        }

        public static ComponentAddon<ICpuAddon> GraphicsAccelerator(ComponentAddon<ICpuAddon> cpuAddon = null)
        {
            return new ComponentAddon<ICpuAddon>(300, cpuAddon);
        }

        public static ComponentAddon<ICpuAddon> LiquidCooling(ComponentAddon<ICpuAddon> cpuAddon = null)
        {
            return new ComponentAddon<ICpuAddon>(300, cpuAddon);
        }

        #endregion

        #region GpuAddons

        public static ComponentAddon<IGpuAddon> ConcurrentProcessing(ComponentAddon<IGpuAddon> gpuAddon = null)
        {
            return new ComponentAddon<IGpuAddon>(350, gpuAddon);
        }

        public static ComponentAddon<IGpuAddon> VariablePixelShading(ComponentAddon<IGpuAddon> gpuAddon = null)
        {
            return new ComponentAddon<IGpuAddon>(400, gpuAddon);
        }

        #endregion

        public decimal Price()
        {
            return price + (componentAddon?.Price() ?? 0);
        }
    }
}
