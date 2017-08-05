using System.Collections;

namespace Noaster.Api.Model.Source
{
    public interface IFieldHolderSource : IFieldHolder, IMemberHolder, IMemberHolderSource
    {
        IFieldSource addField();

        IFieldSource addField(string str);

        ICSharpSource removeField(IField f);
        new IFieldSource getField(string str);
        new IList getFields();
    }
}