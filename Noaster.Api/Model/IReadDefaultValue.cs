using System;

namespace Noaster.Api.Model
{
    public interface IReadDefaultValue
    {
        string getString();

        string getLiteral();

        Enum getEnum(IType c);

        Enum[] getEnumArray(IType c);

        IAnnotation getAnnotation();

        IType getSingleClass();

        IType[] getClassArray();
    }
}