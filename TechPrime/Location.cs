namespace TechPrime
{
    public sealed class Location : ILocation
    {
        private Location(decimal motherboardTax, decimal ramTax, decimal cpuTax, decimal gpuTax)
        {
            MotherboardTax = motherboardTax;
            RamTax = ramTax;
            CpuTax = cpuTax;
            GpuTax = gpuTax;
        }

        public decimal MotherboardTax { get; }
        public decimal RamTax { get; }
        public decimal CpuTax { get; }
        public decimal GpuTax { get; }

        public static ILocation ByteSpace = new Location(0.02m, 0.025m, 0.03m, 0.04m);
        public static ILocation Encryptionia = new Location(0.03m, 0.03m, 0.02m, 0.03m);
        public static ILocation CompressionLand = new Location(0.025m, 0.015m, 0.04m, 0.05m);
    }
}
