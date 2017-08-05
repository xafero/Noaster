using System.Collections;

namespace Noaster.Api.Model.Source
{
    public interface IAnnotationTargetSource : IAnnotationTarget, IInternal, IOrigin
    {
        void removeAllAnnotations();

        IAnnotationSource addAnnotation(IType c);
        new IList getAnnotations();

        IAnnotationSource getAnnotation(IType c);

        IAnnotationSource getAnnotation(string str);

        IAnnotationSource addAnnotation();

        IAnnotationSource addAnnotation(string str);

        object removeAnnotation(IAnnotation a);
    }
}