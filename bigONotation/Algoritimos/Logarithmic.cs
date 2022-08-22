using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bigONotation.Algoritimos
{
    public static class Logarithmic // O(log n)
    {
        public static int BinarySearch(int[] array, int value)
        {
            array = array.OrderBy(_ => _).ToArray();

            var half = array.Length / 2;
            var midItem = array[half - 1 < 0 ? 0 : half - 1];

            if (midItem == value)
            {
                return midItem;
            }
            else if (value > midItem)
            {
                var halfArray = array.Skip(half).Take(half).ToArray();
                return BinarySearch(halfArray, value);
            }
            else
            {
                var halfArray = array.Take(half).ToArray();
                return BinarySearch(halfArray, value);
            }
        }
    }
}