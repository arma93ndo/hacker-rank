// See https://aka.ms/new-console-template for more information
using System.Numerics;


// Input

List<int> ar = new List<int> { 1, 2, 3, 4, 10, 11 };
////////////////////////

int sum = 0;
for (int i = 0; i < ar.Count; i++)
{
    sum += ar[i];
}

Console.WriteLine(sum);
