// See https://aka.ms/new-console-template for more information

// Input:

int n = 9;
List<int> ar = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
/////////////////////////

// Dictionary<int, int> pairs = new Dictionary<int, int>();

// pairs.Add(20, 1);
// pairs.Add(10, 1);

// foreach(var item in pairs)
// {
//     Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
// }



// HashSet<int> hash = new HashSet<int> ();

// hash.Add(10);
// hash.Add(20);
// hash.Add(30);
// hash.Add(50);

// foreach(int item in hash)
// {
//     Console.WriteLine(item);
// }

Dictionary<int, int> socks = new Dictionary<int, int>();
HashSet<int> set = new HashSet<int>();

foreach(int item in ar)
{
    set.Add(item);
}

foreach(int item in set)
{
    socks.Add(item, 0);
}

foreach(int item in ar)
{
    socks[item]++;
}

int pairs = 0;
foreach(var item in socks)
{
    int amount = Convert.ToInt32(item.Value);
    pairs += amount / 2;
}


Console.WriteLine(pairs);


