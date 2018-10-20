using Xunit;

namespace Patterns.Test
{
    public class StrategyTest
    {
        [Fact(DisplayName = "Dentist, Psychologist, Ophtalmologist")]
        public void AskDentist()
        {
            var person = new Patient(new Dentist());
            Assert.NotNull(person);
            Assert.True(person.GetReceiptFromDoc() == "Toothpaste");

            person.ShouldVisit = new Ophtalmologist();
            Assert.True(person.GetReceiptFromDoc() == "Glasses");

            person.ShouldVisit = new Psychologist();
            Assert.True(person.GetReceiptFromDoc() == "Love");
        }
    }
}
