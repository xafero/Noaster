using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using System.Collections.Generic;

namespace Noaster.Impl.Api
{
    interface IHasSyntaxNodes
    {
        IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen);
    }
}