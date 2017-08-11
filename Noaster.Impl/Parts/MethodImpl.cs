using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;

namespace Noaster.Impl.Parts
{
    public class MethodImpl : IMethod, INamed, IHasSyntaxNodes, IVisible
    {
        public Visibility Visibility { get; set; }
        public Modifier Modifier { get; set; }
        public string Name { get; }
        public IList<IParameter> Parameters { get; }
        public string ReturnType { get; set; }
        public string Body { get; set; }
        public IList<IAttribute> Attributes { get; }

        public MethodImpl(string name, string type = null)
        {
            Name = name;
            ReturnType = type ?? "void";
            Parameters = new List<IParameter>();
            Attributes = new List<IAttribute>();
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var acc = Visibility.ToAccessibility();
            var mod = Modifier.ToDeclare();
            var type = SyntaxFactory.ParseTypeName(ReturnType);
            var stats = SyntaxExts.GetNodesFromCode(Body);
            var meth = (MethodDeclarationSyntax) gen.MethodDeclaration(Name, gen.GetParamNodes(this),
                accessibility: acc, modifiers: mod, returnType: type, statements: stats);
            yield return meth.WithAttributeLists(gen.GetAttrsNodes(this).ToList());
        }
    }
}