using System.Collections;

namespace Noaster.Api.Model
{
    public interface ICSharpEnum : ICSharpType, INamespaced, INamed, IVisibilityScoped, IAnnotationTarget,
        IInternal, IOrigin, IXmlDocCapable, IPropertyHolder, IMethodHolder, IMemberHolder,
        IFieldHolder, IInterfaceCapable, ITypeHolder, IStaticCapable
    {
        IEnumConstant getEnumConstant(string str);

        IList getEnumConstants();
    }
}