namespace Noaster.Api.Model.Source
{
    public interface IVisibilityScopedSource : IVisibilityScoped
    {
        object setPrivate();

        object setPublic();

        object setNamespacePrivate();

        object setProtected();

        object setVisibility(Visibility v);
    }
}