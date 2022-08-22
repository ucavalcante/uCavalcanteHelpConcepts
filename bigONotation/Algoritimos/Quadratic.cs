using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bigONotation.Algoritimos
{
    public static class Quadratic //O(n^2)
    {
        public static bool hasDuplicates(int[] array)
        {

            for (int a = 0; a < array.Length; a++)
            {
                for (int b = 0; b < array.Length; b++)
                {
                    if (a == b) 
                    continue;

                    if (array[a] == array[b])
                        return true;
                }
            }
            return false;

            // List<int> unique = new List<int>();
            // foreach (var item in array)
            // {
            //     if (unique.Contains(item))
            //     {
            //         return true;
            //     }
            //     else
            //     {
            //         unique.Add(item);
            //     }
            // }
            // return false;
        }
    }
}