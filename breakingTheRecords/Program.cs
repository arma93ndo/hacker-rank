// See https://aka.ms/new-console-template for more information

// Input:
List<int> scores = new List<int> {10, 5, 20, 20, 4, 5, 2, 25, 1};
////////////////////////////

List<int> results = new List<int>();

int most = scores[0];
int least = scores[0];

int best = 0;
int worst = 0;

for(int i = 1; i < scores.Count; i++)
{
    if(scores[i] > most)
    {
        most = scores[i];
        best++;
    }

    if(scores[i] < least)
    {
        least = scores[i];
        worst++;
    }
}

results.Add(best);
results.Add(worst);

Console.WriteLine(best);
Console.WriteLine(worst);

// return results;