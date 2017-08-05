using Noaster.Api.Model.Source;
using Noaster.Model.Impl;
using System;
using System.Collections.Generic;

namespace Noaster.Dist
{
    public static class Noaster
    {
        static readonly IDictionary<Type, Func<object>> factories = new Dictionary<Type, Func<object>>
        {
            { typeof(ICSharpClassSource), () => new CSharpClassImpl() }
        };

        public static T Create<T>()
        {
            var type = typeof(T);
            Func<object> fact;
            if (factories.TryGetValue(type, out fact))
                return (T)fact();
            throw new InvalidOperationException(type.FullName);
        }
    }
}