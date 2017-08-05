using System;
using System.Collections;

namespace Noaster.Api.Model.Source
{
    public interface IPropertyHolderSource : IPropertyHolder, IMethodHolder, IMemberHolder, IFieldHolder,
        IInterfaceCapable, IMethodHolderSource, IMemberHolderSource, IFieldHolderSource
    {
        IPropertySource addProperty(string str1, string str2);

        IPropertySource addProperty(Type c, string str);

        IPropertySource addProperty(ICSharpType jt, string str);

        IPropertyHolderSource removeProperty(IProperty p);
        new IList getProperties();
        new IList getProperties(IType c);
        new IPropertySource getProperty(string str);
    }
}