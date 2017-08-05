namespace Noaster.Api.Model.Source
{
    public interface IBody : IReadBody, ICSharpType, INamespaced, INamed, IVisibilityScoped,
        IAnnotationTarget, IInternal, IOrigin, IXmlDocCapable, IFieldHolder, IMemberHolder,
        IMethodHolder, ICSharpSource, INamespacedSource, IImporter, INamedSource, IVisibilityScopedSource,
        IAnnotationTargetSource, IXmlDocCapableSource, IFieldHolderSource, IMemberHolderSource,
        IMethodHolderSource, ITypeHolderSource, ITypeHolder
    {
    }
}