// See https://aka.ms/new-console-template for more information

// Input:
List<int> s = new List<int> {1, 1, 1, 1, 1, 1};
int d = 3;
int m = 2;
//////////////////////////////////

int ways = 0;

for (int i = 0; i < s.Count; i++)
{
    int sum = 0;
    int flag = 0;
    for(int j = i; j < s.Count && flag < m; j++, flag++)
    {
        sum += s[j];
    }

    if (flag == m && sum == d) ways++;
}

Console.WriteLine(ways);

return ways;

