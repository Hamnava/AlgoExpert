using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Basics.SelfTraining
{

    public class Solution
    {
		public int MaxSubArray(int[] nums)
		{
			int sum = 0;
			int maxSum = 0;
			int i = 0;

			if (nums.Length == 1) return nums[i];

			while (i < nums.Length)
			{

				if (nums[i] > sum + nums[i])
				{
					sum = nums[i];
				}
				else
				{
					sum += nums[i];
				}
				if (sum > maxSum)
				{
					maxSum = sum;
				}
				i++;
			}

			return maxSum;
		}
		public int FirstUniqChar(string s)
        {
            var distinct = s.Distinct().ToArray();
            return s.IndexOf(distinct[0]);
        }
        public int MaxProfit(int[] prices)
        {
            int buy = prices[0];
            int sell = prices[2];
            int buyDay = 1;
            int sellDay = 1;

            for (int i = 1; i < prices.Length; i++)
            {
                if (buy > prices[i])
                {
                    buy = prices[i];
                    buyDay++;
                }
                if (sellDay <= buyDay)
                {
                    sellDay++;
                    continue;
                }
                else
                {
                    sell = prices[i];
                    sellDay = i;
                }
            }
            
            return (buyDay < sellDay && buy < sell) ? sell - buy : 0;
        }


        public bool ContainsDuplicate(int[] nums)
        {
            int[] arr = nums.Distinct().ToArray();
            return arr.Length < nums.Length;
        }
        public int MaximumWealth(int[][] accounts)
        {
            int max = 0;

            foreach (var count in accounts)
            {
                count.Distinct();
                max = Math.Max(max, count.Sum());
            }
            return max;
        }
        public class BinaryTreeNode<T>
        {
            public T Value { get; set; }
            public BinaryTreeNode<T> LeftChild { get; set; }
            public BinaryTreeNode<T> RightChild { get; set; }

            public BinaryTreeNode(T value)
            {
                Value = value;
                LeftChild = null;
                RightChild = null;
            }
        }

        public class BinraySearchTree<T> where T : IComparable<T>
        {
            private BinaryTreeNode<T> Root { get; set; }

            public void AddNode(T value)
            {
                BinaryTreeNode<T> node = new BinaryTreeNode<T>(value);

                if (Root == null)
                {
                    Root = node;
                }
                else
                {
                    AddNode(node, Root);
                }
            }

            private void AddNode(BinaryTreeNode<T> node, BinaryTreeNode<T> current)
            {
                if (node.Value.CompareTo(current.Value) < 0)
                {
                    if (current.LeftChild == null)
                    {
                        current.LeftChild = node;
                    }
                    else
                    {
                        AddNode(node, current.LeftChild);
                    }
                }
                else
                {
                    if (current.RightChild == null)
                    {
                        current.RightChild = node;
                    }
                    else
                    {
                        AddNode(node, current.RightChild);
                    }
                }
            }



            public T FindClosestValue(T value)
            {
                return FindClosestValue(value, Root, default(T?)) ?? default(T);
            }

            private T? FindClosestValue(T value, BinaryTreeNode<T> current, T? closestValue)
            {
                if (current == null)
                {
                    return closestValue;
                }

                if (closestValue == null || Math.Abs(current.Value.CompareTo(value)) < Math.Abs(closestValue.CompareTo(value)))
                {
                    closestValue = current.Value;
                }

                if (value.CompareTo(current.Value) < 0)
                {
                    return FindClosestValue(value, current.LeftChild, closestValue);
                }
                else if (value.CompareTo(current.Value) > 0)
                {
                    return FindClosestValue(value, current.RightChild, closestValue);
                }
                else
                {
                    return closestValue;
                }
            }
        }
    }
}

