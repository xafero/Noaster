namespace Noaster.Api.Model
{
    public interface ICSharpNamespaceInfo : ICSharpType, INamespaced, INamed, IVisibilityScoped, IAnnotationTarget,
        IInternal, IOrigin, IXmlDocCapable
    {
    }
}