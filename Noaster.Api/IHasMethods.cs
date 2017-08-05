using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IHasMethods
    {
		IList<IMethod> Methods { get; }
	}
}