// See https://aka.ms/new-console-template for more information
using Algoritms;
using Algoritms.Group;

Console.WriteLine(Anagrams.GroupAnagrams());

//Console.WriteLine("How many way I can climb a 3 stair using 2 or 1 steps"  + "Answer: " + Fibonacci.Climbing(3));
Console.WriteLine("Find the position of following number in the array: target 5  array {-4,3,10,12,4,8,5,-2,1}" + "Answer: " + BinarySearch.GetNumber(new int[] {-4,3,10,12,4,8,5,-2,1}, 5));
double[] temperatures = { -5.6, 2.3, -0.5, 1.8, 0.5 };

double closestTemp = ClosestTemperature.ClosestToZero(temperatures);
Console.ReadLine();
