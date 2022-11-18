using System;
using System.Diagnostics;

namespace ClassLibrary_For_3Cases
{
    public class Pickmenu
    {
        private string Checker1;

        public void Vælg(bool debug)
        {
            //Jeg laver en object sådan jeg kan ændre hvad der vises 
            Fodbold nyFodbold = new Fodbold();
            Danserresultat nyDans = new Danserresultat();
            OutPut op = new OutPut();
            //Fortæller useren hvad de skal vælge for at komme de forskellige steder
            Console.Clear();
            op.PrintLine(debug, "Velkommen, vælg det program du vil køre");
            op.PrintLine(debug, "");
            op.PrintLine(debug, "Tryk 1 for Fodbold Klub");
            op.PrintLine(debug, "");
            op.PrintLine(debug, "Tryk 2 for Danse Konkurrence");
            op.PrintLine(debug, "");
            Checker1 = Console.ReadLine();

            //En menu til at vælge de forskellige programmer
            switch (Checker1)
            {
                case "1":
                    Console.Clear();
                    nyFodbold.Visfodbold(debug);
                    break;
                case "2":
                    Console.Clear();
                    nyDans.DanserInd(debug);
                    break;
                default:
                    op.PrintLine(debug, "Fejl prøv igen");
                    Console.ReadKey();
                    Vælg(debug);
                    break;
            }
        }

    }
    public class OutPut
    {
        //Metode for debug 
        public void PrintLine(bool debug, string print)
        {
            //Hvis en er true så skriver den dette
            if (debug)
            {
                System.Diagnostics.Debug.WriteLine(print);
            }
            //Hvis debug er false så skriver den Write hvis der er : hvis ikke så laver den en normal writeline
            else
            {
                if (print.Contains(":"))
                {
                    Console.Write($"{print} ");
                }
                else
                {
                    Console.WriteLine(print);
                }
            }
        }
    }
}
