using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IClass : IType, IBase, IHasInterfaces, IHasConstructors, IHasEvents, 
        IHasFields, IHasIndexers, IHasMethods, IHasOperators, IHasProperties
    {
        IBase BaseType { get; }
    }
}