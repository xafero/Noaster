namespace Noaster.Api.Model.Source
{
    public interface IInterfaceCapableSource : IInterfaceCapable
    {
        ICSharpSource addInterface(string str);

        ICSharpSource addInterface(IType c);

        ICSharpSource implementInterface(IType c);

        ICSharpSource implementInterface(ICSharpInterface ji);

        ICSharpSource addInterface(ICSharpInterface ji);

        ICSharpSource removeInterface(string str);

        ICSharpSource removeInterface(IType c);

        ICSharpSource removeInterface(ICSharpInterface ji);
    }
}