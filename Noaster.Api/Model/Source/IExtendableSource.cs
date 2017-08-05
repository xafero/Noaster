namespace Noaster.Api.Model.Source
{
	public interface IExtendableSource : IExtendable
	{
		ICSharpType setSuperType(ICSharpType jt);

		ICSharpType setSuperType(IType c);

		ICSharpType extendSuperType(IType c);

		ICSharpType extendSuperType(ICSharpClass jc);

		ICSharpType setSuperType(string str);
	}
}