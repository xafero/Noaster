namespace Noaster.Api.Model
{
	public interface ISyntaxError
	{
		string getDescription();

		int getLine();

		int getColumn();

		bool isError();

		bool isWarning();
	}
}