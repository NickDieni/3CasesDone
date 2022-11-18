using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace ClassLibrary_For_3Cases
{
    public class Kodecheck
    {
        // Laver get til _Password og _Username
        public string _Password { get; }
        public string _Username { get; }
        //sætte også sti tile filoprettelse og hvad en skal hedde
        private string sti = @"c:\Datamappe";
        private string datafil = @"c:\Datamappe\LoginFil.txt";
        public Kodecheck(string password, string username)
        {
            _Password = password;
            _Username = username;
        }


        public void Kodechecker1(bool debug)
        {
            //Laver objecter til debug og til at køre adgangskode om igen
            OutPut op = new OutPut();
            Passaccess nyPass = new Passaccess();

            // Laver bools til password, hvis nogle af de her er opfylder kravende så er de sande
            bool holdertal = _Password.Any(char.IsDigit);
            bool holderlower = _Password.Any(char.IsLower);
            bool holderupper = _Password.Any(char.IsUpper);
            bool holdersymbol = Regex.IsMatch(_Password, @"[!@#$%^&*(),.?:{ }|<>]");
            bool holderlængde = _Password.Length >= 12;

            // Disse bool bliver sande hvis de opfylder kravende, men det skal de ikke så de bliver brugt med "!" foran
            bool starttal = char.IsDigit(_Password[0]);
            bool sluttal = char.IsDigit(_Password[_Password.Length - 1]);
            

            //Hvis kravende er bliver opfyldt så går den videre med at lave en fil
            if (holdertal && holderlower && holderupper && holdersymbol && holderlængde && !starttal && !sluttal)
            {
                Filopretter(debug);
            }
            //Hvis de ikke er opfyldt så fortæller den der er noget galt og går tilbage til 
            else if (!holdertal || !holderlower || !holderupper || !holdersymbol || !holderlængde || starttal || sluttal)
            {
                Console.Clear();
                op.PrintLine(debug, "Koden skal indholde, store og små bogstaver, symbolder og tal, den skal også være mindst 12 bogstaver lang");
                Console.ReadKey();
                nyPass.Kode(debug);
            }

        }

        //Her er der lavet en ny metode til filoprettelse
        public void Filopretter(bool debug)
        {

            //Nyt object som fører til Pickmenu og debug object
            Pickmenu nyMenu = new Pickmenu();
            OutPut op = new OutPut();

            //Denne if sker kun hvis det er en ny profil der bliver oprettet
            if (!File.Exists(datafil))
            {
                //Her går den til i den public string der blev lavet og laver en sti med navnet som er givet i toppen
                Directory.CreateDirectory(sti);  
                //Her laver jeg en fil i den directory jeg lavet tidligere og kalder den for navnet som er angivet i toppen og sætter _Password ind og _Username med et mellemrum i mellem
                File.WriteAllText(datafil, _Password + " " + _Username);
                Console.Clear();
                op.PrintLine(debug, "Din nye bruger er oprettet, tryk på en knap for at forsætte");
                Console.ReadKey();

                //Går til Pickmenu
                nyMenu.Vælg(debug);
            }
            else if (File.Exists(datafil))
            {
                //Slette den gammel datafil
                File.Delete(datafil);
                //Laver en ny
                Directory.CreateDirectory(sti);
                //Gør meget af det samme som WriteAllText, den skriver i en fil _Username og _Password
                File.AppendAllText(datafil, _Username + " " + _Password);
                Console.Clear();
                op.PrintLine(debug, "Godkendt, tryk på en knap for at forsætte");
                Console.ReadKey();

                //Går til Pickmenu
                nyMenu.Vælg(debug);
            }
        }

    }
}
