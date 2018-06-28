using System.Collections.Generic;
using System.Linq;

namespace Marebor.Extensions.String
{
    public static class StringExtensions
    {
        public static string AsString(this IEnumerable<char> chars)
            => new string(chars.ToArray());
    }
}
