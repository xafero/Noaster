using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;

namespace Noaster.Impl.Parts
{
    public class AttributeImpl : IAttribute, IHasSyntaxNodes
    {
        public string Name { get; }

        public AttributeImpl(string name)
        {
            Name = name;
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var attr = (AttributeListSyntax) gen.Attribute(Name);
            yield return attr;
        }
    }
}