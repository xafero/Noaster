using Noaster.Api;
using Noaster.Impl.Parts;

namespace Noaster.Impl.Meta
{
    public static class NetFramework
    {
        public static IAttribute Net45 => GetTargetFramework("4.5");

        public static IAttribute GetTargetFramework(string ver)
        {
            var attr = new AttributeImpl("TargetFramework");
            attr.Values.Add($".NETFramework,Version=v{ver}");
            attr.Properties.Add("FrameworkDisplayName", $".NET Framework {ver}");
            return attr;
        }
    }
}