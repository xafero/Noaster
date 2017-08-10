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

        public static IContract AddImplements(this IHasInterfaces intf, string name)
        {
            var cntr = Noast.Create<IContract>(name);
            intf.Interfaces.Add(cntr);
            return cntr;
        }

        public static IAttribute AddAttribute(this IHasAttributes attrs, string name)
        {
            var attr = Noast.Create<IAttribute>(name);
            attrs.Attributes.Add(attr);
            return attr;
        }

        public static IParameter AddParameter(this IHasParameters parms, string name, string type,
            ParamModifier? mod = null)
        {
            var parm = Noast.Create<IParameter>(name);
            parm.Type = type;
            parm.Modifier = mod.GetValueOrDefault();
            parms.Parameters.Add(parm);
            return parm;
        }
        
        public static IEnumVal AddValue(this IEnum enm, string name)
        {
            var enmVal = Noast.Create<IEnumVal>(name);
            enm.Values.Add(enmVal);
            return enmVal;
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

        public static T ChildOf<T>(this T clazz, string type) where T : IClass
        {
            clazz.BaseType = Noaster.Create<IBase>(type);
            return clazz;
        }
    }
}