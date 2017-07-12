using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static  class BubbleSort
    {
        public static void Algorithm(int[][] array, IComparer comparison)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (comparison.Comparer(array[i],array[j]) > 0)
                        Swap(array[i],array[j]);
                }
            }
        }

        private static void Swap(int[] lhs, int[] rhs)
        {
            int[] temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        public interface IComparer
        {
            int Comparer(int[] lhs, int[] rhs);
        }

    }


    
}
