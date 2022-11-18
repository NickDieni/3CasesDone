using System;
using ClassLibrary_For_3Cases;

namespace _3Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            OutPut op = new OutPut();
            
            //Får brugeren til at vælge debug eller standard
            bool debug;
            Console.WriteLine("[D] Debug    [S] Standard");
            string tast = Convert.ToString(Console.ReadKey().KeyChar).ToLower();
            //Hvis der er blivet trykket D så bliver debug true
            if (tast == "d")
            {
                debug = true;
            }
            //Hvis nej så bliver debug til false
            else
            {
                debug = false;
            }
            //Efter det går den til Passaccess og køre programmet alt efter hvad man har valgt
            Passaccess nyPass = new Passaccess();
            nyPass.Kode(debug);

            //Pickmenu nyStart = new Pickmenu();
            //nyStart.Vælg(debug);
        }
    }
}
