using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;
using System.Collections.Generic;

namespace Noaster.Impl.Parts
{
    public class PropertyImpl : IProperty, INamed, IHasSyntaxNodes, IAutoProperty
    {
        public Visibility Visibility { get; set; }
        public string Type { get; set; }
        public string Name { get; }
        public string Getter { get; set; }
        public string Setter { get; set; }

        public PropertyImpl(string name, string type = null)
        {
            Name = name;
            Type = type ?? typeof(object).FullName;
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var type = SyntaxFactory.ParseTypeName(Type);
            var prop = SyntaxFactory.PropertyDeclaration(type, Name)
                .WithModifiers(Visibility.ToKeyword().ToList());
            var isAuto = Getter == null && Setter == null;
            if (isAuto || Getter != null)
                prop = prop.AddAccessorListAccessors(
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                        .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)
                        ));
            if (isAuto || Setter != null)
                prop = prop.AddAccessorListAccessors(
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                        .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)
                        ));
            yield return prop;
        }
    }
}