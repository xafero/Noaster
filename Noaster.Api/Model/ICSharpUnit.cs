using System.Collections;

namespace Noaster.Api.Model
{
	public interface ICSharpUnit
	{
		ICSharpType getGoverningType();

		IList getTopLevelTypes();

		string toUnformattedString();
	}
}