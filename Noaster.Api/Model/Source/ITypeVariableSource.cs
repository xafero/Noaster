namespace Noaster.Api.Model.Source
{
	public interface ITypeVariableSource : ITypeVariable, INamed, IInternal,IOrigin, INamedSource
	{
		ITypeVariableSource setBounds(params ICSharpType[] jtarr);

		ITypeVariableSource setBounds(params IType[] carr);

		ITypeVariableSource setBounds(params string[] strarr);

		ITypeVariableSource removeBounds();
	}
}