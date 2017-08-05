using System.Collections;

namespace Noaster.Api.Model.Source
{
    public interface ICSharpAnnotationSource : ICSharpAnnotation, ICSharpType, INamespaced, INamed,
        IVisibilityScoped, IAnnotationTarget, IInternal, IOrigin, IXmlDocCapable, ITypeHolder,
        ICSharpSource, INamespacedSource, IImporter, INamedSource, IVisibilityScopedSource,
        IAnnotationTargetSource, IXmlDocCapableSource, ITypeHolderSource
    {
        new IAnnotationElementSource getAnnotationElement(string str);
        new IList getAnnotationElements();

        IAnnotationElementSource addAnnotationElement();

        IAnnotationElementSource addAnnotationElement(string str);

        ICSharpAnnotationSource removeAnnotationElement(IAnnotationElement ae);
    }
}