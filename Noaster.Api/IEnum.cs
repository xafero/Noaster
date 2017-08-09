using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IEnum : IType, IVisible
    {
        IList<IEnumVal> Values { get; }
    }
}