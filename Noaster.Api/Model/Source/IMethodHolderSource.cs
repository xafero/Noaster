using System.Collections;

namespace Noaster.Api.Model.Source
{
    public interface IMethodHolderSource : IMethodHolder, IMemberHolder, IMemberHolderSource
    {
        IMethodSource addMethod(IMethod m);
        new IMethodSource getMethod(string str, params IType[] carr);

        // MethodSource addMethod(Method m);

        IMethodSource addMethod();

        IList getMethods();

        IMethodSource addMethod(string str);

        IMethodSource getMethod(string str);

        IMethodSource getMethod(string str, params string[] strarr);

        ICSharpSource removeMethod(IMethod m);
    }
}