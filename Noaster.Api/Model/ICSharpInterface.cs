namespace Noaster.Api.Model
{
    public interface ICSharpInterface : ICSharpType, INamespaced, INamed, IVisibilityScoped, IAnnotationTarget,
        IInternal, IOrigin, IXmlDocCapable, IFieldHolder, IMemberHolder, IMethodHolder,
        IInterfaceCapable, IGenericCapable, IPropertyHolder, ITypeHolder, IStaticCapable
    {
    }
}