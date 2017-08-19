using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;
using System.Collections.Generic;

namespace Noaster.Impl.Base
{
    public struct UsingImpl : IUsing, INamed, IHasSyntaxNodes
    {
        public string Name { get; }

        public UsingImpl(string name)
        {
            Name = name;
        }

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            yield return gen.NamespaceImportDeclaration(Name);
        }

        public override string ToString() => RoslynTool.ToString(this);
    }
}