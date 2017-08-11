using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IAttribute : INamed
    {
        IList<object> Values { get; }
        IDictionary<string, object> Properties { get; }
    }
}