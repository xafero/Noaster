using System;
using System.Collections;
using Noaster.Api.Model;
using Noaster.Api.Model.Source;

namespace Noaster.Model.Impl
{
    public abstract class AbstractCSharpSourceMemberHolder : AbstractCSharpSource, IInterfaceCapableSource, IPropertyHolderSource
    {
        public IFieldSource addField()
        {
            throw new NotImplementedException();
        }

        public IFieldSource addField(string str)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource addInterface(IType c)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource addInterface(ICSharpInterface ji)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource addInterface(string str)
        {
            throw new NotImplementedException();
        }

        public IMethodSource addMethod()
        {
            throw new NotImplementedException();
        }

        public IMethodSource addMethod(string str)
        {
            throw new NotImplementedException();
        }

        public IMethodSource addMethod(IMethod m)
        {
            throw new NotImplementedException();
        }

        public IPropertySource addProperty(Type c, string str)
        {
            throw new NotImplementedException();
        }

        public IPropertySource addProperty(ICSharpType jt, string str)
        {
            throw new NotImplementedException();
        }

        public IPropertySource addProperty(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public IFieldSource getField(string str)
        {
            throw new NotImplementedException();
        }

        public IList getFields()
        {
            throw new NotImplementedException();
        }

        public IList getInterfaces()
        {
            throw new NotImplementedException();
        }

        public IList getMembers()
        {
            throw new NotImplementedException();
        }

        public IMethodSource getMethod(string str)
        {
            throw new NotImplementedException();
        }

        public IMethodSource getMethod(string str, params string[] strarr)
        {
            throw new NotImplementedException();
        }

        public IMethodSource getMethod(string str, params IType[] carr)
        {
            throw new NotImplementedException();
        }

        public IList getMethods()
        {
            throw new NotImplementedException();
        }

        public IList getProperties()
        {
            throw new NotImplementedException();
        }

        public IList getProperties(IType c)
        {
            throw new NotImplementedException();
        }

        public IPropertySource getProperty(string str)
        {
            throw new NotImplementedException();
        }

        public bool hasField(string str)
        {
            throw new NotImplementedException();
        }

        public bool hasField(IField f)
        {
            throw new NotImplementedException();
        }

        public bool hasInterface(IType c)
        {
            throw new NotImplementedException();
        }

        public bool hasInterface(ICSharpInterface ji)
        {
            throw new NotImplementedException();
        }

        public bool hasInterface(string str)
        {
            throw new NotImplementedException();
        }

        public bool hasMethod(IMethod m)
        {
            throw new NotImplementedException();
        }

        public bool hasMethodSignature(string str)
        {
            throw new NotImplementedException();
        }

        public bool hasMethodSignature(IMethod m)
        {
            throw new NotImplementedException();
        }

        public bool hasMethodSignature(string str, params IType[] carr)
        {
            throw new NotImplementedException();
        }

        public bool hasMethodSignature(string str, params string[] strarr)
        {
            throw new NotImplementedException();
        }

        public bool hasProperty(IProperty p)
        {
            throw new NotImplementedException();
        }

        public bool hasProperty(string str)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource implementInterface(ICSharpInterface ji)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource implementInterface(IType c)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource removeField(IField f)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource removeInterface(ICSharpInterface ji)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource removeInterface(IType c)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource removeInterface(string str)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource removeMethod(IMethod m)
        {
            throw new NotImplementedException();
        }

        public IPropertyHolderSource removeProperty(IProperty p)
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

        IProperty IPropertyHolder.getProperty(string str)
        {
            throw new NotImplementedException();
        }
    }
}