namespace TechPrime.ComponentAddon
{
    public interface IComponentAddon<T> where T : IComponentType
    {
        decimal Price();
    }
}
