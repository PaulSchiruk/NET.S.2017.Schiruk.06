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
        private enum switchEnum
        {
            increaseSum,
            decreaseSum,
            increaseMax,
            decreaseMax,
            increaseMin,
            decreaseMin
        };
        public static int[][] Algorithm(int[][] array, Comparison<int[]> comparison)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparison(array[i],array[j]) > 0)
                        Swap(array[i],array[j]);
                }
            }



            return null;
        }

        private static void Swap(int[] lhs, int[] rhs)
        {
            int[] temp = lhs;
            lhs = rhs;
            rhs = temp;
        }


        public static int IncreaseSumComp(int[] lhs, int[] rhs) => lhs.Sum() - rhs.Sum();
        private static int DecreaseSumComp(int[] lhs, int[] rhs) => IncreaseSumComp(rhs,lhs);
        private static int IncreaseMaxComp(int[] lhs, int[] rhs) => lhs.Max() - rhs.Max();
        private static int DecreaseMaxComp(int[] lhs, int[] rhs) => IncreaseMaxComp(rhs, lhs);
        private static int IncreaseMinComp(int[] lhs, int[] rhs) => lhs.Min() - rhs.Min();
        private static int DecreaseMinComp(int[] lhs, int[] rhs) => IncreaseMinComp(rhs, lhs);


        public static void Sort(int[][] array)
        {
            Console.WriteLine("Type in with way you want to sort");
            switchEnum tmp = (switchEnum)Console.Read();
            Comparison<int[]> comparison;
            switch (tmp)
            {
                case switchEnum.increaseSum:
                    comparison = IncreaseSumComp;
                    break;

                case switchEnum.decreaseSum:
                    comparison = DecreaseSumComp;
                    break;

                case switchEnum.increaseMax:
                    comparison = IncreaseMaxComp;
                    break;

                case switchEnum.decreaseMax:
                    comparison = DecreaseMaxComp;
                    break;
                case switchEnum.increaseMin:
                    comparison = IncreaseMinComp;
                    break;

                case switchEnum.decreaseMin:
                    comparison = DecreaseMinComp;
                    break;
                default: comparison = null;
                    break;
            }

            Algorithm(array, comparison);
        }
    }
}
