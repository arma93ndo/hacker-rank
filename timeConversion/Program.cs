// See https://aka.ms/new-console-template for more information

// Input:


string s = "12:05:45PM";
//////////////////////////

string[] strings = s.Split(':');

string hour = strings[0];
string minutes = strings[1];
string seconds = strings[2];
string p = seconds[2].ToString();

seconds = seconds.Remove(2);

if (p == "P")
{
    hour = (int.Parse(hour) + 12).ToString();
}

if (hour == "12" && p == "A")
{
    hour = "00";
}

if (hour == "24" && p == "P")
{
    hour = "12";
}

Console.WriteLine(hour + ":" + minutes + ":" + seconds);
