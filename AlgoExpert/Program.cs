// See https://aka.ms/new-console-template for more information

// This is gonna show all the algorithms which is thought in AlgoExpert website
// So, it will be so beneficial for those who want to have a look and the implemantation type
// In C# Language.


using AlgoExpert.Basics;

TowNumberSum sum = new TowNumberSum();

int[] arr = new int[] { 1, 12, -3, 23, 15, 6, -7, 8, 11 };
int n = 20;
sum.TwoNumberSum(arr, n);

sum.TwoNumberSumHashSet(arr, n);