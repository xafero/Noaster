namespace Noaster.Api.Model
{
    public interface IXmlDocCapable
    {
        IXmlDoc XmlDoc { get; }

        bool HasXmlDoc { get; }
    }
}