using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IHasUsings
    {
        ISet<IUsing> Usings { get; }
    }
}