using System.Linq;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api.Model.Source;
using Noaster.Impl;

namespace Noaster.Model.Impl
{
    internal class Imports : List<IImport>, IHasSyntaxNodes
    {
        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator generator)
            => this.SelectMany(i => ((IHasSyntaxNodes)i).GetNodes(generator));
    }
}