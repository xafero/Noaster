namespace Noaster.Api.Model.Source
{
    public interface ICSharpSource : ICSharpType, INamespaced, INamed, IVisibilityScoped, IAnnotationTarget,
        IInternal, IOrigin, IXmlDocCapable, INamespacedSource, IImporter, INamedSource, IVisibilityScopedSource,
        IAnnotationTargetSource, IXmlDocCapableSource
    {
        new ICSharpSource getEnclosingType();
    }
}