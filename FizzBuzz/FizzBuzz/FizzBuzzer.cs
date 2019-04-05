using System.Collections.Generic;

namespace FizzBuzz
{
    internal static class FizzBuzzer
    {
        #region CONSTS

        private const int FIZZ = 3;
        private const int BUZZ = 5;

        #endregion

        #region METHODS

        internal static IEnumerable<string> FizzBuzzRange(int min, int max, bool variant = false)
        {
            for (int i = min; i <= max; i++)
            {
                if (IsFizzBuzz(i))
                {
                    yield return "FizzBuzz";
                }
                else if (IsFizz(i, variant))
                {
                    yield return "Fizz";
                }
                else if (IsBuzz(i, variant))
                {
                    yield return "Buzz";
                }
                else
                {
                    yield return i.ToString();
                }
            }
        }

        private static bool IsFizzBuzz(int i)
        {
            return IsFizz(i) && IsBuzz(i);
        }

        private static bool IsBuzz(int i, bool variant = false)
        {
            return i % BUZZ == 0 || i.ToString().Contains(BUZZ.ToString());
        }

        private static bool IsFizz(int i, bool variant = false)
        {
            return i % FIZZ == 0 || i.ToString().Contains(FIZZ.ToString());
        }

        #endregion
    }
}
