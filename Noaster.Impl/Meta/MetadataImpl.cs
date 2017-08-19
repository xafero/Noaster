using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Editing;
using Noaster.Api;
using Noaster.Impl.Api;
using Noaster.Impl.Base;
using Noaster.Impl.Parts;
using Noaster.Impl.Utils;

namespace Noaster.Impl.Meta
{
    public class MetadataImpl : IMetadata, IHasSyntaxNodes
    {
        public string Name => Title;

        public string Title { get; set; }
        public string Product { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
        public Version Version { get; set; }
        public bool? ClsCompliant { get; set; }
        public string Company { get; set; }
        public string Configuration { get; set; }
        public string Copyright { get; set; }
        public string InternalVersion { get; set; }
        public string NeutralLocale { get; set; }
        public bool? ComVisible { get; set; }
        public string Trademark { get; set; }
        public string Culture { get; set; }
        public Guid? Guid { get; set; }
        public IDictionary<string, object> Metadata { get; set; }
        public string TargetFramework { get; set; }

        public MetadataImpl(string name)
        {
            Title = name;
            Product = name;
            Alias = name;
            Version = new Version(1, 0, 0, 0);
            Metadata = new SortedDictionary<string, object>();
            Usings = new HashSet<IUsing>
            {
                new UsingImpl("System"),
                new UsingImpl("System.Diagnostics"),
                new UsingImpl("System.Reflection"),
                new UsingImpl("System.Runtime.CompilerServices")
            };
        }

        public ISet<IUsing> Usings { get; }

        public IList<IAttribute> Attributes => CreateAttributes().ToList();

        public override string ToString() => RoslynTool.ToString(this);

        public IEnumerable<SyntaxNode> GetNodes(SyntaxGenerator gen)
        {
            var contents = Usings.OfType<IHasSyntaxNodes>().Concat(
                    Attributes.OfType<IHasSyntaxNodes>()).Select(m => m.GetNodes(gen))
                .SelectMany(n => n).Select(n =>
                    (n as AttributeListSyntax)?.MakeAssemblyAttribute() ?? n);
            return contents;
        }

        private IEnumerable<IAttribute> CreateAttributes()
        {
            if (Version != null)
            {
                yield return new AttributeImpl("AssemblyVersion", Version.ToString());
                yield return new AttributeImpl("AssemblyFileVersion", Version.ToString());
            }
            if (Title != null) yield return new AttributeImpl("AssemblyTitle", Title);
            if (Product != null) yield return new AttributeImpl("AssemblyProduct", Product);
            if (Description != null) yield return new AttributeImpl("AssemblyDescription", Description);
            if (Alias != null) yield return new AttributeImpl("AssemblyDefaultAlias", Alias);
            if (TargetFramework != null) yield return NetFramework.GetTargetFramework(TargetFramework);
            if (Guid != null) yield return new AttributeImpl("Guid", Guid.ToString());
            if (ClsCompliant != null) yield return new AttributeImpl("CLSCompliant", ClsCompliant);
            if (Company != null) yield return new AttributeImpl("AssemblyCompany", Company);
            if (Configuration != null) yield return new AttributeImpl("AssemblyConfiguration", Configuration);
            if (Copyright != null) yield return new AttributeImpl("AssemblyCopyright", Copyright);
            if (InternalVersion != null) yield return new AttributeImpl("AssemblyInformationalVersion", InternalVersion);
            if (NeutralLocale != null) yield return new AttributeImpl("NeutralResourcesLanguage", NeutralLocale);
            if (ComVisible != null) yield return new AttributeImpl("ComVisible", ComVisible);
            if (Trademark != null) yield return new AttributeImpl("AssemblyTrademark", Trademark);
            if (Culture != null) yield return new AttributeImpl("AssemblyCulture", Culture);
            foreach (var meta in Metadata)
                yield return new AttributeImpl("AssemblyMetadata", meta.Key, meta.Value);
        }
    }
}