using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IHasParameters
    {
        IList<IParameter> Parameters { get; }
    }
}