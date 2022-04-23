// ReSharper disable InconsistentNaming

using System.Collections.Generic;
using System.Runtime.CompilerServices;

using static TechPrime.Location;
// ReSharper disable StaticMemberInGenericType

[assembly: InternalsVisibleTo("TechPrime.Test")]
namespace TechPrime.ComponentAddon
{
    public class ComponentAddon<T> : IComponentAddon<T> where T : ISingularAddon
    {
        private readonly decimal price;
        private readonly IComponentAddon<T> componentAddon;
        private readonly IDictionary<Location, decimal> locationTax;

        private ComponentAddon(decimal price, IDictionary<Location, decimal> locationTax, IComponentAddon<T> componentAddon = null)
        {
            this.price = price;
            this.locationTax = locationTax;
            this.componentAddon = componentAddon;
        }

        #region MotherboardAddons

        private static readonly IDictionary<Location, decimal> motherboardLocationTaxes =
            new Dictionary<Location, decimal>
                {
                {ByteSpace, 0.02m},
                {Encryptionia, 0.03m},
                {CompressionLand, 0.025m}
            };

        public static IComponentAddon<IMotherboardAddon> SwitchLEDs(
            IComponentAddon<IMotherboardAddon> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboardAddon>(50, motherboardLocationTaxes, motherboardAddon);
        }

        public static IComponentAddon<IMotherboardAddon> DDR5MemoryModules(
            IComponentAddon<IMotherboardAddon> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboardAddon>(200, motherboardLocationTaxes, motherboardAddon);
        }

        public static IComponentAddon<IMotherboardAddon> GPUBridge(
            IComponentAddon<IMotherboardAddon> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboardAddon>(400, motherboardLocationTaxes, motherboardAddon);
        }

        public static IComponentAddon<IMotherboardAddon> DedicatedWaterPumpHeaders(
            IComponentAddon<IMotherboardAddon> motherboardAddon = null)
        {
            return new ComponentAddon<IMotherboardAddon>(300, motherboardLocationTaxes, motherboardAddon);
        }

        #endregion

        #region RamAddons

        private static readonly IDictionary<Location, decimal> ramLocationTaxes =
            new Dictionary<Location, decimal>
            {
                {ByteSpace, 0.025m},
                {Encryptionia, 0.03m},
                {CompressionLand, 0.015m}
            };

        public static IComponentAddon<IRamAddon> DdrChipType(IComponentAddon<IRamAddon> ramAddon = null)
        {
            return new ComponentAddon<IRamAddon>(200, ramLocationTaxes, ramAddon);
        }

        public static IComponentAddon<IRamAddon> ErrorCheckingParity(IComponentAddon<IRamAddon> ramAddon = null)
        {
            return new ComponentAddon<IRamAddon>(100, ramLocationTaxes, ramAddon);
        }

        #endregion

        #region CpuAddons

        private static readonly IDictionary<Location, decimal> cpuLocationTaxes =
            new Dictionary<Location, decimal>
            {
                {ByteSpace, 0.03m},
                {Encryptionia, 0.02m},
                {CompressionLand, 0.04m}
            };

        public static IComponentAddon<ICpuAddon> L3Cache(IComponentAddon<ICpuAddon> cpuAddon = null)
        {
            return new ComponentAddon<ICpuAddon>(150, cpuLocationTaxes, cpuAddon);
        }

        public static IComponentAddon<ICpuAddon> GraphicsAccelerator(IComponentAddon<ICpuAddon> cpuAddon = null)
        {
            return new ComponentAddon<ICpuAddon>(300, cpuLocationTaxes, cpuAddon);
        }

        public static IComponentAddon<ICpuAddon> LiquidCooling(IComponentAddon<ICpuAddon> cpuAddon = null)
        {
            return new ComponentAddon<ICpuAddon>(300, cpuLocationTaxes, cpuAddon);
        }

        #endregion

        #region GpuAddons

        private static readonly IDictionary<Location, decimal> gpuLocationTaxes =
            new Dictionary<Location, decimal>
            {
                {ByteSpace, 0.04m},
                {Encryptionia, 0.03m},
                {CompressionLand, 0.05m}
            };

        public static IComponentAddon<IGpuAddon> ConcurrentProcessing(IComponentAddon<IGpuAddon> gpuAddon = null)
        {
            return new ComponentAddon<IGpuAddon>(350, gpuLocationTaxes, gpuAddon);
        }

        public static IComponentAddon<IGpuAddon> VariablePixelShading(IComponentAddon<IGpuAddon> gpuAddon = null)
        {
            return new ComponentAddon<IGpuAddon>(400, gpuLocationTaxes, gpuAddon);
        }

        #endregion

        public decimal Price()
        {
            return price + (componentAddon?.Price() ?? 0);
        }

        public decimal LocationTax(Location location)
        {
            return locationTax[location];
        }
    }
}
