using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroEvenement.Patterns.ObserverPattern
{
    public abstract class Subject
    {
        private List<Observer> _observers;

        protected Subject()
        {
            _observers = new List<Observer>();
        }

        //Méthode Attach du Schéma UML
        public void Add(Observer observer) 
        {
            _observers.Add(observer);
        }

        //Méthode Detach du Schéma UML
        public void Remove(Observer observer)
        {
            _observers.Remove(observer);
        }

        protected void Notify()
        {
            foreach (Observer observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
