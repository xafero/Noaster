using System;
using System.Collections;
using Noaster.Api.Model;
using Noaster.Api.Model.Source;

namespace Noaster.Model.Impl
{

    public abstract class AbstractGenericCapableJavaSource : AbstractJavaSourceMemberHolder, IGenericCapableSource
    {
        public ITypeVariableSource addTypeVariable()
        {
            throw new NotImplementedException();
        }

        public ITypeVariableSource addTypeVariable(string str)
        {
            throw new NotImplementedException();
        }

        public ITypeVariableSource getTypeVariable(string str)
        {
            throw new NotImplementedException();
        }

        public IList getTypeVariables()
        {
            throw new NotImplementedException();
        }

        public bool hasTypeVariable(string str)
        {
            throw new NotImplementedException();
        }

        public object removeTypeVariable(ITypeVariable tv)
        {
            throw new NotImplementedException();
        }

        public object removeTypeVariable(string str)
        {
            throw new NotImplementedException();
        }

        ITypeVariable IGenericCapable.getTypeVariable(string str)
        {
            throw new NotImplementedException();
        }
    }
}