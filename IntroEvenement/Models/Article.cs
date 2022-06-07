using IntroEvenement.Patterns.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroEvenement.Models
{
    public class Article : Subject
    {
        private double _prix;
        public string Nom { get; init; }

        public double Prix
        {
            get
            {
                return _prix;
            }

            set
            {
                if (_prix != value)
                {
                    _prix = value;
                    Notify();
                }
            }
        }

        public Article(string nom)
        {
            Nom = nom;
        }
    }
}
