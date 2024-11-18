using System;

// Lag en metode som tar imot to tall og returnerer summen av tallene dersom de er ulike, 
og returnerer tallene multiplisert med hverandre dersom de er like

class CCXVI
{
    static void Main(string[] args)
    {
        int x = 9;
        int y = 9;

        if (x == y)
        {
            console.writeLine(x * y);
        }
        else
        {
            console.writeLine(x + y);
        }
    }
}