namespace Noaster.Api
{
    public enum Visibility
    {
        None = 0,

        Public = 2 ^ 0,

        Private = 2 ^ 1,

        Protected = 2 ^ 2,

        Internal = 2 ^ 3,

        ProtectedInternal = 2 ^ 4
    }
}