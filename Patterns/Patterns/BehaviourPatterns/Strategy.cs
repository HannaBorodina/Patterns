using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Patterns.Test")]
namespace Patterns
{
    abstract class Doс
    {
        public abstract string GetReceipt();
    }

    class Ophtalmologist : Doс
    {
        public override string GetReceipt()
        {
            return "Glasses";
        }
    }

    class Dentist : Doс
    {
        public override string GetReceipt()
        {
            return "Toothpaste";
        }
    }

    class Psychologist : Doс
    {
        public override string GetReceipt()
        {
            return "Love";
        }
    }
     class Patient
    {
        public Doс ShouldVisit { get; set; } 

        public Patient(Doс doc)
        {
            ShouldVisit = doc;
        }
        public string GetReceiptFromDoc()
        {
            return ShouldVisit.GetReceipt();
        }
    }
}
