namespace Noaster.Api.Model.Source
{
    public interface IAbstractableSource : IAbstractable
    {
        new bool Abstract { set; }
    }
}