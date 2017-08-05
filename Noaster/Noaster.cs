using Noaster.Api;
using Noaster.Impl.Base;
using Noaster.Impl.Types;
using System;
using System.Collections.Generic;

namespace Noaster.Dist
{
    public static class Noaster
    {
        static readonly IDictionary<Type, Func<INamespace, string, object>> factories =
            new Dictionary<Type, Func<INamespace, string, object>>
        {
            { typeof(IClass), (p, n) => new ClassImpl(p, n) },
            { typeof(IStruct), (p, n) => new StructImpl(p, n) },
            { typeof(IDelegate), (p, n) => new DelegateImpl(p, n) },
            { typeof(IEnum), (p, n) => new EnumImpl(p, n) },
            { typeof(IInterface), (p, n) => new InterfaceImpl(p, n) },
            { typeof(INamespace), (p, n) => new NamespaceImpl(n, p) },
            { typeof(IUsing), (p, n) => new UsingImpl(n) }
        };

        public static T Create<T>(string name, INamespace nsp = null)
        {
            var type = typeof(T);
            Func<INamespace, string, object> fact;
            if (factories.TryGetValue(type, out fact))
                return (T)fact(nsp, name);
            throw new InvalidOperationException(type.FullName);
        }
    }
}