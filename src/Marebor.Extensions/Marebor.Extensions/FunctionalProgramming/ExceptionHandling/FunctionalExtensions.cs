using System;

namespace Marebor.Extensions.FunctionalProgramming.ExceptionHandling
{
    public static class FunctionalExtensions
    {
        public static Action OnCustomException<TEx>(this Action action, Action<TEx> handler, bool propagate) where TEx : Exception => () =>
        {
            try
            {
                action();
            }
            catch (TEx ex)
            {
                handler(ex);
                if (!propagate)
                    throw;
            }
        };

        public static Action OnException(this Action action, Action<Exception> handler, bool propagate)
            => OnCustomException(action, handler, propagate);

        public static Func<T> OnCustomException<T, TEx>(this Func<T> func, Action<TEx> handler, Func<T> defaultReturn = null) where TEx : Exception => () =>
        {
            try
            {
                return func();
            }
            catch (TEx ex)
            {
                handler(ex);
                if (defaultReturn == null)
                    throw;
                else
                    return defaultReturn();
            }
        };

        public static Func<T> OnException<T>(this Func<T> func, Action<Exception> handler, Func<T> defaultReturn = null)
            => OnCustomException(func, handler, defaultReturn);
    }
}
