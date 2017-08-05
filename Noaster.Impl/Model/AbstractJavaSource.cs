using System;
using System.Collections;
using Noaster.Api.Model;
using Noaster.Api.Model.Source;

namespace Noaster.Model.Impl
{

    public abstract class AbstractCSharpSource : ICSharpSource, ITypeHolderSource, IStaticCapableSource
    {
        public bool DefaultNamespace
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool HasXmlDoc
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object Internal
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Namespace
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public object Origin
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Static
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IXmlDocSource XmlDoc
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool INamespaced.DefaultNamespace
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        string INamed.Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        string INamespaced.Namespace
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IStaticCapableSource.Static
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        IXmlDoc IXmlDocCapable.XmlDoc
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IAnnotationSource addAnnotation()
        {
            throw new NotImplementedException();
        }

        public IAnnotationSource addAnnotation(string str)
        {
            throw new NotImplementedException();
        }

        public IAnnotationSource addAnnotation(IType c)
        {
            throw new NotImplementedException();
        }

        public IImport addImport(IType c)
        {
            throw new NotImplementedException();
        }

        public IImport addImport(string str)
        {
            throw new NotImplementedException();
        }

        public IImport addImport(ICSharpType jt)
        {
            throw new NotImplementedException();
        }

        public IImport addImport(IImport i)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource addNestedType(ICSharpSource js)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource addNestedType(string str)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource addNestedType(IType c)
        {
            throw new NotImplementedException();
        }

        public IAnnotationSource getAnnotation(string str)
        {
            throw new NotImplementedException();
        }

        public IAnnotationSource getAnnotation(IType c)
        {
            throw new NotImplementedException();
        }

        public IList getAnnotations()
        {
            throw new NotImplementedException();
        }

        public string getCanonicalName()
        {
            throw new NotImplementedException();
        }

        public ICSharpSource getEnclosingType()
        {
            throw new NotImplementedException();
        }

        public IImport getImport(IType c)
        {
            throw new NotImplementedException();
        }

        public IImport getImport(IImport i)
        {
            throw new NotImplementedException();
        }

        public IImport getImport(ICSharpType jt)
        {
            throw new NotImplementedException();
        }

        public IImport getImport(string str)
        {
            throw new NotImplementedException();
        }

        public IList getImports()
        {
            throw new NotImplementedException();
        }

        public ICSharpSource getNestedType(string str)
        {
            throw new NotImplementedException();
        }

        public IList getNestedTypes()
        {
            throw new NotImplementedException();
        }

        public string getQualifiedName()
        {
            throw new NotImplementedException();
        }

        public IList getSyntaxErrors()
        {
            throw new NotImplementedException();
        }

        public Visibility getVisibility()
        {
            throw new NotImplementedException();
        }

        public bool hasAnnotation(string str)
        {
            throw new NotImplementedException();
        }

        public bool hasAnnotation(IType c)
        {
            throw new NotImplementedException();
        }

        public bool hasImport(IImport i)
        {
            throw new NotImplementedException();
        }

        public bool hasImport(ICSharpType jt)
        {
            throw new NotImplementedException();
        }

        public bool hasImport(string str)
        {
            throw new NotImplementedException();
        }

        public bool hasImport(IType c)
        {
            throw new NotImplementedException();
        }

        public bool hasNestedType(IType c)
        {
            throw new NotImplementedException();
        }

        public bool hasNestedType(ICSharpType jt)
        {
            throw new NotImplementedException();
        }

        public bool hasNestedType(string str)
        {
            throw new NotImplementedException();
        }

        public bool hasSyntaxErrors()
        {
            throw new NotImplementedException();
        }

        public bool isAnnotation()
        {
            throw new NotImplementedException();
        }

        public bool isClass()
        {
            throw new NotImplementedException();
        }

        public bool isEnum()
        {
            throw new NotImplementedException();
        }

        public bool isInterface()
        {
            throw new NotImplementedException();
        }

        public bool isNamespacePrivate()
        {
            throw new NotImplementedException();
        }

        public bool isPrivate()
        {
            throw new NotImplementedException();
        }

        public bool isProtected()
        {
            throw new NotImplementedException();
        }

        public bool isPublic()
        {
            throw new NotImplementedException();
        }

        public void removeAllAnnotations()
        {
            throw new NotImplementedException();
        }

        public object removeAnnotation(IAnnotation a)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource removeImport(ICSharpType jt)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource removeImport(IImport i)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource removeImport(IType c)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource removeImport(string str)
        {
            throw new NotImplementedException();
        }

        public ICSharpSource removeNestedType(ICSharpSource js)
        {
            throw new NotImplementedException();
        }

        public void RemoveXmlDoc()
        {
            throw new NotImplementedException();
        }

        public bool requiresImport(string str)
        {
            throw new NotImplementedException();
        }

        public bool requiresImport(IType c)
        {
            throw new NotImplementedException();
        }

        public string resolveType(string str)
        {
            throw new NotImplementedException();
        }

        public object setNamespacePrivate()
        {
            throw new NotImplementedException();
        }

        public object setPrivate()
        {
            throw new NotImplementedException();
        }

        public object setProtected()
        {
            throw new NotImplementedException();
        }

        public object setPublic()
        {
            throw new NotImplementedException();
        }

        public object setStatic(bool b)
        {
            throw new NotImplementedException();
        }

        public object setVisibility(Visibility v)
        {
            throw new NotImplementedException();
        }

        public string toUnformattedString()
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

        ICSharpType ITypeHolder.getNestedType(string str)
        {
            throw new NotImplementedException();
        }
    }
}