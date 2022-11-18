using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_For_3Cases
{
    public class Fodbold
    {

        public void Visfodbold(bool debug)
        {
            //Oprette de forkellige objecter
            Mål nyMål = new Mål();
            Aflevering nyAflevering = new Aflevering();
            Pickmenu nyValg = new Pickmenu();
            OutPut op = new OutPut();

            string Jaellernej;
            string resultat;

            //Forklar useren de forskellige ting de kan gøre
            Console.Clear();
            op.PrintLine(debug, "Velkommen til fodbold");
            op.PrintLine(debug, "");
            op.PrintLine(debug, "Du kan skrive tilbage for at gå tilbage til start");
            op.PrintLine(debug, "");
            op.PrintLine(debug, "Har der været mål ja/nej?: ");
            Jaellernej = Console.ReadLine();
            //laver resultat til lower
            resultat = Jaellernej.ToLower();

            //gør de forskellige ting alt efter hvad der er bliver skrevet
            switch (resultat)
            {
                case "ja":
                    Console.Clear();
                    nyMål.Målcheck(debug);
                    break;

                case "nej":
                    Console.Clear();
                    nyAflevering.AntalAfleveringer(debug);
                    break;
                case "tilbage":
                    Console.Clear();
                    nyValg.Vælg(debug);
                    break;
                default:
                    Console.Clear();
                    op.PrintLine(debug, "Prøv igen, du kan kun taste ja eller nej du kan også skrive tilbage");
                    Console.ReadKey();
                    Visfodbold(debug);
                    break;
            }
        }
    }
}
