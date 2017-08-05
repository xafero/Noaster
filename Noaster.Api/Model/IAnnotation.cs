using System;
using System.Collections;

namespace Noaster.Api.Model
{
    public interface IAnnotation : IInternal, IOrigin
    {
        bool isSingleValue();

        bool isMarker();

        bool isNormal();

        string getName();

        string getQualifiedName();

        Enum getEnumValue(IType c);

        Enum getEnumValue(IType c, string str);

        Enum[] getEnumArrayValue(IType c);

        Enum[] getEnumArrayValue(IType c, string str);

        string getLiteralValue();

        string getLiteralValue(string str);

        IList getValues();

        string getStringValue();

        string getStringValue(string str);

        string[] getStringArrayValue();

        string[] getStringArrayValue(string str);

        IAnnotation getAnnotationValue();

        IAnnotation getAnnotationValue(string str);

        IAnnotation[] getAnnotationArrayValue();

        IAnnotation[] getAnnotationArrayValue(string str);

        IType getClassValue();

        IType getClassValue(string str);

        IType[] getClassArrayValue();

        IType[] getClassArrayValue(string str);

        bool isTypeElementDefined(string str);
    }
}