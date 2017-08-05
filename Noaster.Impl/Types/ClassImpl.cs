using Microsoft.CodeAnalysis;
using Noaster.Api;
using Noaster.Impl.Api;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Impl.Utils;

namespace Noaster.Impl.Types
{
    public class ClassImpl : INamespaced, INamed, IHasSyntaxNodes, INamespaceMember, IClass
    {
        public INamespace Namespace { get; }
        public string Name { get; }

        public ClassImpl(INamespace nsp, string name)
        {
            Namespace = nsp;
            nsp?.Members.Add(this);
            Name = name;
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            yield return gen.ClassDeclaration(Name);
        }
    }
}