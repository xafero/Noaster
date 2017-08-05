using System.Collections;

namespace Noaster.Api.Model.Source
{
	public interface IImporter
	{
		IList getImports();

		IImport addImport(IImport i);

		bool hasImport(IType c);

		bool hasImport(string str);

		bool requiresImport(IType c);

		bool requiresImport(string str);

		bool hasImport(ICSharpType jt);

		bool hasImport(IImport i);

		IImport getImport(string str);

		IImport getImport(IType c);

		IImport getImport(ICSharpType jt);

		IImport getImport(IImport i);

		string resolveType(string str);

		IImport addImport(string str);

		IImport addImport(IType c);

		IImport addImport(ICSharpType jt);

		// Import addImport(org.jboss.forge.roaster.model.Type t);

		ICSharpSource removeImport(string str);

		ICSharpSource removeImport(IType c);

		ICSharpSource removeImport(ICSharpType jt);

		ICSharpSource removeImport(IImport i);
	}
}