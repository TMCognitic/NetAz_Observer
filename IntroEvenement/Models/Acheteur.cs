using IntroEvenement.Patterns.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroEvenement.Models
{
    public class Acheteur : Observer
    {
        public string Nom { get; init; }

        public Acheteur(string nom)
        {
            Nom = nom;
        }

        public override void Update(Subject subject)
        {
            Article? article = subject as Article;

            if (article is null)
                return;

            Console.WriteLine($"{Nom} a été notifié du changement de prix de l'article '{article.Nom}' : {article.Prix}");
        }
    }
}
