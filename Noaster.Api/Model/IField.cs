using System;

namespace Noaster.Api.Model
{
    public interface IField : IMember, IVisibilityScoped, IAnnotationTarget, IInternal,
        IOrigin, INamed, IFinalCapable, IStaticCapable
    {
        Type Type { get; }

        string StringInitializer { get; }

        string LiteralInitializer { get; }

        bool Transient { get; }

        bool Volatile { get; }
    }
}