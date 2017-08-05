using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;

namespace Noaster.Impl.Parts
{
    public class ParameterImpl : IParameter, INamed, IHasSyntaxNodes
    {
        public string Type { get; }
        public string Name { get; }

        public ParameterImpl(string name, string type = null)
        {
            Name = name;
            Type = type ?? typeof(object).FullName;
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var type = SyntaxFactory.ParseTypeName(Type);
            var parm = (ParameterSyntax)gen.ParameterDeclaration(Name);
            yield return parm.WithType(type);
        }
    }
}