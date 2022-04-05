namespace TechPrime
{
    public interface ILocation
    {
        decimal MotherboardTax { get; }
        decimal RamTax { get; }
        decimal CpuTax { get; }
        decimal GpuTax { get; }
    }
}
