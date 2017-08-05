using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IHasInterfaces
    {
        IList<IContract> Interfaces { get; }
    }
}