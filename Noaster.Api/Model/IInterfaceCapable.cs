using System.Collections;

namespace Noaster.Api.Model
{
	public interface IInterfaceCapable
	{
		IList getInterfaces();

		bool hasInterface(string str);

		bool hasInterface(IType c);

		bool hasInterface(ICSharpInterface ji);
	}
}