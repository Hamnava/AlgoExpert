﻿// See https://aka.ms/new-console-template for more information

// This is gonna show all the algorithms which is thought in AlgoExpert website
// So, it will be so beneficial for those who want to have a look and the implemantation type
// In C# Language.


using AlgoExpert.Basics;
using AlgoExpert.Medium;



//TowNumberSum sum = new TowNumberSum();

//ValidateSubSequence seq = new ValidateSubSequence();

int[] arr = new int[] { -1, 1, 2, 3,5, -6,-8, 12, -3,  8, 11 };
//int[] arr2 = new int[] { -1, 12, -3, };
//int n = 20;
////sum.TwoNumberSum(arr, n);

////sum.TwoNumberSumHashSet(arr, n);

////sum.TowNumberSumTwoSide(arr, n);
//seq.CheckSubSequence2(arr, arr2);

#region Medium
MediumAlgorithm medium = new MediumAlgorithm();

medium.ThreeNumberSum(arr,0);
#endregion
