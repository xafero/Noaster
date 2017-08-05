﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Formatting;
using Microsoft.CodeAnalysis.Editing;
using Microsoft.CodeAnalysis.Formatting;
using Noaster.Impl.Api;
using System.IO;

namespace Noaster.Impl.Utils
{
    static class RoslynTool
    {
        internal static string ToString(IHasSyntaxNodes syntax)
        {
            using (var workspace = new AdhocWorkspace())
            {
                var options = workspace.Options;
                options = options.WithChangedOption(CSharpFormattingOptions.IndentBraces, false);
                var generator = SyntaxGenerator.GetGenerator(workspace, LanguageNames.CSharp);
                var syntaxNodes = syntax.GetNodes(generator);
                var unit = generator.CompilationUnit(syntaxNodes).NormalizeWhitespace();
                var node = Formatter.Format(unit, workspace, options);
                using (var writer = new StringWriter())
                {
                    node.WriteTo(writer);
                    return writer.ToString();
                }
            }
        }
    }
}