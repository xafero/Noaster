namespace Noaster.Api.Model.Source
{

    public interface IEnumConstantSource : IEnumConstant, IInternal, IOrigin, IAnnotationTarget,
        INamed, IAnnotationTargetSource, INamedSource, IXmlDocCapableSource, IXmlDocCapable
    {
        IEnumConstantSource SetConstructorArguments(params string[] strarr);

        IBody Body { get; }

        IEnumConstantSource RemoveBody();
    }
}