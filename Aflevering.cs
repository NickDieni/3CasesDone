using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_For_3Cases;

namespace ClassLibrary_For_3Cases
{
    public class Aflevering
    {
        public void AntalAfleveringer(bool debug)
        {
            string Antalstring;

            OutPut op = new OutPut();

            op.PrintLine(debug, "Indtast antal afleveringer kun i tal: ");
            int Antal = Convert.ToInt32(Console.ReadLine());
            Antalstring = Antal.ToString();
            op.PrintLine(debug, "");
            //Den udskriver Shh hvis der er nul afleveringer
            if (Antal == 0)
            {
                op.PrintLine(debug, "Shh");
            }
            //Hvis der er mellem 1 og 10 afleveringer så siger den huh! alt efter hvor mange gange
            else if (Antal >= 1 && Antal < 10)
            {
                string print = "";
                for (int i = 0; i < Antal; i++)
                {
                    print += "Huh!";
                }
                op.PrintLine(debug, print);
            }
            //Den ændre niveau af jubel alt efter hvor man afleveringer
            else if (Antal >= 10)
            {
                if (Antal <= 13)
                {
                    op.PrintLine(debug, "High Five - Jubel");
                }
                if (Antal > 13 && Antal <= 16)
                {
                    op.PrintLine(debug, "High Five - Jubel!");
                }
                if (Antal > 16 && Antal <= 19)
                {
                    op.PrintLine(debug, "High Five - Jubel!!");
                }
                if (Antal >= 20)
                {
                    op.PrintLine(debug, "High Five - Jubel!!!");
                }
            }
            //Giver muligheden at start om
            op.PrintLine(debug, "");
            op.PrintLine(debug, "Tryk på en tast for at gå tilbage til start");

            Pickmenu nyValg = new Pickmenu();
            Console.ReadKey();
            Console.Clear();
            nyValg.Vælg(debug);

        }
    }
}
