using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Basics
{
    public class TowNumberSum
    {
       
        // My Solution without AlgoExpert
       public void TwoNumberSum(int[] arr, int n)
        {
            if (arr.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = i+1; j < arr.Length; j++)
                    {
                        if (arr[i] + arr[j] == n)
                        {
                           int[] result = new int[] { arr[i], arr[j] };
                            foreach (var item in result)
                            {
                                Console.Write(item + " -- ");
                            }
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("Array is empty!!!");
        }

        // Second solution for  Using HashSet
        public void TwoNumberSumHashSet(int[] arr, int targerSum)
        {
            HashSet<int> hashSet = new HashSet<int>();
            foreach (var item in arr)
            {
                int potentialNumber = targerSum - item;
                if (hashSet.Contains(potentialNumber))
                {
                    int[] result = new int[] { potentialNumber ,item};
                    foreach (var rs in result)
                    {
                        Console.Write(rs + " -- ");
                    }
                    return;
                }
                hashSet.Add(item);
            }
        }
    }
}
