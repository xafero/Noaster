using System.Collections;

namespace Noaster.Api.Model
{
	public interface IPropertyHolder : IMethodHolder, IMemberHolder, IFieldHolder, IInterfaceCapable
	{
		IList getProperties();

		bool hasProperty(string str);

		bool hasProperty(IProperty p);

		IProperty getProperty(string str);

		IList getProperties(IType c);
	}
}