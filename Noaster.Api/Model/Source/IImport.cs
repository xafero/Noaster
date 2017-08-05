namespace Noaster.Api.Model.Source
{
	public interface IImport : IInternal, IStaticCapableSource, IStaticCapable
	{
		string getNamespace();

		string getSimpleName();

		string QualifiedName { get; }

		bool isWildcard();

		IImport setName(string str);
	}
}