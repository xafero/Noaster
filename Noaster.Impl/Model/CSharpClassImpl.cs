using System;
using System.Collections;
using Noaster.Api.Model;
using Noaster.Api.Model.Source;

namespace Noaster.Model.Impl
{
    public class CSharpClassImpl : AbstractGenericCapableCSharpSource, ICSharpClassSource
    {
        public bool Abstract { get; set; }

        public new bool DefaultNamespace { get; set; }

        public bool Final { get; set; }

        public new bool HasXmlDoc { get; set; }

        public new object Internal { get; set; }

        public new string Name { get; set; }

        public new string Namespace { get; set; }

        public new object Origin { get; set; }

        public new bool Static { get; set; }

        public new IXmlDocSource XmlDoc { get; set; }

        public new IAnnotationSource addAnnotation()
        {
            throw new NotImplementedException();
        }

        public new IAnnotationSource addAnnotation(string str)
        {
            throw new NotImplementedException();
        }

        public new IAnnotationSource addAnnotation(IType c)
        {
            throw new NotImplementedException();
        }

        public new IFieldSource addField()
        {
            throw new NotImplementedException();
        }

        public new IFieldSource addField(string str)
        {
            throw new NotImplementedException();
        }

        public new IImport addImport(IType c)
        {
            throw new NotImplementedException();
        }

        public new IImport addImport(ICSharpType jt)
        {
            throw new NotImplementedException();
        }

        public new IImport addImport(string str)
        {
            throw new NotImplementedException();
        }

        public new IImport addImport(IImport i)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource addInterface(ICSharpInterface ji)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource addInterface(IType c)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource addInterface(string str)
        {
            throw new NotImplementedException();
        }

        public new IMethodSource addMethod()
        {
            throw new NotImplementedException();
        }

        public new IMethodSource addMethod(string str)
        {
            throw new NotImplementedException();
        }

        public new IMethodSource addMethod(IMethod m)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource addNestedType(string str)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource addNestedType(ICSharpSource js)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource addNestedType(IType c)
        {
            throw new NotImplementedException();
        }

        public new IPropertySource addProperty(Type c, string str)
        {
            throw new NotImplementedException();
        }

        public new IPropertySource addProperty(ICSharpType jt, string str)
        {
            throw new NotImplementedException();
        }

        public new IPropertySource addProperty(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public new ITypeVariableSource addTypeVariable()
        {
            throw new NotImplementedException();
        }

        public new ITypeVariableSource addTypeVariable(string str)
        {
            throw new NotImplementedException();
        }

        public ICSharpType extendSuperType(ICSharpClass jc)
        {
            throw new NotImplementedException();
        }

        public ICSharpType extendSuperType(IType c)
        {
            throw new NotImplementedException();
        }

        public new IAnnotationSource getAnnotation(string str)
        {
            throw new NotImplementedException();
        }

        public new IAnnotationSource getAnnotation(IType c)
        {
            throw new NotImplementedException();
        }

        public new IList getAnnotations()
        {
            throw new NotImplementedException();
        }

        public new string getCanonicalName()
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource getEnclosingType()
        {
            throw new NotImplementedException();
        }

        public new IFieldSource getField(string str)
        {
            throw new NotImplementedException();
        }

        public new IList getFields()
        {
            throw new NotImplementedException();
        }

        public new IImport getImport(IType c)
        {
            throw new NotImplementedException();
        }

        public new IImport getImport(ICSharpType jt)
        {
            throw new NotImplementedException();
        }

        public new IImport getImport(IImport i)
        {
            throw new NotImplementedException();
        }

        public new IImport getImport(string str)
        {
            throw new NotImplementedException();
        }

        public new IList getImports()
        {
            throw new NotImplementedException();
        }

        public new IList getInterfaces()
        {
            throw new NotImplementedException();
        }

        public new IList getMembers()
        {
            throw new NotImplementedException();
        }

        public new IMethodSource getMethod(string str)
        {
            throw new NotImplementedException();
        }

        public new IMethodSource getMethod(string str, params string[] strarr)
        {
            throw new NotImplementedException();
        }

        public new IMethodSource getMethod(string str, params IType[] carr)
        {
            throw new NotImplementedException();
        }

        public new IList getMethods()
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource getNestedType(string str)
        {
            throw new NotImplementedException();
        }

        public new IList getNestedTypes()
        {
            throw new NotImplementedException();
        }

        public new IList getProperties()
        {
            throw new NotImplementedException();
        }

        public new IList getProperties(IType c)
        {
            throw new NotImplementedException();
        }

        public new IPropertySource getProperty(string str)
        {
            throw new NotImplementedException();
        }

        public new string getQualifiedName()
        {
            throw new NotImplementedException();
        }

        public string getSuperType()
        {
            throw new NotImplementedException();
        }

        public new IList getSyntaxErrors()
        {
            throw new NotImplementedException();
        }

        public new ITypeVariableSource getTypeVariable(string str)
        {
            throw new NotImplementedException();
        }

        public new IList getTypeVariables()
        {
            throw new NotImplementedException();
        }

        public new Visibility getVisibility()
        {
            throw new NotImplementedException();
        }

        public new bool hasAnnotation(string str)
        {
            throw new NotImplementedException();
        }

        public new bool hasAnnotation(IType c)
        {
            throw new NotImplementedException();
        }

        public new bool hasField(string str)
        {
            throw new NotImplementedException();
        }

        public new bool hasField(IField f)
        {
            throw new NotImplementedException();
        }

        public new bool hasImport(ICSharpType jt)
        {
            throw new NotImplementedException();
        }

        public new bool hasImport(IImport i)
        {
            throw new NotImplementedException();
        }

        public new bool hasImport(string str)
        {
            throw new NotImplementedException();
        }

        public new bool hasImport(IType c)
        {
            throw new NotImplementedException();
        }

        public new bool hasInterface(IType c)
        {
            throw new NotImplementedException();
        }

        public new bool hasInterface(ICSharpInterface ji)
        {
            throw new NotImplementedException();
        }

        public new bool hasInterface(string str)
        {
            throw new NotImplementedException();
        }

        public new bool hasMethod(IMethod m)
        {
            throw new NotImplementedException();
        }

        public new bool hasMethodSignature(string str)
        {
            throw new NotImplementedException();
        }

        public new bool hasMethodSignature(IMethod m)
        {
            throw new NotImplementedException();
        }

        public new bool hasMethodSignature(string str, params IType[] carr)
        {
            throw new NotImplementedException();
        }

        public new bool hasMethodSignature(string str, params string[] strarr)
        {
            throw new NotImplementedException();
        }

        public new bool hasNestedType(IType c)
        {
            throw new NotImplementedException();
        }

        public new bool hasNestedType(ICSharpType jt)
        {
            throw new NotImplementedException();
        }

        public new bool hasNestedType(string str)
        {
            throw new NotImplementedException();
        }

        public new bool hasProperty(IProperty p)
        {
            throw new NotImplementedException();
        }

        public new bool hasProperty(string str)
        {
            throw new NotImplementedException();
        }

        public new bool hasSyntaxErrors()
        {
            throw new NotImplementedException();
        }

        public new bool hasTypeVariable(string str)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource implementInterface(ICSharpInterface ji)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource implementInterface(IType c)
        {
            throw new NotImplementedException();
        }

        public new bool isAnnotation()
        {
            throw new NotImplementedException();
        }

        public new bool isClass()
        {
            throw new NotImplementedException();
        }

        public new bool isEnum()
        {
            throw new NotImplementedException();
        }

        public new bool isInterface()
        {
            throw new NotImplementedException();
        }

        public bool isLocalClass()
        {
            throw new NotImplementedException();
        }

        public new bool isNamespacePrivate()
        {
            throw new NotImplementedException();
        }

        public new bool isPrivate()
        {
            throw new NotImplementedException();
        }

        public new bool isProtected()
        {
            throw new NotImplementedException();
        }

        public new bool isPublic()
        {
            throw new NotImplementedException();
        }

        public new void removeAllAnnotations()
        {
            throw new NotImplementedException();
        }

        public new object removeAnnotation(IAnnotation a)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource removeField(IField f)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource removeImport(ICSharpType jt)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource removeImport(IImport i)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource removeImport(IType c)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource removeImport(string str)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource removeInterface(ICSharpInterface ji)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource removeInterface(IType c)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource removeInterface(string str)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource removeMethod(IMethod m)
        {
            throw new NotImplementedException();
        }

        public new ICSharpSource removeNestedType(ICSharpSource js)
        {
            throw new NotImplementedException();
        }

        public new IPropertyHolderSource removeProperty(IProperty p)
        {
            throw new NotImplementedException();
        }

        public new object removeTypeVariable(ITypeVariable tv)
        {
            throw new NotImplementedException();
        }

        public new object removeTypeVariable(string str)
        {
            throw new NotImplementedException();
        }

        public new void RemoveXmlDoc()
        {
            throw new NotImplementedException();
        }

        public new bool requiresImport(string str)
        {
            throw new NotImplementedException();
        }

        public new bool requiresImport(IType c)
        {
            throw new NotImplementedException();
        }

        public new string resolveType(string str)
        {
            throw new NotImplementedException();
        }

        public object setFinal(bool b)
        {
            throw new NotImplementedException();
        }

        public new object setNamespacePrivate()
        {
            throw new NotImplementedException();
        }

        public new object setPrivate()
        {
            throw new NotImplementedException();
        }

        public new object setProtected()
        {
            throw new NotImplementedException();
        }

        public new object setPublic()
        {
            throw new NotImplementedException();
        }

        public new object setStatic(bool b)
        {
            throw new NotImplementedException();
        }

        public ICSharpType setSuperType(string str)
        {
            throw new NotImplementedException();
        }

        public ICSharpType setSuperType(IType c)
        {
            throw new NotImplementedException();
        }

        public ICSharpType setSuperType(ICSharpType jt)
        {
            throw new NotImplementedException();
        }

        public new object setVisibility(Visibility v)
        {
            throw new NotImplementedException();
        }

        public new string toUnformattedString()
        {
            throw new NotImplementedException();
        }

        IAnnotation IAnnotationTarget.getAnnotation(string str)
        {
            throw new NotImplementedException();
        }

        IAnnotation IAnnotationTarget.getAnnotation(IType c)
        {
            throw new NotImplementedException();
        }

        ICSharpType ICSharpType.getEnclosingType()
        {
            throw new NotImplementedException();
        }

        IField IFieldHolder.getField(string str)
        {
            throw new NotImplementedException();
        }

        IMethod IMethodHolder.getMethod(string str)
        {
            throw new NotImplementedException();
        }

        IMethod IMethodHolder.getMethod(string str, params IType[] carr)
        {
            throw new NotImplementedException();
        }

        IMethod IMethodHolder.getMethod(string str, params string[] strarr)
        {
            throw new NotImplementedException();
        }

        ICSharpType ITypeHolder.getNestedType(string str)
        {
            throw new NotImplementedException();
        }

        IProperty IPropertyHolder.getProperty(string str)
        {
            throw new NotImplementedException();
        }

        ITypeVariable IGenericCapable.getTypeVariable(string str)
        {
            throw new NotImplementedException();
        }
    }
}