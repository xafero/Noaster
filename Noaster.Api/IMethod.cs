namespace Noaster.Api
{
    public interface IMethod : IHasParameters, IVisible, IModifiable, INamed,
        IHasReturnType, IHasBody, IHasAttributes
    {
        void Rename(string name);
    }
}