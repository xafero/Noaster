namespace Noaster.Api.Model.Source
{
    public interface INamedSource : INamed
    {
        new string Name { set; }
    }
}