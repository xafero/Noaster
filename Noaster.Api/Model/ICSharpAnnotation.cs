using System.Collections;

namespace Noaster.Api.Model
{
	public interface ICSharpAnnotation : ICSharpType, INamespaced, INamed, IVisibilityScoped, IAnnotationTarget, 
		IInternal, IOrigin, IXmlDocCapable, ITypeHolder
	{
		bool hasAnnotationElement(string str);

		bool hasAnnotationElement(IAnnotationElement ae);

		IAnnotationElement getAnnotationElement(string str);

		IList getAnnotationElements();
	}
}