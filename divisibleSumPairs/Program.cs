// See https://aka.ms/new-console-template for more information

// Input:

int n = 6; 
int k = 3;
List<int> ar = new List<int> {1, 3, 2, 6, 1, 2};

///////////////////////////////

int pairs = 0;

for(int i = 0; i < ar.Count; i++)
{
    for(int j = i + 1; j < ar.Count; j++)
    {
        if ((ar[i] + ar[j]) % k == 0) pairs++;
    }
}

Console.WriteLine(pairs);


