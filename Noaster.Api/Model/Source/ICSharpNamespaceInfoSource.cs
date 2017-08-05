namespace Noaster.Api.Model.Source
{
	public interface ICSharpNamespaceInfoSource : ICSharpNamespaceInfo, ICSharpType, INamespaced, INamed, 
		IVisibilityScoped, IAnnotationTarget, IInternal,IOrigin, IXmlDocCapable, ICSharpSource,
		INamespacedSource, IImporter, INamedSource, IVisibilityScopedSource, IAnnotationTargetSource, IXmlDocCapableSource
	{
	}
}