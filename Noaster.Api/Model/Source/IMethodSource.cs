using System;
using System.Collections;

namespace Noaster.Api.Model.Source
{
    public interface IMethodSource : IMethod, IAbstractable, IMember, IVisibilityScoped, IAnnotationTarget,
        IInternal, IOrigin, INamed, IFinalCapable, IStaticCapable, IGenericCapable, IAbstractableSource,
        IMemberSource, IAnnotationTargetSource, IVisibilityScopedSource, INamedSource, IXmlDocCapableSource,
        IXmlDocCapable, IFinalCapableSource, IStaticCapableSource, ILocationCapable, IGenericCapableSource
    {
        new IList getParameters();

        IMethodSource setBody(string str);

        IMethodSource setNative(bool b);

        IMethodSource setReturnType(ICSharpType jt);

        IMethodSource setConstructor(bool b);

        IParameterSource addParameter(string str1, string str2);

        IParameterSource addParameter(ICSharpType jt, string str);

        IParameterSource addParameter(Type type, string str2);

        IMethodSource setReturnTypeVoid();

        IMethodSource setReturnType(string str);

        IMethodSource addThrows(string str);

        IMethodSource setParameters(string str);

        IMethodSource setReturnType(IType c);

        IMethodSource setDefault(bool b);

        IMethodSource setSynchronized(bool b);

        // MethodSource setReturnType(Type t);

        IMethodSource addThrows(IType c);

        IMethodSource removeThrows(string str);

        IMethodSource removeThrows(IType c);

        IParameterSource addParameter(IType c, string str);

        IMethodSource removeParameter(IParameterSource ps);

        IMethodSource removeParameter(IType c, string str);

        IMethodSource removeParameter(string str1, string str2);

        IMethodSource removeParameter(ICSharpType jt, string str);
    }
}