namespace Noaster.Api.Model
{
	public interface IVisibilityScoped
	{
		bool isPrivate();

		bool isPublic();

		bool isNamespacePrivate();

		bool isProtected();

		Visibility getVisibility();
	}
}