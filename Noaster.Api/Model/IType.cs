using System.Collections;

namespace Noaster.Api.Model
{
    public interface IType : IOrigin
    {
        string getName();

        string getQualifiedName();

        bool isArray();

        bool isPrimitive();

        bool isType(string str);

        bool isType(IType c);

        IList getTypeArguments();

        string getSimpleName();

        string getQualifiedNameWithGenerics();

        IType getParentType();

        int getArrayDimensions();

        bool isParameterized();

        bool isQualified();

        bool isWildcard();
    }
}