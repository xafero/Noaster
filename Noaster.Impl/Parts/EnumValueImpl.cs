using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;

namespace Noaster.Impl.Parts
{
    public class EnumValueImpl : IEnumVal, IHasSyntaxNodes
    {
        public string Name { get; }

        public EnumValueImpl(string name)
        {
            Name = name;
        }

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            yield return gen.EnumMember(Name);
        }
    }
}