using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;
using System;

namespace Noaster.Impl.Parts
{
    public class OperatorImpl : IOperator, INamed, IHasSyntaxNodes
    {
        public string Name { get; }

        public OperatorImpl(string name)
        {
            Name = name;
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            OperatorKind kind;
            Enum.TryParse(Name, true, out kind);
            yield return gen.OperatorDeclaration(kind);
        }
    }
}