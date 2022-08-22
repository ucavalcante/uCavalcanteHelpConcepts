using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bigONotation.Algoritimos
{
    public static class Linear //O(n)
    {
        public static int GetMin(int[] array)
        {
            var minValue = array[0];

            foreach (var item in array)
            {
                if (item < minValue)
                    minValue = item;
            }

            return minValue;
        }
    }
}