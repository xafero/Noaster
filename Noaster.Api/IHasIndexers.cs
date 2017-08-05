using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IHasIndexers
    {
		IList<IIndexer> Indexers { get; }
	}
}