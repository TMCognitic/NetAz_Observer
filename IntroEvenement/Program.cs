using IntroEvenement.Models;

namespace IntroEvenement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acheteur tony = new Acheteur("Tony");
            Acheteur gaelle = new Acheteur("Gaelle");

            Article monster = new Article("Monster vert 50cl");

            monster.Add(tony);
            monster.Add(gaelle);

            monster.Prix = 2.20;

            monster.Remove(gaelle);

            monster.Prix = 2.5;
        }
    }
}