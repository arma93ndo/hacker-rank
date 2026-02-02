// See https://aka.ms/new-console-template for more information

// Input:

int x1 = 0, v1 = 2,  x2 = 5,  v2 = 3;
///////////////////////////////////////

int kangaroo1 = x1;
int kangarro2 = x2;
for (int i = 0; i < 10000; i++)
{
    if(kangaroo1 + (i * v1) == kangarro2 + (i * v2))
    {
        Console.WriteLine("YES");
    }
    
}

Console.WriteLine( "NO");

