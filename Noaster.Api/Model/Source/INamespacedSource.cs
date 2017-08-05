namespace Noaster.Api.Model.Source
{
    public interface INamespacedSource : INamespaced
    {
        new string Namespace { set; }

        new bool DefaultNamespace { set; }
    }
}