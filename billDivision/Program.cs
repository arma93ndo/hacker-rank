// See https://aka.ms/new-console-template for more information


// Input:
List<int> bill = new List<int> {3, 10, 2, 9};
int k = 1;
int b = 12;
/////////////////////////

int sum = 0;
for (int i = 0; i < bill.Count; i++)
{
    if(i == k) continue;
    sum += bill[i];
}

int bActual = sum / 2;

if (b - bActual == 0)
{
    Console.WriteLine("Bon Appetit");
}
else
{
    Console.WriteLine(b - bActual);
}








