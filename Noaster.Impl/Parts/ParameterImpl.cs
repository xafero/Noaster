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
        public ParamModifier Modifier { get; set; }
        public string Type { get; set; }
        public string Name { get; private set; }

        public ParameterImpl(string name, string type = null)
        {
            Name = name;
            Type = type ?? typeof(object).FullName;
        }
        
        public void Rename(string name)
        {
            Name = name;
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var type = SyntaxFactory.ParseTypeName(Type);
            var parm = (ParameterSyntax)gen.ParameterDeclaration(Name);
            var tokens = Modifier.ToKeyword().ToList();
            yield return parm.WithType(type).WithModifiers(tokens);
        }
    }
}