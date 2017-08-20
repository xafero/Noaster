using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;
using Microsoft.CodeAnalysis.CSharp;

namespace Noaster.Impl.Parts
{
    public class IndexerImpl : IIndexer, INamed, IHasSyntaxNodes
    {
        public Visibility Visibility { get; set; }
        public string Type { get; set; }
        public string Name { get; }
        public IList<IParameter> Parameters { get; }

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
            var acc = Visibility.ToAccessibility();
            yield return gen.IndexerDeclaration(gen.GetParamNodes(this), type, accessibility: acc);
        }
    }
}