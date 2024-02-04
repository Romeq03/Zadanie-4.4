using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList listaMiast = new ArrayList();

        listaMiast.Add("Gdańsk");
        listaMiast.Add("Warszawa");
        listaMiast.Add("Katowice");
        listaMiast.Add("Poznań");
        listaMiast.Add("Kraków");
        listaMiast.Add("Rzeszów");

        listaMiast.Sort();

        Console.WriteLine("Posortowane miasta:");
        foreach (string miasto in listaMiast)
        {
            Console.WriteLine(miasto);
        }

        Console.ReadLine();
    }
}
