using System;
using System.Collections.Generic;
using System.Text;

namespace Marebor.Extensions.Type
{
    public static class TypeExtensions
    {
        public static bool IsImplementationOf(this System.Type tested, System.Type type)
            => type.IsAssignableFrom(tested);
        public static bool IsImplementationOf<T>(this System.Type tested)
            => tested.IsImplementationOf(typeof(T));
    }
}
