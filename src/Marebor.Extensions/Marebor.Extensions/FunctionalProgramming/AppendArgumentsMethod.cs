using System;

namespace Marebor.Extensions.FunctionalProgramming
{
    public static class AppendArgumentsMethod
    {
        public static Action AppendArguments<T1, T2>(this Action<T1> action, T1 arg1)
            => () => action(arg1);
        public static Action AppendArguments<T1, T2>(this Action<T1, T2> action, T1 arg1, T2 arg2)
            => () => action(arg1, arg2);
        public static Action AppendArguments<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
            => () => action(arg1, arg2, arg3);
        public static Action AppendArguments<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
            => () => action(arg1, arg2, arg3, arg4);

        public static Func<T1, T2> AppendArguments<T1, T2>(this Func<T1, T2> f1, T1 arg)
            => t1 => f1(arg);
        public static Func<T1, T3> AppendArguments<T1, T2, T3>(this Func<T1, T2, T3> f1, T2 arg)
            => t1 => f1(t1, arg);
        public static Func<T1, T4> AppendArguments<T1, T2, T3, T4>(this Func<T1, T2, T3, T4> f1, T2 arg1, T3 arg2)
            => t1 => f1(t1, arg1, arg2);
        public static Func<T1, T5> AppendArguments<T1, T2, T3, T4, T5>(this Func<T1, T2, T3, T4, T5> f1, T2 arg1, T3 arg2, T4 arg3)
            => t1 => f1(t1, arg1, arg2, arg3);
    }
}
