using System.Collections;

namespace Noaster.Api.Model
{
	public interface ITypeVariable : INamed, IInternal, IOrigin
	{
		IList getBounds();
	}
}