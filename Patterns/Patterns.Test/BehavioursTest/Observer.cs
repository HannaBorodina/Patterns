using Patterns.BehaviourPatterns;
using Xunit;

namespace Patterns.Test.BehavioursTest
{
    public class Observer
    {
        [Fact]
        public void ObserverTest()
        {
            var fashion = new Fashion();
            var woman = new FashionWoman(fashion);
            fashion.FashionShow();
        }
    }
}
