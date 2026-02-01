// See https://aka.ms/new-console-template for more information

//Input
using System.Collections.Generic;


List<int> candles = new List<int> { 3, 2, 1, 3 };
////////////////////////

// Solution A:
// int max = candles.Max();
// int count = candles.Count(c => c == max);
// Console.WriteLine(count);

// Solution B:
int max = 0;
int count = 0;

foreach (int candle in candles)
{
    if (candle > max)
    {
        max = candle;
        count = 1;
    }
    else if (max == candle)
        count++;
}

Console.WriteLine(count);

