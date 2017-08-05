using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IHasProperties
    {
        IList<IProperty> Properties { get; }
    }
}