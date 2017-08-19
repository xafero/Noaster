using System.Collections.Generic;

namespace Noaster.Api
{
    public interface INamespace : INamed, INamespaceMember, IHasUsings
    {
        ISet<INamespaceMember> Members { get; }
    }
}