using System.Collections;

namespace Noaster.Api.Model.Source
{
    public interface IGenericCapableSource : IGenericCapable
    {
        new IList getTypeVariables();

        ITypeVariableSource getTypeVariable(string str);

        ITypeVariableSource addTypeVariable();

        ITypeVariableSource addTypeVariable(string str);

        object removeTypeVariable(string str);

        object removeTypeVariable(ITypeVariable tv);
    }
}