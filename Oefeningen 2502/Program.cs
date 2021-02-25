using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefeningen_2502
{
    class Program
    {
        static void Main(string[] args)
        {
            // oefening 1
            Console.WriteLine("Oefening 1: ");
            Console.WriteLine(@"C:\Users\Field\Documents\Oefening");

            // oefening 2

            Console.WriteLine("Oefening 2: ");
            Console.WriteLine("\"Dit is een toffe les!\"");

            // oefening 3

            Console.WriteLine("Oefening 3: ");
            int getal1 = 1;
            int getal2 = 2;
            int temp;

            Console.WriteLine($"Getal 1: {getal1}\nGetal 2: {getal2}");

            temp = getal1;
            getal1 = getal2;
            getal2 = temp;

            Console.WriteLine($"Getal1: {getal1}\nGetal 2: {getal2}");


            // oefening 4

            Console.WriteLine("Oefening 4: ");
            string mijnString = "Dit is mijn STRING";

            Console.WriteLine($"De lengte van {mijnString} is: " + mijnString.Length);

            // oefening 5

            Console.WriteLine("Oefening 5: ");
            Console.WriteLine($"\"{mijnString}\" in hoofdletters is: " + mijnString.ToUpper());

            Console.WriteLine($"\"{mijnString}\" in kleineletters is: " + mijnString.ToLower());

            // oefening 6

            Console.WriteLine("Oefening 6: ");
            string tempString;

            tempString = mijnString.ToUpper().Substring(0, 1) + mijnString.ToLower().Substring(1, mijnString.Length - 1);
            Console.WriteLine($"De eerste letter van \"{mijnString}\" in hoodletters, de rest klein: " + tempString);

            // oefening 7

            Console.WriteLine("Oefening 7: ");
            mijnString = "Dit is een leuke zin.";

            Console.WriteLine($"String: {mijnString}\n" + mijnString.Replace(" ", "_"));

            // oefening 8

            Console.WriteLine("Oefening 8: ");
            Console.WriteLine($"Teken op de 5e plaats van \"{mijnString}\" is: " + mijnString.Substring(4, 1));

            // oefening 9

            Console.WriteLine("Oefening 9: ");
            Console.WriteLine($"De index van de eerste letter e in \"{mijnString}\" is: " + mijnString.IndexOf("e"));

            // oefening 10

            Console.WriteLine("Oefening 10: ");
            Console.Write("Geef mij een letter (niet Z): ");
            string mijnInput = Console.ReadLine();

            char character = mijnInput.ToCharArray()[0];

            Console.WriteLine("Volgende letter in het alphabet is: " + (char)(character +1));

            // oefening 11

            Console.WriteLine("Oefening 11: ");
            Console.WriteLine($"Mijn machinenaam is: " + Environment.MachineName);

            // oefening 12

            Console.Write("Getal: ");
            int mijnGetal = Convert.ToInt32(Console.ReadLine());
            double derdeMacht = Math.Pow(mijnGetal, 3);
            double vierKantsW = Math.Sqrt(derdeMacht);
            Console.WriteLine($"{mijnGetal} tot de 3e = "+derdeMacht);
            Console.WriteLine($"De vierkantswortel van " + vierKantsW);

            // oefening 13

            Console.Write("Getal 1: ");
            int getal4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal 2: ");
            int getal5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Getal 3: ");
            int getal6 = Convert.ToInt32(Console.ReadLine());

            int maxGetal = Math.Max(getal4, Math.Max(getal5, getal6));
            int minGetal = Math.Min(getal4, Math.Min(getal5, getal6));

            

            int midGetal = ((getal4==maxGetal) | (getal4 == minGetal))? ((getal5 == maxGetal) | (getal5 == minGetal))?getal6:getal5:getal4;

            midGetal = Math.Min(Math.Max(getal4, getal6), Math.Max(getal5, getal6));

            Console.WriteLine($" Middelste getal: " + midGetal);

            
            // oefening 14

            Console.Write("Getal: ");
            int nieuwGetal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Teken omgedraaid is: " + nieuwGetal*-1);

            // oefening 15

            Console.WriteLine("Getal: ");
            int nieuwGetal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Absolute waarde is: " + Math.Abs(nieuwGetal1));

            // wachten

            Console.ReadLine();
        }
    }
}
