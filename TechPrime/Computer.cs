using TechPrime.ComponentAddon;

namespace TechPrime
{
    public class Computer
    {
        private const decimal FreedomChargesPercentage = 0.2m;
        private const decimal BaseComputerCost = 200m;

        private readonly Component<IMotherboard> motherboard;
        private readonly Component<ICpu> cpu;
        private readonly Component<IRam> ram;
        private readonly Component<IGpu> gpu;
        private readonly Location locationBought;

        public Computer(Component<IMotherboard> motherboard, Component<ICpu> cpu, Component<IRam> ram,
            Component<IGpu> gpu, Location locationBought)
        {
            this.motherboard = motherboard;
            this.cpu = cpu;
            this.ram = ram;
            this.gpu = gpu;
            this.locationBought = locationBought;
        }

        public decimal Price()
        {
            var netCost = BaseComputerCost + motherboard.Price() + cpu.Price() + ram.Price() + gpu.Price();

            var freedomCharges = FreedomChargesPercentage * netCost;

            var locationTax = LocationTaxFor(motherboard) + LocationTaxFor(cpu) + LocationTaxFor(ram) +
                              LocationTaxFor(gpu);

            return netCost + freedomCharges + locationTax;
        }

        private decimal LocationTaxFor<T>(IComponent<T> component) where T : IComponentType
        {
            return component.Price() * component.LocationTax(locationBought);
        }
    }
}
