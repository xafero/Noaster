using System;
using System.Collections;
using Noaster.Api.Model;
using Noaster.Api.Model.Source;

namespace Noaster.Model.Impl
{
    public class FieldImpl : IFieldSource
    {
        readonly ICSharpSource parent;
        readonly AnnotationAccessor annotations;

        public FieldImpl(ICSharpSource parent)
        {
            this.parent = parent;
            annotations = new AnnotationAccessor();
        }

        public object Origin => parent.Origin;

        public bool Final
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

        public string LiteralInitializer
        {
            set
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

        public bool Static
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public string StringInitializer
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Transient
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Type Type
        {
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Volatile
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

        bool IFinalCapable.Final
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        string IField.LiteralInitializer
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

        bool IStaticCapable.Static
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        Type IField.Type
        {
            get
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

        public int getColumnNumber()
        {
            throw new NotImplementedException();
        }

        public int getEndPosition()
        {
            throw new NotImplementedException();
        }

        public int getLineNumber()
        {
            throw new NotImplementedException();
        }

        public int getStartPosition()
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

        public void RemoveXmlDoc()
        {
            throw new NotImplementedException();
        }

        public IFieldSource setLiteralInitializer(string str)
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

        public IFieldSource setStringInitializer(string str)
        {
            throw new NotImplementedException();
        }

        public IFieldSource setTransient(bool b)
        {
            throw new NotImplementedException();
        }

        public IFieldSource setType(string str)
        {
            throw new NotImplementedException();
        }

        public IFieldSource setType(IType c)
        {
            throw new NotImplementedException();
        }

        public IFieldSource setType(ICSharpType jt)
        {
            throw new NotImplementedException();
        }

        public object setVisibility(Visibility v)
        {
            throw new NotImplementedException();
        }

        public IFieldSource setVolatile(bool b)
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
    }
}