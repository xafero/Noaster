using System;

namespace Noaster.Api.Model.Source
{
    public interface IAnnotationSource : IAnnotation, IInternal, IOrigin
    {
        IAnnotationSource AnnotationValue { get; }

        IAnnotationSource GetAnnotationValue(string str);

        IAnnotationSource[] AnnotationArrayValue { get; }

        IAnnotationSource[] GetAnnotationArrayValue(string str);

        IAnnotationSource RemoveValue(string str);

        IAnnotationSource RemoveAllValues();

        IAnnotationSource SetName(string str);

        IAnnotationSource setEnumValue(string str, Enum e);

        IAnnotationSource setEnumValue(params Enum[] earr);

        IAnnotationSource setEnumArrayValue(string str, params Enum[] earr);

        IAnnotationSource setEnumArrayValue(params Enum[] earr);

        IAnnotationSource setLiteralValue(string str);

        IAnnotationSource setLiteralValue(string str1, string str2);

        IAnnotationSource setStringValue(string str);

        IAnnotationSource setStringValue(string str1, string str2);

        IAnnotationSource setAnnotationValue();

        IAnnotationSource setAnnotationValue(string str);

        IAnnotationSource addAnnotationValue();

        IAnnotationSource addAnnotationValue(string str);

        IAnnotationSource addAnnotationValue(IType c);

        IAnnotationSource addAnnotationValue(string str, IType c);

        IAnnotationSource removeAnnotationValue(IAnnotation a);

        IAnnotationSource removeAnnotationValue(string str, IAnnotation a);

        IAnnotationSource setClassValue(string str, IType c);

        IAnnotationSource setClassValue(IType c);

        IAnnotationSource setClassArrayValue(string str, params IType[] carr);

        IAnnotationSource setClassArrayValue(params IType[] carr);

        IAnnotationSource setStringArrayValue(string str, string[] strarr);

        IAnnotationSource setStringArrayValue(string[] strarr);
    }
}