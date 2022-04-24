// ReSharper disable InconsistentNaming

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static TechPrime.Location;

// ReSharper disable StaticMemberInGenericType

[assembly: InternalsVisibleTo("TechPrime.Test")]

namespace TechPrime.ComponentAddon
{
    public class ComponentAddon<T> : IComponentAddon<T> where T : IComponentType
    {
        private readonly decimal price;
        private readonly IComponentAddon<T> componentAddon;

        private ComponentAddon(decimal price, IComponentAddon<T> componentAddon = null)
        {
            this.price = price;
            this.componentAddon = componentAddon;
        }

        #region MotherboardAddons

        public static IComponentAddon<IMotherboard> SwitchLEDs(
            IComponentAddon<IMotherboard> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboard>(50, motherboardAddon);
        }

        public static IComponentAddon<IMotherboard> DDR5MemoryModules(
            IComponentAddon<IMotherboard> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboard>(200, motherboardAddon);
        }

        public static IComponentAddon<IMotherboard> GPUBridge(
            IComponentAddon<IMotherboard> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboard>(400, motherboardAddon);
        }

        public static IComponentAddon<IMotherboard> DedicatedWaterPumpHeaders(
            IComponentAddon<IMotherboard> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboard>(300, motherboardAddon);
        }

        #endregion

        #region RamAddons

        public static IComponentAddon<IRam> DdrChipType(IComponentAddon<IRam> ramAddon = null)
        {
            return new ComponentAddon<IRam>(200, ramAddon);
        }

        public static IComponentAddon<IRam> ErrorCheckingParity(IComponentAddon<IRam> ramAddon = null)
        {
            return new ComponentAddon<IRam>(100, ramAddon);
        }

        #endregion

        #region CpuAddons

        public static IComponentAddon<ICpu> L3Cache(IComponentAddon<ICpu> cpuAddon = null)
        {
            return new ComponentAddon<ICpu>(150, cpuAddon);
        }

        public static IComponentAddon<ICpu> GraphicsAccelerator(IComponentAddon<ICpu> cpuAddon = null)
        {
            return new ComponentAddon<ICpu>(300, cpuAddon);
        }

        public static IComponentAddon<ICpu> LiquidCooling(IComponentAddon<ICpu> cpuAddon = null)
        {
            return new ComponentAddon<ICpu>(300, cpuAddon);
        }

        #endregion

        #region GpuAddons

        public static IComponentAddon<IGpu> ConcurrentProcessing(IComponentAddon<IGpu> gpuAddon = null)
        {
            return new ComponentAddon<IGpu>(350, gpuAddon);
        }

        public static IComponentAddon<IGpu> VariablePixelShading(IComponentAddon<IGpu> gpuAddon = null)
        {
            return new ComponentAddon<IGpu>(400, gpuAddon);
        }

        #endregion

        public decimal Price()
        {
            return price + (componentAddon?.Price() ?? 0);
        }
    }
}
