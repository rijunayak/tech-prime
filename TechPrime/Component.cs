using System.Collections.Generic;
using TechPrime.ComponentAddon;

using static TechPrime.Location;
// ReSharper disable StaticMemberInGenericType

namespace TechPrime
{
    public class Component<T> : IComponent<T> where T : IComponentType
    {
        private const int MotherboardBasePrice = 200;
        private const int RamBasePrice = 100;
        private const int CpuBasePrice = 200;
        private const int GpuBasePrice = 300;

        private readonly decimal basePrice;
        private readonly IComponentAddon<T> componentAddon;
        private readonly IDictionary<Location, decimal> locationTax;

        private Component(decimal basePrice, IComponentAddon<T> componentAddon, IDictionary<Location, decimal> locationTax)
        {
            this.basePrice = basePrice;
            this.componentAddon = componentAddon;
            this.locationTax = locationTax;
        }

        private static readonly IDictionary<Location, decimal> MotherboardLocationTaxes =
            new Dictionary<Location, decimal>
            {
                {ByteSpace, 0.02m},
                {Encryptionia, 0.03m},
                {CompressionLand, 0.025m}
            };

        private static readonly IDictionary<Location, decimal> RamLocationTaxes =
            new Dictionary<Location, decimal>
            {
                {ByteSpace, 0.025m},
                {Encryptionia, 0.03m},
                {CompressionLand, 0.015m}
            };

        private static readonly IDictionary<Location, decimal> CpuLocationTaxes =
            new Dictionary<Location, decimal>
            {
                {ByteSpace, 0.03m},
                {Encryptionia, 0.02m},
                {CompressionLand, 0.04m}
            };

        private static readonly IDictionary<Location, decimal> GpuLocationTaxes =
            new Dictionary<Location, decimal>
            {
                {ByteSpace, 0.04m},
                {Encryptionia, 0.03m},
                {CompressionLand, 0.05m}
            };

        public static Component<IMotherboard> Motherboard(IComponentAddon<IMotherboard> motherboardAddon = null)
        {
            return new Component<IMotherboard>(MotherboardBasePrice, motherboardAddon, MotherboardLocationTaxes);
        }

        public static Component<IRam> Ram(IComponentAddon<IRam> ramAddon = null)
        {
            return new Component<IRam>(RamBasePrice, ramAddon, RamLocationTaxes);
        }

        public static Component<ICpu> Cpu(IComponentAddon<ICpu> cpuAddon = null)
        {
            return new Component<ICpu>(CpuBasePrice, cpuAddon, CpuLocationTaxes);
        }

        public static Component<IGpu> Gpu(IComponentAddon<IGpu> gpuAddon = null)
        {
            return new Component<IGpu>(GpuBasePrice, gpuAddon, GpuLocationTaxes);
        }

        public decimal Price()
        {
            var addonPrice = componentAddon?.Price() ?? 0;
            return basePrice + addonPrice;
        }

        public decimal LocationTax(Location location)
        {
            return locationTax[location];
        }
    }
}
