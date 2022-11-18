using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary_For_3Cases
{
    public class Passaccess
    {
        private string datafil = @"c:\Datamappe\LoginFil.txt";
        public string Password, Username;

        public void Kode(bool debug)
        {
            OutPut op = new OutPut();
            Pickmenu nyPick = new Pickmenu();

            Console.Clear();

            //får brugeren til at intaste en om de har en profil eller ikke
            op.PrintLine(debug, "Velkommen");
            op.PrintLine(debug, "");
            op.PrintLine(debug, "Har du en bruger ja/nej: ");
            string resultat = Console.ReadLine();
            string surt = resultat.ToLower();
            if (surt == "ja") //Exsiterene bruger
            {
                //Brugeren skal skrive navn og kodeord
                Console.Clear();
                op.PrintLine(debug, "Velkommen til login");
                op.PrintLine(debug, "");
                op.PrintLine(debug, "Brugernavn:");
                Username = Console.ReadLine();
                op.PrintLine(debug, "");
                op.PrintLine(debug, "Kodeord:");
                Password = Console.ReadLine();

                //Hvis den indholder de rigtige ting så kommer man videre
                if (File.ReadAllLines(datafil).Contains(Username) && File.ReadAllLines(datafil).Contains(Password))
                {
                    Console.Clear();
                    op.PrintLine(debug, "Adgang godkendt, velkommen " + Username + "Tryk på en knap for at forsætte");
                    Console.ReadKey();
                    nyPick.Vælg(debug);
                }
                //Hvis ikke så siger den enten af koden eller brugernavn er forkert
                else if (!File.ReadAllLines(datafil).Contains(Username) || !File.ReadAllLines(datafil).Contains(Username))
                {
                    Console.Clear();
                    op.PrintLine(debug, "Din adgangs kode eller brugername er forkert prøv igen");
                }
            //Hvis nej så får den brugeren til at lave en ny profil    
            }
            else if (surt == "nej") //Ny bruger
            {
                Kode nyKode = new Kode();
                User nyUser = new User();

                Console.Clear();
                op.PrintLine(debug, "Opret en ny bruger");
                op.PrintLine(debug, "");
                op.PrintLine(debug, "Bruger navn:");
                string input = Console.ReadLine();
                Username = input.ToLower();
                op.PrintLine(debug, "");
                op.PrintLine(debug, "Kodeord: ");
                Password = Console.ReadLine();
                //Når det er gjordt går den over til at Kodechecker1 og ser om koden passer til kravende
                Kodecheck nyKodecheck = new Kodecheck(Password, Username); //Et object er oprettet med variabler
                nyKodecheck.Kodechecker1(debug);
            }
            //hvis der ikke bliver skrevet ja eller nej så gå her ned og siger at man skal prøve igen
            else
            {
                Console.Clear();
                op.PrintLine(debug, "Fejl! Du kan kun taste ja eller nej, tryk en tast for at prøve igen");
                Console.ReadKey();
                Kode(debug);
            }
        }

    }
}
