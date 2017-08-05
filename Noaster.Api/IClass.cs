namespace Noaster.Api
{
    public interface IClass : IType, IBase, IHasInterfaces, IHasConstructors, IHasEvents,
        IHasFields, IHasIndexers, IHasMethods, IHasOperators, IHasProperties, IVisible
    {
        IBase BaseType { get; }
    }
}