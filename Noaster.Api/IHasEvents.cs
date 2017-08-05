using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IHasEvents
    {
		IList<IEvent> Events { get; }
	}
}