using System;
using System.Collections.Generic;

namespace CSharp13
{
    public static class EnumerableExtensions
    {
        public static bool CustomAll<T>(this IEnumerable<T> e, Func<T, bool> f)
        {
            if (e == null)
                throw new ArgumentNullException(nameof(e));
            foreach (var element in e)
            {
                if (!f(element))
                    return false;
            }
            return true;
        }
        public static bool CustomAny<T>(this IEnumerable<T> e, Func<T, bool> f)
        {
            if (e == null)
                throw new ArgumentNullException(nameof(e));
            foreach (var element in e)
            {
                if (f(element))
                    return true;
            }
            return false;
        }
        public static TResult CustomMax<T, TResult>(this IEnumerable<T> e, Func<T, TResult> f) where TResult : IComparable<TResult>
        {
            if (e == null)
                throw new ArgumentNullException(nameof(e));
            TResult max;
            var a = e.GetEnumerator();
            if (a.MoveNext())
            {
                max = f(a.Current);
            }
            else throw new InvalidOperationException("There is no elements in the list.");
            while (a.MoveNext())
            {
                var result = f(a.Current);
                if (max == null || max.CompareTo(result) < 0)
                    max = result;
            }
            return max;
        }
        public static TResult CustomMin<T, TResult>(this IEnumerable<T> e, Func<T, TResult> f) where TResult : IComparable<TResult>
        {
            if (e == null)
                throw new ArgumentNullException(nameof(e));
            TResult min;
            var a = e.GetEnumerator();
            if (a.MoveNext())
            {
                min = f(a.Current);
            }
            else throw new InvalidOperationException("There is no elements in the list.");
            while (a.MoveNext())
            {
                var result = f(a.Current);
                if (min == null || min.CompareTo(result) > 0)
                    min = result;
            }
            return min;
        }
        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> e, Func<T, bool> f)
        {
            if (e == null)
                throw new ArgumentNullException(nameof(e));
            foreach (var element in e)
            {
                if (f(element))
                    yield return element;
            }
        }
        public static IEnumerable<TResult> CustomSelect<T, TResult>(this IEnumerable<T> e, Func<T, TResult> f)
        {
            if (e == null)
                throw new ArgumentNullException(nameof(e));
            foreach (var element in e)
            {
                yield return f(element);
            }
        }
    }
}
