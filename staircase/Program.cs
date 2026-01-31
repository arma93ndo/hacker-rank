// See https://aka.ms/new-console-template for more information

// Input


int n = 6;
////////////////////////////////

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (n - (i + 1) > j)
        {
            Console.Write(" ");

        }
        else
        {
            Console.Write("#");
        }
    }
    Console.WriteLine();
}


