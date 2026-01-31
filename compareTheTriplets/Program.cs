// See https://aka.ms/new-console-template for more information
// Input
using System;

List<int> a = new List<int> { 17, 28, 30 };
List<int> b = new List<int> { 99, 16, 8 };


////////////////////////////////////////////////////////////////

List<int> result = new List<int>();
result.Add(0);
result.Add(0);

for (int i = 0; i < a.Count; i++)
{
    if (a[i] > b[i])
        result[0]++;
    else if (b[i] > a[i])
        result[1]++;
}

Console.WriteLine(result[0] + ", " + result[1]);
