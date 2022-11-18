using System;

namespace ClassLibrary_For_3Cases
{
    public class Danserresultat
    {
        public void DanserInd(bool debug)
        {
            //Der laves objecter for navne og scored
            Navn danser1 = new Navn();
            Score score1 = new Score();
            Navn danser2 = new Navn();
            Score score2 = new Score();
            OutPut op = new OutPut();


            //Navn og score til den første danser bliver angivet
            op.PrintLine(debug, "Indtast den første dansers navn:");
            danser1.SetDanserNavn(Console.ReadLine());
            op.PrintLine(debug, "Indtast den første dansers score:");
            score1.SetDanserScore(Convert.ToInt32(Console.ReadLine()));

            op.PrintLine(debug, "");

            //Navn og score til den anden danser bliver angivet
            op.PrintLine(debug, "Indtast den anden dansers navn  :");
            danser2.SetDanserNavn(Console.ReadLine());
            op.PrintLine(debug, "Indtast den anden dansers score:");
            score2.SetDanserScore(Convert.ToInt32(Console.ReadLine()));

            Console.ReadKey();
            Console.Clear();

            //Her viser den hvem der har scoret mest, med brug af operator overload
            op.PrintLine(debug, "Den med største score bliver vist øverst");
            op.PrintLine(debug, "");
            if (score1.GetDanserScore() > score2.GetDanserScore())
            {
                op.PrintLine(debug, $"{danser1.GetDanserNavn()} har scoret {score1.GetDanserScore()}");
                op.PrintLine(debug, $"{danser2.GetDanserNavn()} har scoret {score2.GetDanserScore()}");


            }
            else if (score2.GetDanserScore() >= score1.GetDanserScore())
            {
                op.PrintLine(debug, danser2.GetDanserNavn() + " har scoret " + score2.GetDanserScore());
                op.PrintLine(debug, danser1.GetDanserNavn() + " har scoret " + score1.GetDanserScore());
            }
            //Her viser vi hvad deres score er størst
            op.PrintLine(debug, "");
            op.PrintLine(debug, "Til sammen har de scoret " + (score1.GetDanserScore() + score2.GetDanserScore()) + " til sammen");
            
            op.PrintLine(debug, "");
            op.PrintLine(debug, "Tryk på en tast for at gå tilbage til start");

            //Her kan man gå tilbage til starten
            Pickmenu nyValg = new Pickmenu();
            Console.ReadKey();
            Console.Clear();
            nyValg.Vælg(debug);
        }
    }
}
