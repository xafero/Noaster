using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;
using System.Collections.Generic;
using System.Linq;

namespace Noaster.Impl.Types
{
    public class EnumImpl : INamespaced, INamed, IHasSyntaxNodes, INamespaceMember, IEnum
    {
        public Visibility Visibility { get; set; }
        public INamespace Namespace { get; }
        public string Name { get; }
        public IList<IEnumVal> Values { get; }

        public EnumImpl(INamespace nsp, string name)
        {
            Namespace = nsp;
            nsp?.Members.Add(this);
            Name = name;
            Values = new List<IEnumVal>();
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var acc = Visibility.ToAccessibility();
            var mmb = Values.OfType<IHasSyntaxNodes>().SelectMany(v => v.GetNodes(gen));
            yield return gen.EnumDeclaration(Name, members: mmb, accessibility: acc);
        }
    }
}