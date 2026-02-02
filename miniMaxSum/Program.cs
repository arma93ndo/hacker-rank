// See https://aka.ms/new-console-template for more information

// Input:

using System;
using System.Collections.Generic;
using System.Numerics;

List<int> arr = new List<int> { 7, 69, 2, 221, 8974 };

/////////////////////////

long min = long.MaxValue;
long max = long.MinValue;

for (int i = 0; i < arr.Count; i++)
{
    long sum = 0;
    for (int j = 0; j < arr.Count; j++)
    {
        if (j == i) continue;

        sum += arr[j];
    }

    if (sum < min) min = sum;
    if (sum > max) max = sum;
}



Console.WriteLine(min + " " + max);
