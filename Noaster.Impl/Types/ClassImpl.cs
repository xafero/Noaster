using Microsoft.CodeAnalysis;
using Noaster.Api;
using Noaster.Impl.Api;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Impl.Utils;
using System.Linq;

namespace Noaster.Impl.Types
{
    public class ClassImpl : INamespaced, INamed, IHasSyntaxNodes, INamespaceMember, IClass
    {
        public INamespace Namespace { get; }
        public string Name { get; }
        public IBase BaseType { get; }
        public IList<IContract> Interfaces { get; }

        public ClassImpl(INamespace nsp, string name)
        {
            Namespace = nsp;
            nsp?.Members.Add(this);
            Name = name;
            Interfaces = new List<IContract>();
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var bse = (BaseType as IHasSyntaxNodes)?.GetNodes(gen).SingleOrDefault();
            var itt = gen.GetIntfNodes(this);
            yield return gen.ClassDeclaration(Name, baseType: bse, interfaceTypes: itt);
        }
    }
}