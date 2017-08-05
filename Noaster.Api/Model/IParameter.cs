namespace Noaster.Api.Model
{
	public interface IParameter : IAnnotationTarget, IInternal, IOrigin, IFinalCapable
	{
		string getName();

		IType getType();

		bool isVarArgs();
	}
}