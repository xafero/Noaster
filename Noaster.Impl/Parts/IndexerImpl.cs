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
        public string Type { get; }
        public string Name { get; }

        public IndexerImpl(string name, string type = null)
        {
            Name = name;
            Type = type ?? typeof(object).FullName;
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var type = SyntaxFactory.ParseTypeName(Type);
            var key = SyntaxFactory.ParseTypeName(typeof(int).FullName);
            var parm = SyntaxFactory.Parameter(SyntaxFactory.Identifier(nameof(key))).WithType(key);
            var parms = new SyntaxNode[] { parm };
            yield return gen.IndexerDeclaration(parms, type);
        }
    }
}