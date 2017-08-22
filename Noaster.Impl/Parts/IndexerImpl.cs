using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Noaster.Impl.Parts
{
    public class IndexerImpl : IIndexer, INamed, IHasSyntaxNodes
    {
        public Visibility Visibility { get; set; }
        public string Type { get; set; }
        public string Name { get; }
        public IList<IParameter> Parameters { get; }
        public string Getter { get; set; }
        public string Setter { get; set; }

        public IndexerImpl(string name, string type = null)
        {
            Name = name;
            Type = type ?? typeof(object).FullName;
            Parameters = new List<IParameter>();
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var type = SyntaxFactory.ParseTypeName(Type);
            var parms = gen.GetParamNodes(this).OfType<ParameterSyntax>();
            var indx = SyntaxFactory.IndexerDeclaration(type)
                .WithModifiers(Visibility.ToKeyword().ToList())
                .AddParameterListParameters(parms.ToArray());
            var isAuto = Getter == null && Setter == null;
            if (isAuto || Getter != null)
                indx = indx.AddAccessorListAccessors(
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                        .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)
                        ));
            if (isAuto || Setter != null)
                indx = indx.AddAccessorListAccessors(
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                        .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)
                        ));
            yield return indx;
        }
    }
}