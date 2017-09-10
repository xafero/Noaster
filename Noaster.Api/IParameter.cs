namespace Noaster.Api
{
    public interface IParameter : INamed, ITyped
    {
        ParamModifier Modifier { get; set; }

        void Rename(string name);
    }
}