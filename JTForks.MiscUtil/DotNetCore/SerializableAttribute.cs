#if !NET461
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiscUtil
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    internal sealed class SerializableAttribute : Attribute
    {
        
    }
}

#endif