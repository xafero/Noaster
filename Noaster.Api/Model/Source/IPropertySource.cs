namespace Noaster.Api.Model.Source
{
    public interface IPropertySource : IProperty, IInternal, IOrigin, INamed, IAnnotationTarget, INamedSource
    {
        IPropertySource setType(IType c);

        IPropertySource setType(string str);

        IPropertySource setType(ICSharpType jt);

        IMethodSource createAccessor();
        new IMethodSource getAccessor();

        IPropertySource removeAccessor();

        IMethodSource createMutator();
        new IMethodSource getMutator();

        IPropertySource removeMutator();

        IPropertySource setAccessible(bool b);

        IPropertySource setMutable(bool b);

        IFieldSource createField();
        new IFieldSource getField();

        IPropertySource removeField();
    }
}