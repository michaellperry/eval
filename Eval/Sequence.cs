using System.Collections.Generic;
using System.Linq;

namespace Eval
{
    public class Sequence
    {
        public static IEnumerable<int> GetOddNumbers(IEnumerable<int> numbers)
        {
            var odds = numbers.Where(n => n % 2 != 0).ToList();
            return odds;
        }

        public static IEnumerable<int> GetPositiveIntegers()
        {
            int i = 1;
            while (true)
            {
                yield return i++;
            }

        }
    }
}
