namespace Noaster.Api.Model.Source
{
    public interface IFinalCapableSource : IFinalCapable
    {
        new bool Final { set; }
    }
}