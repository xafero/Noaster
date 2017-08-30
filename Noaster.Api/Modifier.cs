using System;

namespace Noaster.Api
{
    [Flags]
    public enum Modifier
    {
        None = 0,

        Static = 1,

        Abstract = 2,

        Virtual = 4,

        Override = 8,
        
        Sealed = 16,
        
        Partial = 32
    }
}