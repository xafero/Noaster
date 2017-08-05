using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;
using System.Collections.Generic;

namespace Noaster.Impl.Types
{
    public class StructImpl : INamespaced, INamed, IHasSyntaxNodes, INamespaceMember, IStruct
    {
        public INamespace Namespace { get; }
        public string Name { get; }

        public StructImpl(INamespace nsp, string name)
        {
            Namespace = nsp;
            nsp?.Members.Add(this);
            Name = name;
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            yield return gen.StructDeclaration(Name);
        }
    }
}