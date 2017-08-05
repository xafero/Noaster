namespace Noaster.Api.Model.Source
{
    public interface IMemberSource : IMember, IVisibilityScoped, IAnnotationTarget,
        IInternal, IOrigin, INamed, IFinalCapable, IStaticCapable, IAnnotationTargetSource,
        IVisibilityScopedSource, INamedSource, IXmlDocCapableSource, IXmlDocCapable,
        IFinalCapableSource, IStaticCapableSource, ILocationCapable
    {
    }
}