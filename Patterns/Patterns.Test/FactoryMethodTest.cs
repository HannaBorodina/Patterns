using Xunit;

namespace Patterns.Test
{
    public class FactoryMethodTest
    {
        [Theory(DisplayName = "Create Christ's wisdom")]
        [InlineData]
        public void CreateChristWisdom()
        {
            var god = new Christ("Jesus");
            var expected = typeof(Christ);
            Assert.IsType(expected, god);
            var wisdom = god.CreateWisdom();
            Assert.True(wisdom.Phrase.Contains("unnecessarily"));
        }

        [Theory(DisplayName = "Create Buddha's wisdom")]
        [InlineData]
        public void CreateBuddhaWisdom()
        {
            var god = new Buddha("Gautama");
            var expected = typeof(Buddha);
            Assert.IsType(expected, god);
            var wisdom = god.CreateWisdom();
            Assert.True(wisdom.Phrase.Contains("time"));
        }
    }
}
