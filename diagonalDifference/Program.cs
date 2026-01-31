// See https://aka.ms/new-console-template for more information

// Input
using System;


List<List<int>> arr = new List<List<int>> {
    new List<int> { 11, 2, 4 },
    new List<int> { 4, 5, 6 },
    new List<int> { 10, 8, -12 }
};

/////////////////////////////////////////////
int leftToRight = 0;
int rightToLeft = 0;

for (int i = 0; i < arr.Count; i++)
{
    leftToRight += arr[i][i];
    rightToLeft += arr[i][(arr.Count - 1) - i];
}

Console.WriteLine(leftToRight);
Console.WriteLine(rightToLeft);

Console.WriteLine(Math.Abs(leftToRight - rightToLeft));
