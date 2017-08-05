using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;

namespace Noaster.Impl.Parts
{
    public class MethodImpl : IMethod, INamed, IHasSyntaxNodes
    {
        public string Name { get; }

        public MethodImpl(string name)
        {
            Name = name;
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            yield return gen.MethodDeclaration(Name);
        }
    }
}