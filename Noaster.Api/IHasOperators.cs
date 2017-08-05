using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IHasOperators
    {
		IList<IOperator> Operators { get; }
	}
}