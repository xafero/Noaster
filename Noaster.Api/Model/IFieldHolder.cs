using System.Collections;

namespace Noaster.Api.Model
{
	public interface IFieldHolder : IMemberHolder
	{
		bool hasField(IField f);

		IList getFields();

		bool hasField(string str);

		IField getField(string str);
	}
}