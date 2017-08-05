using Noaster.Api;
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
            { typeof(IClass), (p, n) => new ClassImpl(p, n) }
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