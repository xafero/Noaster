namespace Noaster.Api
{
    public interface IClass : IType, IBase, IHasInterfaces, IHasConstructors, IHasEvents,
        IHasFields, IHasIndexers, IHasMethods, IHasOperators, IHasProperties, IVisible, IModifiable
    {
        IBase BaseType { get; set; }
    }
}