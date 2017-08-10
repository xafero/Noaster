using Noaster.Api;

namespace Noaster.Dist
{
    public static class ApiExts
    {
        public static bool IsRef(this IParameter parm) => parm.Modifier == ParamModifier.Ref;
        
        public static bool IsOut(this IParameter parm) => parm.Modifier == ParamModifier.Out;
    }
}