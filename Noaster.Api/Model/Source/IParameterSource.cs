namespace Noaster.Api.Model.Source
{
    public interface IParameterSource : IParameter, IAnnotationTarget, IInternal, IOrigin, IFinalCapable,
        IAnnotationTargetSource, IFinalCapableSource
    {
        IParameterSource setVarArgs(bool b);
    }
}