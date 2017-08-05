namespace Noaster.Api.Model.Source
{
	public interface ICSharpInterfaceSource : ICSharpInterface, ICSharpType, INamespaced, INamed,
		IVisibilityScoped, IAnnotationTarget, IInternal,IOrigin, IXmlDocCapable, IFieldHolder,
		IMemberHolder, IMethodHolder, IInterfaceCapable, IGenericCapable, IPropertyHolder,
		ITypeHolder, IStaticCapable, ICSharpSource, INamespacedSource, IImporter, INamedSource, 
		IVisibilityScopedSource, IAnnotationTargetSource, IXmlDocCapableSource, IFieldHolderSource, 
		IMemberHolderSource, IMethodHolderSource, IGenericCapableSource, IInterfaceCapableSource, 
		IPropertyHolderSource, ITypeHolderSource, IStaticCapableSource
	{
	}
}