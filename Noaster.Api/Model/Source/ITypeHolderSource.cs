using System.Collections;

namespace Noaster.Api.Model.Source
{
    public interface ITypeHolderSource : ITypeHolder
    {
        IList getNestedTypes();
        new ICSharpSource getNestedType(string str);

        ICSharpSource addNestedType(IType c);

        ICSharpSource addNestedType(string str);

        ICSharpSource addNestedType(ICSharpSource js);

        ICSharpSource removeNestedType(ICSharpSource js);
    }
}