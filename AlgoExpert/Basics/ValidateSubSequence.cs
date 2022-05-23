using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Basics
{
    public class ValidateSubSequence
    {
        public void CheckSubSequence(int[] arrary, int[] subsequence)
        {
            int arraryIdx = 0;
            int subsequenceIdx = 0;
            List<int> list = new List<int>();

            while (arraryIdx < arrary.Length && subsequenceIdx < subsequence.Length)
            {
                if (subsequence[subsequenceIdx] == arrary[arraryIdx])
                {
                    list.Add(subsequence[subsequenceIdx]);
                    subsequenceIdx += 1;
                }
                else
                {
                    arraryIdx += 1;
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine("Your subsequence : "+ item);
            }
        }
    }
}
