namespace ClassLibrary_For_3Cases
{
    public class Navn //Metoden gemmer navnet på danserene
    {
        private string Gemnavn;
        public void SetDanserNavn(string navn)
        {
            this.Gemnavn = navn;
        }
        public string GetDanserNavn()
        {
            return Gemnavn;
        }
    }
    public class Score //Metoden gemmer scoren på danserene
    {
        private int Gemscore;
        public void SetDanserScore(int score)
        {
            this.Gemscore = score;
        }
        public int GetDanserScore()
        {
            return Gemscore;
        }
    }
}
