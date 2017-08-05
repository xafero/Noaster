using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IHasConstructors
    {
        IList<IConstructor> Constructors { get; }
    }
}