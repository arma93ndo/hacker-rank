// See https://aka.ms/new-console-template for more information

// Input:

int year = 1918; // 2016, 1800, 2017
////////////////////////////////////////
string dayOfTheProgrammer = "";

if (year <= 1917)
{   // Julian calendar used.
    // Leap years are divisible by 4.
    if (year % 4 == 0)
    {   // It's a leap year.
        dayOfTheProgrammer = "12.09." + year.ToString();
    }
    else
    { // It's a regular year.
        dayOfTheProgrammer = "13.09." + year.ToString();
    }
}
else if( year == 1918)
{
    dayOfTheProgrammer = "26.09." + year;
}
else
{   // Gregorian calendar used.
    // Leap years are either:
    // - Divisible by 400.
    // - Divisible by 4 but not by 100.
    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0) )
    {   // It's a leap year.
        dayOfTheProgrammer = "12.09." + year.ToString();
        
    }
    else
    {   // It's a regular year.
        dayOfTheProgrammer = "13.09." + year.ToString();
    }
    
}

Console.WriteLine(dayOfTheProgrammer);



