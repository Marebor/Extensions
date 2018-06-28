using System;

namespace Marebor.Extensions.FunctionalProgramming
{
    public static class InterceptAfterExecutionMethod
    {
        public static Func<T> InterceptAfterExecution<T>(this Func<T> func, Action<T> interception)
            => new Func<T>(() => { var result = func(); interception(result); return result; });
    }
}
