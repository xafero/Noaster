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

        public static T With<T>(this T visible, Visibility vis) where T : IVisible
        {
            visible.Visibility = vis;
            return visible;
        }

        public static T With<T>(this T modifiable, Modifier mod) where T : IModifiable
        {
            modifiable.Modifier = mod;
            return modifiable;
        }
    }
}