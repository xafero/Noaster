using System.Collections;

namespace Noaster.Api.Model
{
    public interface IMethodHolder : IMemberHolder
    {
        IList getMethods();

        bool hasMethod(IMethod m);

        bool hasMethodSignature(IMethod m);

        bool hasMethodSignature(string str);

        bool hasMethodSignature(string str, params string[] strarr);

        bool hasMethodSignature(string str, params IType[] carr);

        IMethod getMethod(string str);

        IMethod getMethod(string str, params string[] strarr);

        IMethod getMethod(string str, params IType[] carr);
    }
}
