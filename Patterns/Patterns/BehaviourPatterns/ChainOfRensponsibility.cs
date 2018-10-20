using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Patterns.Test")]
namespace Patterns
{
    abstract class Worker
    {
        public Worker Successor { get; set; }
        public abstract void Handle(Person person);
    }
    class Person
    {
        public decimal MoneyInBank { get; set; }
        public string Alias { get; set; }

        public Person(decimal money)
        {
            MoneyInBank = money;
        }
    }

    class PoorWorker : Worker
    {
        public override void Handle(Person person)
        {
            if (person.MoneyInBank < 1000000)
            {
                person.Alias = "Poor";
            }
            else if (Successor != null)
            {
                Successor.Handle(person);
            }
        }
    }

    class WealthyWorker : Worker
    {
        public override void Handle(Person person)
        {
            if (person.MoneyInBank >= 1000000 && person.MoneyInBank < 1000000000)
            {
                person.Alias = "Millionaire";
            }
            else if (Successor != null)
            {
                Successor.Handle(person);
            }
        }
    }

    class RichWorker : Worker
    {
        public override void Handle(Person person)
        {
            if (person.MoneyInBank >= 1000000000)
            {
                person.Alias = "Billionaire";
            }
            else if (Successor != null)
            {
                Successor.Handle(person);
            }
        }
    }
}
