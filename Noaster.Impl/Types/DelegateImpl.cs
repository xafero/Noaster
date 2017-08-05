using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;

namespace Noaster.Impl.Types
{
    public class DelegateImpl : INamespaced, INamed, IHasSyntaxNodes, INamespaceMember
    {
        public INamespace Namespace { get; }
        public string Name { get; }

        public DelegateImpl(INamespace nsp, string name)
        {
            Namespace = nsp;
            nsp?.Members.Add(this);
            Name = name;
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            yield return gen.DelegateDeclaration(Name);
        }
    }
}