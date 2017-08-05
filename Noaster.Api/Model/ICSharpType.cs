using System.Collections;

namespace Noaster.Api.Model
{
    public interface ICSharpType : INamespaced, INamed, IVisibilityScoped, IAnnotationTarget, IInternal, IOrigin, IXmlDocCapable
    {
        bool isInterface();

        string getQualifiedName();

        string getCanonicalName();

        IList getSyntaxErrors();

        bool hasSyntaxErrors();

        bool isClass();

        bool isEnum();

        bool isAnnotation();

        ICSharpType getEnclosingType();

        string toUnformattedString();
    }
}