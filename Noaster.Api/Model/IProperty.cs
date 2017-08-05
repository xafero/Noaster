namespace Noaster.Api.Model
{
	public interface IProperty : IInternal, IOrigin, INamed, IAnnotationTarget
	{
		IType getType();

		bool hasField();

		IField getField();

		bool isAccessible();

		bool isMutable();

		IMethod getAccessor();

		IMethod getMutator();
	}
}