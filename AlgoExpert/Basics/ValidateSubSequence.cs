using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Basics
{
    public class ValidateSubSequence
    {

        // O(N) time, O(1) space
        public bool validateSubSequence(int[] array, int[] subAarry)
        {
            var arrIdx = 0;
            var subArIdx = 0;

            while (arrIdx < array.Length && subArIdx < subAarry.Length)
            {
                if (array[arrIdx] == subAarry[subArIdx])
                {
                    subArIdx++;
                }
                arrIdx++;
            }
            Console.WriteLine(subArIdx == subAarry.Length);
            return subArIdx == subAarry.Length;
        }


        // O(N) time, O(1) space
        public bool validateSubSequenceForLoop(int[] array, int[] subAarry)
        {
            var subIdx = 0;
            foreach (var item in array)
            {
                if (subIdx == subAarry.Length) break;

                if(item == subAarry[subIdx]) subIdx++;
            }
            return subIdx == subAarry.Length;
        }
    }
}
