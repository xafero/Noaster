namespace Noaster.Api.Model.Source
{
    public interface IStaticCapableSource : IStaticCapable
    {
        new bool Static { set; }
    }
}