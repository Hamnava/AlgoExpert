using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Medium
{
    public class MediumAlgorithm
    {
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
                    else if(currentSum > targetSum) right--;

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
    }
}
