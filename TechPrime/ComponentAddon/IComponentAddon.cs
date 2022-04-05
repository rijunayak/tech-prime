namespace TechPrime.ComponentAddon
{
    public interface IComponentAddon<T> where T : ISingularAddon
    {
        decimal Price();
    }
}
