using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Noaster.Impl.Types
{
    public class StructImpl : INamespaced, INamed, IHasSyntaxNodes, INamespaceMember, IStruct
    {
        public Visibility Visibility { get; set; }
        public INamespace Namespace { get; }
        public string Name { get; }
        public IList<IContract> Interfaces { get; }
        public IList<IField> Fields { get; }
        public IList<IMethod> Methods { get; }
        public IList<IProperty> Properties { get; }
        public IList<IConstructor> Constructors { get; }
        public IList<IOperator> Operators { get; }
        public IList<IAttribute> Attributes { get; }

        public StructImpl(INamespace nsp, string name)
        {
            Namespace = nsp;
            nsp?.Members.Add(this);
            Name = name;
            Interfaces = new List<IContract>();
            Fields = new List<IField>();
            Methods = new List<IMethod>();
            Properties = new List<IProperty>();
            Constructors = new List<IConstructor>();
            Operators = new List<IOperator>();
            Attributes = new List<IAttribute>();
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var itt = gen.GetIntfNodes(this);
            var mmb = gen.GetFldNodes(this).Concat(gen.GetMethNodes(this))
                         .Concat(gen.GetPropNodes(this)).Concat(gen.GetCstrNodes(this))
                         .Concat(gen.GetOperNodes(this));
            var stru = (StructDeclarationSyntax) gen.StructDeclaration(Name, interfaceTypes: itt,
                members: mmb, accessibility: Visibility.ToAccessibility());
            yield return stru.WithAttributeLists(gen.GetAttrsNodes(this).ToList());
        }
    }
}