// ReSharper disable InconsistentNaming
namespace TechPrime.ComponentAddon
{
    public sealed class MotherboardAddon : IComponentAddon
    {
        private readonly decimal price;
        private readonly MotherboardAddon addon;

        private MotherboardAddon(decimal price, MotherboardAddon addon = null)
        {
            this.price = price;
            this.addon = addon;
        }

        public static MotherboardAddon SwitchLEDs(MotherboardAddon addon = null)
        {
            return new MotherboardAddon(50, addon);
        }

        public static MotherboardAddon DDR5MemoryModules(MotherboardAddon addon = null)
        {
            return new MotherboardAddon(200, addon);
        }

        public static MotherboardAddon GPUBridge(MotherboardAddon addon = null)
        {
            return new MotherboardAddon(400, addon);
        }

        public static MotherboardAddon DedicatedWaterPumpHeaders(MotherboardAddon addon = null)
        {
            return new MotherboardAddon(300, addon);
        }

        public decimal Price()
        {
            return price + (addon?.Price() ?? 0);
        }
    }
}
