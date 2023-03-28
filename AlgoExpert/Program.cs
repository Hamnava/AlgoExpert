// See https://aka.ms/new-console-template for more information

// This is gonna show all the algorithms which is thought in AlgoExpert website
// So, it will be so beneficial for those who want to have a look and the implemantation type
// In C# Language.


using AlgoExpert.Basics;
using AlgoExpert.Medium;
using System.ComponentModel.DataAnnotations;


#region Basic


#region towNumberSum
//TowNumberSum sum = new TowNumberSum();

//int[] arr2 = new int[] { 13, -6, -8, 12, -3, 8, 11 };
//int n = 20;
//sum.twoNumberSumPointer(arr2, n);
#endregion

#region Validate Subsequence
var subSequence = new ValidateSubSequence();
int[] arr = new int[] { 13, -6, -8, 12, -1, 7, -3, 8, 11 };
int[] sub = new int[] { -6, 12, -1, 8, 11 };
subSequence.validateSubSequence(arr, sub);

#endregion

#endregion




#region Medium
MediumAlgorithm medium = new MediumAlgorithm();

//medium.ThreeNumberSum(arr,0);
//medium.SmallestDefference(arr, arr2);

//medium.MoveElementTotheEnd(array, 2);
#endregion
