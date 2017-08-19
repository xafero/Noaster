using Microsoft.CodeAnalysis;
using Noaster.Api;
using Noaster.Impl.Api;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Impl.Utils;
using System.Linq;

namespace Noaster.Impl.Types
{
    public class ClassImpl : INamespaced, INamed, IHasSyntaxNodes, INamespaceMember, IClass
    {
        public Visibility Visibility { get; set; }
        public Modifier Modifier { get; set; }
        public INamespace Namespace { get; }
        public string Name { get; }
        public IBase BaseType { get; set; }
        public IList<IContract> Interfaces { get; }
        public IList<IField> Fields { get; }
        public IList<IMethod> Methods { get; }
        public IList<IProperty> Properties { get; }
        public IList<IConstructor> Constructors { get; }
        public IList<IOperator> Operators { get; }
        public IList<IEvent> Events { get; }
        public IList<IIndexer> Indexers { get; }

        public ClassImpl(INamespace nsp, string name)
        {
            Namespace = nsp;
            nsp?.Members.Add(this);
            Name = name;
            Interfaces = new List<IContract>();
            Fields = new List<IField>();
            Methods = new MethodList(this);
            Properties = new List<IProperty>();
            Constructors = new List<IConstructor>();
            Operators = new List<IOperator>();
            Events = new List<IEvent>();
            Indexers = new List<IIndexer>();
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var bse = (BaseType as IHasSyntaxNodes)?.GetNodes(gen).SingleOrDefault();
            var itt = gen.GetIntfNodes(this);
            var mmb = gen.GetFldNodes(this).Concat(gen.GetMethNodes(this))
                .Concat(gen.GetPropNodes(this)).Concat(gen.GetCstrNodes(this))
                .Concat(gen.GetOperNodes(this)).Concat(gen.GetEvtNodes(this))
                .Concat(gen.GetIndxNodes(this));
            var acc = Visibility.ToAccessibility();
            var mods = Modifier.ToDeclare();
            yield return gen.ClassDeclaration(Name, baseType: bse, interfaceTypes: itt,
                members: mmb, accessibility: acc, modifiers: mods);
        }
    }
}