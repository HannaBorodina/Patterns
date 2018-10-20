using Xunit;

namespace Patterns.Test
{
    public class BuilderTest
    {
        [Fact]
        public void CreteHumanTest()
        {
            var creator = new Creator();
            var man = creator.CreateHuman(new ManBuilder());

            Assert.Equal($"Human with 10% beauty and 90% intellect", man.ToString());

            var woman = creator.CreateHuman(new WomanBuilder());

            Assert.Equal($"Human with 90% beauty and 10% intellect", woman.ToString());
        }
    }
}
