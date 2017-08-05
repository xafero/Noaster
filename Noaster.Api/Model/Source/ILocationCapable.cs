namespace Noaster.Api.Model.Source
{
	public interface ILocationCapable
	{
		int getStartPosition();

		int getEndPosition();

		int getLineNumber();

		int getColumnNumber();
	}
}
