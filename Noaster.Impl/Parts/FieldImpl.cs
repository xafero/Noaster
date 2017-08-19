using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.CSharp;

namespace Noaster.Impl.Parts
{
    public class FieldImpl : IField, INamed, IHasSyntaxNodes
    {
        public Visibility Visibility { get; set; }
        public string Type { get; set; }
        public string Name { get; }

        public FieldImpl(string name, string type = null)
        {
            Name = name;
            Type = type ?? typeof(object).FullName;
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var type = SyntaxFactory.ParseTypeName(Type);
            var acc = Visibility.ToAccessibility();
            yield return gen.FieldDeclaration(Name, type, accessibility: acc);
        }
    }
}