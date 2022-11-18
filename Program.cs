using System;
using ClassLibrary_For_3Cases;

namespace _3Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            OutPut op = new OutPut();

            bool debug;
            Console.WriteLine("[D] Debug    [S] Standard");
            string tast = Convert.ToString(Console.ReadKey().KeyChar).ToLower();

            if (tast == "d")
            {
                debug = true;
            }
            else
            {
                debug = false;
            }
            Passaccess nyPass = new Passaccess();
            nyPass.Kode(debug);

            //Pickmenu nyStart = new Pickmenu();
            //nyStart.Vælg(debug);
        }
    }
}
