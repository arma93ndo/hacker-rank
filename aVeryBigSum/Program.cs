// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
// Input
List<long> ar = new List<long> { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

/////////////////////////////

long sum = 0;
for (int i = 0; i < ar.Count; i++)
    sum += ar[i];


Console.WriteLine(sum);
// return sum;
