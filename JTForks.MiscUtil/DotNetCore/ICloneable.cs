#if !NET461
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiscUtil
{
    public interface ICloneable
    {
        object Clone();
    }
}

#endif