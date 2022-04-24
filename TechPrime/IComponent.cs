using TechPrime.ComponentAddon;

namespace TechPrime
{
    public interface IComponent<T> where T : IComponentType
    {
        decimal Price();
        decimal LocationTax(Location location);
    }
}
