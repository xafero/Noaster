using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;

namespace Noaster.Impl.Types
{
    public class DelegateImpl : INamespaced, INamed, IHasSyntaxNodes, INamespaceMember, IDelegate
    {
        public Visibility Visibility { get; set; }
        public INamespace Namespace { get; }
        public string Name { get; }
        public IList<IParameter> Parameters { get; }

        public DelegateImpl(INamespace nsp, string name)
        {
            Namespace = nsp;
            nsp?.Members.Add(this);
            Name = name;
            Parameters = new List<IParameter>();
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var acc = Visibility.ToAccessibility();
            yield return gen.DelegateDeclaration(Name, gen.GetParamNodes(this), accessibility: acc);
        }
    }
}