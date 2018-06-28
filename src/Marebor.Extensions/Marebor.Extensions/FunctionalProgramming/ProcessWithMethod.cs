using System;
using System.Collections.Generic;
using System.Text;

namespace Marebor.Extensions.FunctionalProgramming
{
    public static class ProcessWithMethod
    {
        public static Action ProcessWith<T>(this T arg, Action<T> action)
            => () => action(arg);
        public static Action<T1> ProcessWith<T, T1>(this T arg, Action<T, T1> action)
            => t1 => action(arg, t1);
        public static Action<T1, T2> ProcessWith<T, T1, T2>(this T arg, Action<T, T1, T2> action)
            => (t1, t2) => action(arg, t1, t2);
        public static Action<T1, T2, T3> ProcessWith<T, T1, T2, T3>(this T arg, Action<T, T1, T2, T3> action)
            => (t1, t2, t3) => action(arg, t1, t2, t3);
        public static Action<T1, T2, T3, T4> ProcessWith<T, T1, T2, T3, T4>(this T arg, Action<T, T1, T2, T3, T4> action)
            => (t1, t2, t3, t4) => action(arg, t1, t2, t3, t4);

        public static Func<T1> ProcessWith<T, T1>(this T arg, Func<T, T1> func)
            => () => func(arg);
        public static Func<T1, T2> ProcessWith<T, T1, T2>(this T arg, Func<T, T1, T2> func)
            => t1 => func(arg, t1);
        public static Func<T1, T2, T3> ProcessWith<T, T1, T2, T3>(this T arg, Func<T, T1, T2, T3> func)
            => (t1, t2) => func(arg, t1, t2);
        public static Func<T1, T2, T3, T4> ProcessWith<T, T1, T2, T3, T4>(this T arg, Func<T, T1, T2, T3, T4> func)
            => (t1, t2, t3) => func(arg, t1, t2, t3);
        public static Func<T1, T2, T3, T4, T5> ProcessWith<T, T1, T2, T3, T4, T5>(this T arg, Func<T, T1, T2, T3, T4, T5> func)
            => (t1, t2, t3, t4) => func(arg, t1, t2, t3, t4);
    }
}
