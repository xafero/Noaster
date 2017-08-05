namespace Noaster.Api.Model.Source
{

    public interface IAnnotationElementSource : IAnnotationElement, IAnnotationTarget, IInternal,
        IOrigin, INamed, IAnnotationTargetSource, INamedSource
    {
        IAnnotationElementSource SetType(IType c);

        IAnnotationElementSource SetType(string str);

        IAnnotationElementSource SetType(ICSharpType jt);

        IDefaultValue DefaultValue { get; }
    }
}