using System;

namespace Noaster.Api.Model
{

    public interface IAnnotationElement : IAnnotationTarget, IInternal, IOrigin, INamed
    {
        IType getType();

        IReadDefaultValue getDefaultValue();
    }
}