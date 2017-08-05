namespace Noaster.Api.Model.Source
{
    public interface IXmlDocSource : IXmlDoc, IInternal, IOrigin
    {
        new string FullText { set; }

        new string Text { set; }

        IXmlDocSource addTagValue(string str1, string str2);

        IXmlDocSource addTagValue(IXmlDocTag jdt);

        IXmlDocSource removeTags(string str);

        IXmlDocSource removeTag(IXmlDocTag jdt);

        IXmlDocSource removeAllTags();
    }
}