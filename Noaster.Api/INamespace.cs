using System.Collections.Generic;

namespace Noaster.Api
{
    public interface INamespace : INamed, INamespaceMember
    {
        ISet<IUsing> Usings { get; }

        ISet<INamespaceMember> Members { get; }
    }
}