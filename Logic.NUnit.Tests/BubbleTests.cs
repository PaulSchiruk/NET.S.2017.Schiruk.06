using System;
using System.Collections;
using System.Linq;
using NUnit.Framework;
using Logic;


namespace Logic.NUnit.Tests
{

    [TestFixture()]
    public class AlgorithmTests
    {
        [TestCase( ExpectedResult = true)]
        public bool BubbleSort_PositiveTests()
        { 
            int[][] tst = new int[6][];
            tst[0] = new int[] { 4, 18 };//22
            tst[1] = new int[] { 4, 18 };
            tst[2] = new int[] { 1, 0, -205, 15 };//-189
            tst[3] = new int[] { 1024, 1, 1 };//1026
            tst[4] = new int[] { 980, 606, 505, -2 };//2089
            tst[5] = new int[] { 1, 0, 1, 1, 3, 5, 18 };//29

            int[][] res = new int[6][];
            res[1] = new int[] { 4, 18 };
            res[2] = new int[] { 4, 18 };
            res[0] = new int[] { 1, 0, -205, 15 };
            res[4] = new int[] { 1024, 1, 1 };
            res[5] = new int[] { 980, 606, 505, -2 };
            res[3] = new int[] { 1, 0, 1, 1, 3, 5, 18 };
            IStructuralEquatable iStruct = res;
            IncreaseSumComp comparison = new IncreaseSumComp();

            BubbleSort.Algorithm(tst, comparison);


            return iStruct.Equals(tst, StructuralComparisons.StructuralEqualityComparer);
        }

        
    }
    
    public  class IncreaseSumComp: BubbleSort.IComparer
    {
        public int Comparer(int[] lhs, int[] rhs)  => lhs.Sum() - rhs.Sum();
    }
    public class DecreaseSumComp : BubbleSort.IComparer
    {
        public int Comparer(int[] lhs, int[] rhs) => rhs.Sum() - lhs.Sum();
    }
    public class IncreaseMaxComp : BubbleSort.IComparer
    {
        public int Comparer(int[] lhs, int[] rhs) => lhs.Max() - rhs.Max();
    }
    public class DecreaseMaxComp : BubbleSort.IComparer
    {
        public int Comparer(int[] lhs, int[] rhs) => rhs.Max() - lhs.Max();
    }
    public class IncreaseMinComp : BubbleSort.IComparer
    {
        public int Comparer(int[] lhs, int[] rhs) => lhs.Min() - rhs.Min();
    }
    public class DecreaseMinComp : BubbleSort.IComparer
    {
        public int Comparer(int[] lhs, int[] rhs) => rhs.Min() - lhs.Min();
    }
}