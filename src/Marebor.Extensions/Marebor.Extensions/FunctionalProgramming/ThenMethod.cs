using System;

namespace Marebor.Extensions.FunctionalProgramming
{
    public static class ThenMethod
    {
        public static Func<T2> Then<T1, T2>(this Func<T1> f1, Func<T1, T2> f2)
            => () => f2(f1());
        public static Func<T2, T3> Then<T1, T2, T3>(this Func<T1> f1, Func<T1, T2, T3> f2)
            => t2 => f2(f1(), t2);
        public static Func<T2, T3, T4> Then<T1, T2, T3, T4>(this Func<T1> f1, Func<T1, T2, T3, T4> f2)
            => (t2, t3) => f2(f1(), t2, t3);
        public static Func<T2, T3, T4, T5> Then<T1, T2, T3, T4, T5>(this Func<T1> f1, Func<T1, T2, T3, T4, T5> f2)
            => (t2, t3, t4) => f2(f1(), t2, t3, t4);
        public static Func<T2, T3, T4, T5, T6> Then<T1, T2, T3, T4, T5, T6>(this Func<T1> f1, Func<T1, T2, T3, T4, T5, T6> f2)
            => (t2, t3, t4, t5) => f2(f1(), t2, t3, t4, t5);

        public static Action Then<T1>(this Func<T1> f1, Action<T1> f2)
            => () => f2(f1());
        public static Action<T2> Then<T1, T2>(this Func<T1> f1, Action<T1, T2> f2)
            => t2 => f2(f1(), t2);
        public static Action<T2, T3> Then<T1, T2, T3>(this Func<T1> f1, Action<T1, T2, T3> f2)
            => (t2, t3) => f2(f1(), t2, t3);
        public static Action<T2, T3, T4> Then<T1, T2, T3, T4>(this Func<T1> f1, Action<T1, T2, T3, T4> f2)
            => (t2, t3, t4) => f2(f1(), t2, t3, t4);
        public static Action<T2, T3, T4, T5> Then<T1, T2, T3, T4, T5>(this Func<T1> f1, Action<T1, T2, T3, T4, T5> f2)
            => (t2, t3, t4, t5) => f2(f1(), t2, t3, t4, t5);
    }
}
