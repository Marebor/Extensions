using System;
using System.Collections.Generic;
using System.Text;

namespace Marebor.Extensions.FunctionalProgramming
{
    public static class ExecuteMethod
    {
        public static T Execute<T>(this T arg, Action<T> action)
        {
            action(arg);
            return arg;
        }
    }
}
