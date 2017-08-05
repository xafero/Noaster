using Noaster.Api;

using Noast = Noaster.Dist.Noaster;

namespace Noaster.Dist
{
    public static class FluentExts
    {
        public static IUsing AddUsing(this INamespace nsp, string name)
        {
            var usig = Noast.Create<IUsing>(name);
            nsp.Usings.Add(usig);
            return usig;
        }
    }
}