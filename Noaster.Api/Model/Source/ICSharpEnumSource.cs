using System.Collections;

namespace Noaster.Api.Model.Source
{
    public interface ICSharpEnumSource : ICSharpEnum, ICSharpType, INamespaced, INamed, IVisibilityScoped,
        IAnnotationTarget, IInternal, IOrigin, IXmlDocCapable, IPropertyHolder, IMethodHolder,
        IMemberHolder, IFieldHolder, IInterfaceCapable, ITypeHolder, IStaticCapable, ICSharpSource,
        INamespacedSource, IImporter, INamedSource, IVisibilityScopedSource, IAnnotationTargetSource,
        IXmlDocCapableSource, IInterfaceCapableSource, IFieldHolderSource, IMemberHolderSource,
        IMethodHolderSource, IPropertyHolderSource, ITypeHolderSource, IStaticCapableSource
    {
        new IEnumConstantSource getEnumConstant(string str);
        new IList getEnumConstants();

        IEnumConstantSource addEnumConstant();

        IEnumConstantSource addEnumConstant(string str);
    }
}