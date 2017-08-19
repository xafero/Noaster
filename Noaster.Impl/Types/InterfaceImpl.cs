using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;
using System.Collections.Generic;
using System.Linq;

namespace Noaster.Impl.Types
{
    public class InterfaceImpl : INamespaced, INamed, IHasSyntaxNodes, INamespaceMember, IInterface
    {
        public Visibility Visibility { get; set; }
        public INamespace Namespace { get; }
        public string Name { get; }
        public IList<IContract> Interfaces { get; }
        public IList<IMethod> Methods { get; }
        public IList<IProperty> Properties { get; }
        public IList<IEvent> Events { get; }

        public InterfaceImpl(INamespace nsp, string name)
        {
            Namespace = nsp;
            nsp?.Members.Add(this);
            Name = name;
            Interfaces = new List<IContract>();
            Methods = new MethodList(this);
            Properties = new List<IProperty>();
            Events = new List<IEvent>();
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var itt = gen.GetIntfNodes(this);
            var mmb = gen.GetMethNodes(this).Concat(gen.GetPropNodes(this)).Concat(gen.GetEvtNodes(this));
            var acc = Visibility.ToAccessibility();
            yield return gen.InterfaceDeclaration(Name, interfaceTypes: itt, members: mmb, accessibility: acc);
        }
    }
}