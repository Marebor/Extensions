using System;
using System.Collections.Generic;
using System.Text;

namespace Marebor.Extensions.FunctionalProgramming
{
    public static class RunMethod
    {
        public static void Run(this Action action)
            => action();
        public static T Run<T>(this Func<T> func)
            => func();
    }
}
