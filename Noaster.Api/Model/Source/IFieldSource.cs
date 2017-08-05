using System;

namespace Noaster.Api.Model.Source
{
	public interface IFieldSource : IField, IMember, IVisibilityScoped, IAnnotationTarget, IInternal,
		IOrigin, INamed, IFinalCapable, IStaticCapable, IMemberSource, IAnnotationTargetSource, 
		IVisibilityScopedSource, INamedSource, IXmlDocCapableSource, IXmlDocCapable, 
		IFinalCapableSource, IStaticCapableSource, ILocationCapable
	{
		new Type Type { set; }

		new string LiteralInitializer { set; }

		IFieldSource setType(ICSharpType jt);

		IFieldSource setLiteralInitializer(string str);

		IFieldSource setType(IType c);

		IFieldSource setType(string str);

		IFieldSource setStringInitializer(string str);

		IFieldSource setTransient(bool b);

		IFieldSource setVolatile(bool b);
	}
}