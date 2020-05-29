using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8Features.Examples
{
    public static class DeferedLinq
    {
        public static bool Any2<T>(this IEnumerable<T> collection, Predicate<T> predicate)
        {
            foreach (var item in collection)
            {
                if (predicate(item))
                {
                    return true;
                }
            }

            return false;
        }

        public static async Task<bool> Any3<T>(IAsyncEnumerable<T> collection, Predicate<T> predicate)
        {
            await foreach (var item in collection)
            {
                if (predicate(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
