using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;

namespace Noaster.Impl.Parts
{
    public class AttributeImpl : IAttribute, IHasSyntaxNodes
    {
        public string Name { get; }
        public IList<object> Values { get; }
        public IDictionary<string, object> Properties { get; }

        public AttributeImpl(string name)
        {
            Name = name;
            Values = new List<object>();
            Properties = new Dictionary<string, object>();
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var required = Values.Select(SyntaxExts.ToLiteral);
            var optional = Properties.ToDictionary(k => k.Key, v => SyntaxExts.ToLiteral(v.Value));
            var assigns = SyntaxExts.ToSyntaxNodes(optional);
            var args = required.Concat(assigns);
            yield return gen.Attribute(Name, attributeArguments: args);
        }
    }
}