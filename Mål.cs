using System;
using System.Text.RegularExpressions;

namespace ClassLibrary_For_3Cases
{
    public class Mål
    {
        //Laver string arrays som skal bruges senere
        public string[] CheckM = { "M", "m" };
        public string[] CheckÅ = { "Å", "å" };
        public string[] CheckL = { "L", "l" };


        public void Målcheck(bool debug)
        {
            //Opretter objecter
            Fodbold fodbold = new Fodbold();
            OutPut op = new OutPut();
            //Laver variabler
            string Skrivmål;

            //Fortæller brugeren hvad de skal gøre
            op.PrintLine(debug, "Skriv mål hvis der har været mål: ");
            Skrivmål = Console.ReadLine();

            //Hvis den indholder tegn så skal de give fejl og skrive dette
            if (Regex.IsMatch(Skrivmål, @"[!@#$%^&*(),.?:{ }|<>]"))
            {
                Console.Clear();
                op.PrintLine(debug, "Skriv kun mål og uden special tegn");
                Målcheck(debug);
                Console.ReadKey();
            }
            //Hvis den er mindre end 3 eller større end 3 så aktivere denne
            else if (Skrivmål.Length < 3 || Skrivmål.Length > 3)
            {
                Console.Clear();
                op.PrintLine(debug, "Den må ikke være mindre end 3 eller større end 3");
                Målcheck(debug);
                Console.ReadKey();
            }
            //Hvis de er alle true så aktivere denne else if
            else if (Skrivmål.Contains(CheckM[0]) | Skrivmål.Contains(CheckM[1]) && Skrivmål.Contains(CheckÅ[0]) | Skrivmål.Contains(CheckÅ[1]) && Skrivmål.Contains(CheckL[0]) | Skrivmål.Contains(CheckL[1]) && Skrivmål.Length == 3)
            {
                Console.Clear();
                op.PrintLine(debug, "Olé, Olé, Olé");
                op.PrintLine(debug, "");
                op.PrintLine(debug, "Tryk på en tast for at gå tilbage til start");

                Pickmenu nyValg = new Pickmenu();
                Console.ReadKey();
                Console.Clear();
                nyValg.Vælg(debug);
            }
            //Hvis alt går galt så går den her til
            else
            {
                Console.Clear();
                op.PrintLine(debug, "Fejl prøv igen, tryk en knap for at starte om");
                Console.ReadKey();
                Målcheck(debug);
            }

        }
    }
}

