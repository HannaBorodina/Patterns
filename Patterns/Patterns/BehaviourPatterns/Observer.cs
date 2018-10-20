using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehaviourPatterns
{


    public interface IObserver
    {
        void Update(Object ob);
    }

    public interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    public class Fashion : IObservable
    {
        int skirtLength;

        List<IObserver> observers;

        public Fashion()
        {
            observers = new List<IObserver>();
            skirtLength = 0;
        }

        public void NotifyObservers()
        {
            foreach (var o in observers)
            {
                o.Update(skirtLength);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void FashionShow()
        {
            Random rnd = new Random();
            skirtLength = rnd.Next(20, 100);
            NotifyObservers();
        }
    }

    public class FashionWoman : IObserver
    {
        IObservable fashion;

        public FashionWoman(IObservable fashion)
        {
            this.fashion = fashion;
            fashion.RegisterObserver(this);
        }

        public void Update(object ob)
        {
            var length = (int)ob;
            Console.WriteLine($"Fashion changed, I need skirt with {length} length");
        }
    }
}
