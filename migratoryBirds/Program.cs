// See https://aka.ms/new-console-template for more information

// Input:
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

List<int> arr = new List<int> {1, 4, 4, 4, 5, 3};
//////////////////////////////////

int[] types = new int[6];

for (int i = 0; i < arr.Count; i++)
{
    types[arr[i]]++;
}

int max = int.MinValue;
int mode = 0;
for(int i = 0; i < types.Length; i++)
{
    if (types[i] > max)
    {
        max = types[i];
        mode = i;    
    }
}

Console.WriteLine(mode);
