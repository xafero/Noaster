using System;
using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IMetadata : INamed, IHasAttributes, IHasUsings
    {
        string Title { get; set; }

        string Product { get; set; }

        string Description { get; set; }

        string Alias { get; set; }

        Version Version { get; set; }

        bool? ClsCompliant { get; set; }

        string Company { get; set; }

        string Configuration { get; set; }

        string Copyright { get; set; }

        string InternalVersion { get; set; }

        string NeutralLocale { get; set; }

        bool? ComVisible { get; set; }

        string Trademark { get; set; }

        string Culture { get; set; }

        Guid? Guid { get; set; }

        IDictionary<string, object> Metadata { get; set; }

        string TargetFramework { get; set; }
    }
}