using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;

namespace Noaster.Impl.Utils
{
    public static class SyntaxExts
    {
        public static IEnumerable<SyntaxNode> GetParamNodes(this SyntaxGenerator gen, IHasParameters holder)
            => holder.Parameters.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));

        public static IEnumerable<SyntaxNode> GetMethNodes(this SyntaxGenerator gen, IHasMethods holder)
            => holder.Methods.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));

        public static IEnumerable<SyntaxNode> GetIntfNodes(this SyntaxGenerator gen, IHasInterfaces holder)
            => holder.Interfaces.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));

        public static IEnumerable<SyntaxNode> GetEvtNodes(this SyntaxGenerator gen, IHasEvents holder)
			=> holder.Events.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));

        public static IEnumerable<SyntaxNode> GetPropNodes(this SyntaxGenerator gen, IHasProperties holder)
			=> holder.Properties.OfType<IHasSyntaxNodes>().SelectMany(n => n.GetNodes(gen));
    }
}