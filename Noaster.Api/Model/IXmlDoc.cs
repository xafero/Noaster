using System.Collections;
using System.Collections.Generic;

namespace Noaster.Api.Model
{
    public interface IXmlDoc : IInternal, IOrigin
    {
        string Text { get; }

        string FullText { get; }

        ISet<string> TagNames { get; }

        IList getTags(string str);

        IList Tags { get; }
    }
}