using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace Noaster.Impl.Parts
{
    public class OperatorImpl : IOperator, INamed, IHasSyntaxNodes
    {
        public Visibility Visibility { get; set; }
        public Modifier Modifier { get; set; }
        public string Name { get; }
        public IList<IParameter> Parameters { get; }
        public string ReturnType { get; set; }

        public OperatorImpl(string name, string type = null)
        {
            Name = name;
            Parameters = new List<IParameter>();
            ReturnType = type ?? "void";
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            OperatorKind kind;
            Enum.TryParse(Name, true, out kind);
            var acc = Visibility.ToAccessibility();
            var mod = Modifier.ToDeclare();
            var type = SyntaxFactory.ParseTypeName(ReturnType);
            yield return gen.OperatorDeclaration(kind, gen.GetParamNodes(this),
                accessibility: acc, modifiers: mod, returnType: type);
        }
    }
}