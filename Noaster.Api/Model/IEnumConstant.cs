using System.Collections;

namespace Noaster.Api.Model
{

    public interface IEnumConstant : IInternal, IOrigin, IAnnotationTarget, INamed
    {

        IList getConstructorArguments();

        IReadBody getBody();
    }
}