// See https://aka.ms/new-console-template for more information

// Input:
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;


List<int> grades = new List<int> {
    73, 67, 38, 33
};
////////////////////////


for (int i = 0; i < grades.Count; i++)
{
    if (grades[i] < 38) continue;

    int nextMultiple = grades[i] + 1;

    while (nextMultiple % 5 != 0)
        nextMultiple++;

    if (nextMultiple - grades[i] < 3)
        grades[i] = nextMultiple;

}


foreach (int grade in grades)
{
    Console.WriteLine(grade);
}