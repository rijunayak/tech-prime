// ReSharper disable InconsistentNaming

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TechPrime.Test")]
namespace TechPrime.ComponentAddon
{
    public class ComponentAddon<T> : IComponentAddon<T> where T : ISingularAddon
    {
        private readonly decimal price;
        private readonly IComponentAddon<T> componentAddon;

        private ComponentAddon(decimal price, IComponentAddon<T> componentAddon = null)
        {
            this.price = price;
            this.componentAddon = componentAddon;
        }

        #region MotherboardAddons

        public static IComponentAddon<IMotherboardAddon> SwitchLEDs(
            IComponentAddon<IMotherboardAddon> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboardAddon>(50, motherboardAddon);
        }

        public static IComponentAddon<IMotherboardAddon> DDR5MemoryModules(
            IComponentAddon<IMotherboardAddon> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboardAddon>(200, motherboardAddon);
        }

        public static IComponentAddon<IMotherboardAddon> GPUBridge(
            IComponentAddon<IMotherboardAddon> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboardAddon>(400, motherboardAddon);
        }

        public static IComponentAddon<IMotherboardAddon> DedicatedWaterPumpHeaders(
            IComponentAddon<IMotherboardAddon> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboardAddon>(300, motherboardAddon);
        }

        #endregion

        #region RamAddons

        public static IComponentAddon<IRamAddon> DdrChipType(IComponentAddon<IRamAddon> ramAddon = null)
        {
            return new ComponentAddon<IRamAddon>(200, ramAddon);
        }

        public static IComponentAddon<IRamAddon> ErrorCheckingParity(IComponentAddon<IRamAddon> ramAddon = null)
        {
            return new ComponentAddon<IRamAddon>(100, ramAddon);
        }

        #endregion

        #region CpuAddons

        public static IComponentAddon<ICpuAddon> L3Cache(IComponentAddon<ICpuAddon> cpuAddon = null)
        {
            return new ComponentAddon<ICpuAddon>(150, cpuAddon);
        }

        public static IComponentAddon<ICpuAddon> GraphicsAccelerator(IComponentAddon<ICpuAddon> cpuAddon = null)
        {
            return new ComponentAddon<ICpuAddon>(300, cpuAddon);
        }

        public static IComponentAddon<ICpuAddon> LiquidCooling(IComponentAddon<ICpuAddon> cpuAddon = null)
        {
            return new ComponentAddon<ICpuAddon>(300, cpuAddon);
        }

        #endregion

        #region GpuAddons

        public static IComponentAddon<IGpuAddon> ConcurrentProcessing(IComponentAddon<IGpuAddon> gpuAddon = null)
        {
            return new ComponentAddon<IGpuAddon>(350, gpuAddon);
        }

        public static IComponentAddon<IGpuAddon> VariablePixelShading(IComponentAddon<IGpuAddon> gpuAddon = null)
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
