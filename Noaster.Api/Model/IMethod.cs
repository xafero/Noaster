using System.Collections;

namespace Noaster.Api.Model
{
    public interface IMethod : IAbstractable, IMember, IVisibilityScoped, IAnnotationTarget,
        IInternal, IOrigin, INamed, IFinalCapable, IStaticCapable, IGenericCapable
    {
        bool isNative();

        bool isReturnTypeVoid();

        IType getReturnType();

        IList getThrownExceptions();

        bool isSynchronized();

        string getBody();

        bool isConstructor();

        IList getParameters();

        string toSignature();

        bool isDefault();
    }
}