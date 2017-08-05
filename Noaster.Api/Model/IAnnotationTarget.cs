using System.Collections;

namespace Noaster.Api.Model
{
	public interface IAnnotationTarget : IInternal, IOrigin
	{
		IList getAnnotations();

		bool hasAnnotation(IType c);

		bool hasAnnotation(string str);

		IAnnotation getAnnotation(IType c);

		IAnnotation getAnnotation(string str);
	}
}