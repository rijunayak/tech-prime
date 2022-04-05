using TechPrime.ComponentAddon;

namespace TechPrime
{
    public interface IComponent<T> where T : ISingularAddon
    {
        decimal Price();
    }
}
