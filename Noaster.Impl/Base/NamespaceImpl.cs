using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using System.Linq;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;

namespace Noaster.Impl.Base
{
    public class NamespaceImpl : INamespace, INamespaced, INamed, IHasSyntaxNodes
    {
        public INamespace Namespace { get; }
        public string Name { get; }

        public NamespaceImpl(string name, INamespace nsp = null)
        {
            Namespace = nsp;
            nsp?.Members.Add(this);
            Name = name;
        }

        public ISet<IUsing> Usings { get; } = new HashSet<IUsing>();
        public ISet<INamespaceMember> Members { get; } = new HashSet<INamespaceMember>();

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var contents = Usings.OfType<IHasSyntaxNodes>().Concat(
                Members.OfType<IHasSyntaxNodes>()).Select(m => m.GetNodes(gen))
                .SelectMany(n => n);
            yield return gen.NamespaceDeclaration(Name, contents);
        }
    }
}