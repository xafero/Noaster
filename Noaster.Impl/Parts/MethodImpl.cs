﻿using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Utils;

namespace Noaster.Impl.Parts
{
    public class MethodImpl : IMethod, INamed, IHasSyntaxNodes, IVisible
    {
        public Visibility Visibility { get; set; }
        public Modifier Modifier { get; set; }
        public string Name { get; }
        public IList<IParameter> Parameters { get; }

        public MethodImpl(string name)
        {
            Name = name;
            Parameters = new List<IParameter>();
        }

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var acc = Visibility.ToAccessibility();
            var mod = Modifier.ToDeclare();
            yield return gen.MethodDeclaration(Name, gen.GetParamNodes(this),
                accessibility: acc, modifiers: mod);
        }
    }
}