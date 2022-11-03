using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bigONotation.Algoritimos
{
    public static class Polinomial
    {
        public static int[] BubbleSort(int[] unsortedList)
        {
            int temp;
            for (int i = 0; i < unsortedList.Length; i++)
            {
                for (int j = 0; j < unsortedList.Length - (1 + i); j++)
                {
                    if (unsortedList[j] > unsortedList[j + 1])
                    {
                        temp = unsortedList[j + 1];
                        unsortedList[j + 1] = unsortedList[j];
                        unsortedList[j] = temp;
                    }
                }
            }

            return unsortedList;
        }
    }
}