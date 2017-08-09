using Noaster.Api;
using Noaster.Impl.Base;
using Noaster.Impl.Parts;
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
            { typeof(IEnumVal), (p, n) => new EnumValueImpl(n) },
            { typeof(IInterface), (p, n) => new InterfaceImpl(p, n) },
            { typeof(INamespace), (p, n) => new NamespaceImpl(n, p) },
            { typeof(IUsing), (p, n) => new UsingImpl(n) },
            { typeof(IMethod), (p, n) => new MethodImpl(n) },
            { typeof(IProperty), (p, n) => new PropertyImpl(n) },
            { typeof(IEvent), (p, n) => new EventImpl(n) },
            { typeof(IField), (p, n) => new FieldImpl(n) },
            { typeof(IOperator), (p, n) => new OperatorImpl(n) },
            { typeof(IIndexer), (p, n) => new IndexerImpl(n) },
            { typeof(IConstructor), (p, n) => new ConstructorImpl(n) },
            { typeof(IParameter), (p, n) => new ParameterImpl(n) },
            { typeof(IAttribute), (p, n) => new AttributeImpl(n) }
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