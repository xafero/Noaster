using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Noaster.Impl.Utils
{
    public static class SyntaxExts
    {
        public static IEnumerable<SyntaxNode> GetParamNodes(this SyntaxGenerator gen, IHasParameters holder)
            => holder.Parameters.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));

        public static IEnumerable<SyntaxNode> GetMethNodes(this SyntaxGenerator gen, IHasMethods holder)
            => holder.Methods.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));

        public static IEnumerable<SyntaxNode> GetIntfNodes(this SyntaxGenerator gen, IHasInterfaces holder)
            => holder.Interfaces.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));

        public static IEnumerable<SyntaxNode> GetEvtNodes(this SyntaxGenerator gen, IHasEvents holder)
            => holder.Events.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));

        public static IEnumerable<SyntaxNode> GetPropNodes(this SyntaxGenerator gen, IHasProperties holder)
            => holder.Properties.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));

        public static IEnumerable<SyntaxNode> GetFldNodes(this SyntaxGenerator gen, IHasFields holder)
            => holder.Fields.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));

        public static IEnumerable<SyntaxNode> GetCstrNodes(this SyntaxGenerator gen, IHasConstructors holder)
            => holder.Constructors.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));

        public static IEnumerable<SyntaxNode> GetOperNodes(this SyntaxGenerator gen, IHasOperators holder)
            => holder.Operators.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));

        public static IEnumerable<SyntaxNode> GetIndxNodes(this SyntaxGenerator gen, IHasIndexers holder)
            => holder.Indexers.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));

        public static DeclarationModifiers ToDeclare(this Modifier mod)
        {
            var decl = DeclarationModifiers.None;
            if (mod.HasFlag(Modifier.Static)) decl = decl.WithIsStatic(true);
            if (mod.HasFlag(Modifier.Abstract)) decl = decl.WithIsAbstract(true);
            if (mod.HasFlag(Modifier.Virtual)) decl = decl.WithIsVirtual(true);
            if (mod.HasFlag(Modifier.Override)) decl = decl.WithIsOverride(true);
            if (mod.HasFlag(Modifier.Sealed)) decl = decl.WithIsSealed(true);
            return decl;
        }

        public static Accessibility ToAccessibility(this Visibility vis)
        {
            switch (vis)
            {
                case Visibility.Private: return Accessibility.Private;
                case Visibility.Protected: return Accessibility.Protected;
                case Visibility.Public: return Accessibility.Public;
                case Visibility.Internal: return Accessibility.Internal;
                case Visibility.ProtectedInternal: return Accessibility.ProtectedOrInternal;
            }
            return Accessibility.NotApplicable;
        }

        public static SyntaxToken[] ToKeyword(this Visibility vis)
        {
            var token = new SyntaxToken[1];
            switch (vis)
            {
                case Visibility.Private:
                    token[0] = SyntaxFactory.Token(SyntaxKind.PrivateKeyword);
                    break;
                case Visibility.Protected:
                    token[0] = SyntaxFactory.Token(SyntaxKind.ProtectedKeyword);
                    break;
                case Visibility.Public:
                    token[0] = SyntaxFactory.Token(SyntaxKind.PublicKeyword);
                    break;
                case Visibility.Internal:
                    token[0] = SyntaxFactory.Token(SyntaxKind.InternalKeyword);
                    break;
                case Visibility.ProtectedInternal:
                    token = new[]
                    {
                        SyntaxFactory.Token(SyntaxKind.ProtectedKeyword),
                        SyntaxFactory.Token(SyntaxKind.InternalKeyword)
                    };
                    break;
            }
            return token;
        }

        public static SyntaxToken[] ToKeyword(this ParamModifier mod)
        {
            var token = new SyntaxToken[1];
            switch (mod)
            {
                case ParamModifier.Ref:
                    token[0] = SyntaxFactory.Token(SyntaxKind.RefKeyword);
                    break;
                case ParamModifier.Out:
                    token[0] = SyntaxFactory.Token(SyntaxKind.OutKeyword);
                    break;
            }
            return token;
        }

        public static SyntaxTokenList ToList(this SyntaxToken[] token) => SyntaxFactory.TokenList(token);

        public static IEnumerable<AttributeListSyntax> GetAttrsNodes(this SyntaxGenerator gen, IHasAttributes holder)
            => holder.Attributes.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen))
                .OfType<AttributeListSyntax>();

        public static SyntaxList<AttributeListSyntax> ToList(this IEnumerable<AttributeListSyntax> nodes)
            => (new SyntaxList<AttributeListSyntax>()).AddRange(nodes);

        public static IEnumerable<SyntaxNode> GetNodesFromCode(string rawCode)
        {
            if (string.IsNullOrWhiteSpace(rawCode))
                return new SyntaxNode[0];
            var code = $"{{ {rawCode} }}";
            var tree = SyntaxFactory.ParseSyntaxTree(code, new CSharpParseOptions(kind: SourceCodeKind.Script));
            var root = tree.GetRoot().ChildNodes().Single().ChildNodes().Single();
            return root.ChildNodes();
        }

        public static SyntaxNode ToLiteral(object obj)
        {
            SyntaxToken token;
            SyntaxKind kind;
            var type = obj.GetType().FullName;
            switch (type)
            {
                case "System.String":
                    kind = SyntaxKind.StringLiteralExpression;
                    token = SyntaxFactory.Literal((string) obj);
                    break;
                case "System.Int32":
                    kind = SyntaxKind.NumericLiteralExpression;
                    token = SyntaxFactory.Literal((int) obj);
                    break;
                case "System.Boolean":
                    return SyntaxFactory.LiteralExpression((bool) obj
                        ? SyntaxKind.TrueLiteralExpression
                        : SyntaxKind.FalseLiteralExpression);
                default:
                    throw new InvalidOperationException(type);
            }
            return SyntaxFactory.LiteralExpression(kind, token);
        }

        public static IEnumerable<SyntaxNode> ToSyntaxNodes(IDictionary<string, SyntaxNode> dict)
            => dict.Select(o => SyntaxFactory.AssignmentExpression(
                SyntaxKind.SimpleAssignmentExpression,
                SyntaxFactory.IdentifierName(o.Key), (ExpressionSyntax) o.Value));

        public static AttributeListSyntax MakeAssemblyAttribute(this AttributeListSyntax attr)
            => attr.WithTarget(SyntaxFactory.AttributeTargetSpecifier(
                SyntaxFactory.Token(SyntaxKind.AssemblyKeyword)));

        public static SyntaxNode PatchAttributes(this CompilationUnitSyntax unit, IEnumerable<SyntaxNode> nodes)
            => unit.AddAttributeLists(nodes.OfType<AttributeListSyntax>().ToArray());
    }
}