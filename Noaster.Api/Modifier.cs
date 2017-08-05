using System;

namespace Noaster.Api
{
    [Flags]
    public enum Modifier
    {
        None = 0,

        Static = 2 ^ 0
    }
}