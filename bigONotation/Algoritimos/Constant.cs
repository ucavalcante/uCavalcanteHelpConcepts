using System;

namespace bigONotation.Algoritimos 
{
    public static class Constant // O(1)
    {
        public static bool IsEven(int[] array, int index)
        {
            return array[index] % 2 == 0;
        }
    }
}