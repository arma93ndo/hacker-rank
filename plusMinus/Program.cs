// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// Input

List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };
///////////////////////////////////////////

int positive = 0;
int negative = 0;
int zeroes = 0;

for (int i = 0; i < arr.Count; i++)
{
    if (arr[i] > 0)
        positive++;
    else if (arr[i] < 0)
        negative++;
    else if (arr[i] == 0)
        zeroes++;
}

Console.WriteLine("{0:0.######}", ((float)positive / arr.Count));
Console.WriteLine("{0:0.######}", (float)negative / arr.Count);
Console.WriteLine("{0:0.######}", (float)zeroes / arr.Count);

