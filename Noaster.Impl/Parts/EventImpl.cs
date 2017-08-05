using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;
using System.Collections.Generic;

namespace Noaster.Impl.Parts
{
    public class EventImpl : IEvent, INamed, IHasSyntaxNodes
    {
        public Visibility Visibility { get; set; }
        public string Type { get; }
        public string Name { get; }

        public EventImpl(string name, string type = null)
        {
            Name = name;
            Type = type ?? typeof(object).FullName;
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var type = SyntaxFactory.ParseTypeName(Type);
            var acc = Visibility.ToAccessibility();
            // gen.CustomEventDeclaration
            yield return gen.EventDeclaration(Name, type, accessibility: acc);
        }
    }
}