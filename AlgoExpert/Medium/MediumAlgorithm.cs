using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class MediumAlgorithm
    {
        // Time O(n^2) and spanc O(n)
        public void ThreeNumberSum(int[] array, int targetSum)
        {
            Array.Sort(array);

            List<int[]> triplate = new List<int[]>();
            for (int i = 0; i < array.Length - 2; i++)
            {
                int left = i + 1;
                int right = array.Length - 1;
                while (left < right)
                {
                    int currentSum = array[i] + array[right] + array[left];
                    if (currentSum == targetSum)
                    {
                        int[] newTriplate = new int[] { array[i], array[left], array[right] };
                        triplate.Add(newTriplate);
                        left++;
                        right--;
                    }
                    else if (currentSum < targetSum) left++;
                    else if (currentSum > targetSum) right--;

                }
            }

            foreach (var item in triplate)
            {
                foreach (var items in item)
                {
                    Console.Write(" --> " + items + " -- ");
                }
                Console.WriteLine();
            }
        }


        // Time O(nlog(n) + mlog(m)) and space O(1) constant
        public void SmallestDefference(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int idxOne = 0;
            int idxTwo = 0;

            int smallest = Int32.MaxValue;
            int current = Int32.MaxValue;


            int[] PairResult = new int[2];

            while (idxOne < arrayOne.Length && idxTwo < arrayTwo.Length)
            {
                int firstName = arrayOne[idxOne];
                int secondName = arrayTwo[idxTwo];

                if (firstName < secondName)
                {
                    current = secondName - firstName;
                    idxOne++;
                }
                else if (firstName > secondName)
                {
                    current = firstName - secondName;
                    idxTwo++;
                }
                else
                {
                    PairResult = new int[] { firstName, secondName };
                    Console.WriteLine(firstName + " <--> " + secondName + " : " + 0);
                    return;
                }
                if (smallest > current)
                {
                    smallest = current;
                    PairResult = new int[] { firstName, secondName };
                    Console.WriteLine(firstName + " <--> " + secondName + " : " + smallest);
                }
            }
         
        }
    }
}
