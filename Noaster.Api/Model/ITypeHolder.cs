using System.Collections;

namespace Noaster.Api.Model
{
	public interface ITypeHolder
	{
		IList getNestedTypes();

		bool hasNestedType(string str);

		bool hasNestedType(ICSharpType jt);

		bool hasNestedType(IType c);

		ICSharpType getNestedType(string str);
	}
}