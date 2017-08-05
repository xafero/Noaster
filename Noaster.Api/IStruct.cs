﻿using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IStruct : IType, IHasFields, IHasMethods, IHasProperties,
        IHasConstructors, IHasOperators, IHasInterfaces
    {
    }
}