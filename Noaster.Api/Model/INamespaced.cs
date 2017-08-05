namespace Noaster.Api.Model
{
    public interface INamespaced
    {
        string Namespace { get; }

        bool DefaultNamespace { get; }
    }
}