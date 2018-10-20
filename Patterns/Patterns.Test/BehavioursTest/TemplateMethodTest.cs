using Patterns.BehaviourPatterns;
using Xunit;

namespace Patterns.Test.BehavioursTest
{
    public class TemplateMethodTest
    {
        [Fact]
        public void TemplateTest()
        {
            var day = new ChilDay();
            day.SpendDay();
        }
    }
}
