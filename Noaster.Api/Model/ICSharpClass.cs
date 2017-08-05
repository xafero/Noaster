namespace Noaster.Api.Model
{
    public interface ICSharpClass : ICSharpType, INamespaced, INamed, IVisibilityScoped, IAnnotationTarget,
        IInternal, IOrigin, IXmlDocCapable, IPropertyHolder, IMethodHolder,
        IMemberHolder, IFieldHolder, IInterfaceCapable, IGenericCapable, IExtendable,
        IAbstractable, ITypeHolder, IFinalCapable, IStaticCapable
    {
        bool isLocalClass();
    }
}