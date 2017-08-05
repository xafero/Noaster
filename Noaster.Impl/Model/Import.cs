using Noaster.Api.Model.Source;
using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Editing;

namespace Noaster.Impl.Model
{
    class Import : IImport, IHasSyntaxNodes
    {
        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator generator)
        {
            yield return generator.NamespaceImportDeclaration(QualifiedName);
        }

        public object Internal { get; set; }

        public bool Static { get; set; }


        public string getNamespace()
        {
            throw new NotImplementedException();
        }

        public string QualifiedName { get; set; }

        public string getSimpleName()
        {
            throw new NotImplementedException();
        }

        public bool isWildcard()
        {
            throw new NotImplementedException();
        }

        public IImport setName(string str)
        {
            throw new NotImplementedException();
        }
    }
}