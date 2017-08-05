using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IHasFields
    {
		IList<IField> Fields { get; }
	}
}