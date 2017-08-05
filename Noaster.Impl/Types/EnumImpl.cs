using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;
using System.Collections.Generic;

namespace Noaster.Impl.Types
{
    public class EnumImpl : INamespaced, INamed, IHasSyntaxNodes, INamespaceMember, IEnum
    {
        public Visibility Visibility { get; set; }
        public INamespace Namespace { get; }
        public string Name { get; }

        public EnumImpl(INamespace nsp, string name)
        {
            Namespace = nsp;
            nsp?.Members.Add(this);
            Name = name;
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var acc = Visibility.ToAccessibility();
            yield return gen.EnumDeclaration(Name, accessibility: acc);
        }
    }
}