namespace Noaster.Api.Model.Source
{
    public interface IXmlDocCapableSource : IXmlDocCapable
    {
        new IXmlDocSource XmlDoc { get; }

        void RemoveXmlDoc();
    }
}