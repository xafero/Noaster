using System.Collections;

namespace Noaster.Api.Model
{
    public interface IGenericCapable
    {
        IList getTypeVariables();

        ITypeVariable getTypeVariable(string str);

        bool hasTypeVariable(string str);
    }
}