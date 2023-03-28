using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Basics
{
    public class TowNumberSum
    {

        // My Solution without AlgoExpert


        // O(n^2) time, O(1) space
        public int[] towNumberSum(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var firstNum = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    var secondNum = array[j];

                    if (firstNum + secondNum == target)
                    {
                        Console.WriteLine("FirstNum: " + firstNum + " Second Num: " + secondNum);
                        return new int[] { firstNum, secondNum };
                    }
                }
            }

            return new int[0];
        }


        // O(n) time, O(n) space
        public int[] towNumberSumHas(int[] array, int target)
        {
            var hashtable = new Hashtable();
            foreach (var item in array)
            {
                var potentialMatch = target - item;
                if (hashtable.Contains(potentialMatch))
                {
                    Console.WriteLine("FirstNum: " + potentialMatch + " Second Num: " + item);
                    return new int[] { potentialMatch, item };
                }
                else
                {
                    hashtable.Add(item, true);
                }
            }
            return new int[0];
        }


        public int[] twoNumberSumPointer(int[] array, int target)
        {
            Array.Sort(array);

            var left = 0;
            var right = array.Length - 1;

            while (left < right)
            {
                var currentSum = array[left] + array[right];
                if (currentSum == target)
                {
                    Console.WriteLine("FirstNum: " + array[left] + " Second Num: " + array[right]);
                    return new int[] { array[left], array[right] };
                }
                else if(currentSum < target) left++;
                else right--;
            }

            return new int[0];
        }

    }
}


