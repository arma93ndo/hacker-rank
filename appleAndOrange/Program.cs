// See https://aka.ms/new-console-template for more information
// Input:

int s = 7, t = 11, a = 5, b = 15; 
List<int> apples = new List<int> {-2, 2, 1};
List<int> oranges = new List<int> {5, -6};

/////////////////////

int applesCount = 0;
int orangesCount = 0;
for (int i = 0; i < apples.Count; i++)
{
    apples[i] = a + apples[i];

    if (apples[i] >= s && apples[i] <= t) applesCount++;
}

for (int i = 0; i < oranges.Count; i++)
{
    oranges[i] = b + oranges[i];
    
    if (oranges[i] >= s && oranges[i] <= t) orangesCount++;
}

Console.WriteLine(applesCount);
Console.WriteLine(orangesCount);