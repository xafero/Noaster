using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IHasAttributes
    {
        IList<IAttribute> Attributes { get; }
    }
}