namespace Noaster.Api.Model.Source
{
	public interface ICSharpClassSource : ICSharpClass, ICSharpType, INamespaced, INamed, 
		IVisibilityScoped, IAnnotationTarget, IInternal,IOrigin, IXmlDocCapable, 
		IPropertyHolder, IMethodHolder, IMemberHolder, IFieldHolder, IInterfaceCapable, 
		IGenericCapable, IExtendable, IAbstractable, ITypeHolder, IFinalCapable, IStaticCapable,
		ICSharpSource, INamespacedSource, IImporter, INamedSource, IVisibilityScopedSource, 
		IAnnotationTargetSource, IXmlDocCapableSource, IInterfaceCapableSource, 
		IFieldHolderSource, IMemberHolderSource, IMethodHolderSource, IGenericCapableSource,
		IExtendableSource, IAbstractableSource, IPropertyHolderSource, ITypeHolderSource,
		IFinalCapableSource, IStaticCapableSource
	{
	}
}