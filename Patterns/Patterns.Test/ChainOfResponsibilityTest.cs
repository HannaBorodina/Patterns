using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Patterns.Test
{
    public class ChainOfResponsibilityTest
    {
        [Theory(DisplayName = "Poor")]
        [InlineData(1000)]
        public void GetAlias(decimal money)
        {
            var person = new Person(money);
            var poor = new PoorWorker();
            var wealthy = new WealthyWorker();
            var rich = new RichWorker();

            poor.Successor = wealthy;
            wealthy.Successor = rich;

            poor.Handle(person);

            Assert.NotEmpty(person.Alias);
            Assert.True(person.Alias == "Poor");
        }

        [Theory(DisplayName = "Millionaire")]
        [InlineData(5000000)]
        public void GetMillionaireAlias(decimal money)
        {
            var person = new Person(money);
            var poor = new PoorWorker();
            var wealthy = new WealthyWorker();
            var rich = new RichWorker();

            poor.Successor = wealthy;
            wealthy.Successor = rich;

            poor.Handle(person);

            Assert.NotEmpty(person.Alias);
            Assert.True(person.Alias == "Millionaire");
        }

        [Theory(DisplayName = "Billionaire")]
        [InlineData(1000000000000000)]
        public void GetBillionaireAlias(decimal money)
        {
            var person = new Person(money);
            var poor = new PoorWorker();
            var wealthy = new WealthyWorker();
            var rich = new RichWorker();

            poor.Successor = wealthy;
            wealthy.Successor = rich;

            poor.Handle(person);

            Assert.NotEmpty(person.Alias);
            Assert.True(person.Alias == "Billionaire");
        }
    }


}
