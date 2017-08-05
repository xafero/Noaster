﻿using System.Collections.Generic;

namespace Noaster.Api
{
    public interface IInterface : IType, IContract, IHasMethods,
        IHasProperties, IHasEvents, IHasInterfaces
    {
    }
}