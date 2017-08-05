using System;

namespace Noaster.Api.Model.Source
{
    public interface IDefaultValue : IReadDefaultValue
    {
        IAnnotationSource Annotation { get; set; }

        IDefaultValue SetLiteral(string str);

        IDefaultValue SetString(string str);

        IDefaultValue SetEnum(Enum e);

        IDefaultValue SetEnumArray(params Enum[] earr);

        IDefaultValue SetSingleClass(IType c);

        IDefaultValue SetClassArray(params IType[] carr);
    }
}