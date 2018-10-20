using Xunit;

namespace Patterns.Test
{
    public class ProtitypeTest
    {
        [Fact]
        public void TestManPrototype()
        {
            var man = new Man("Hanna");
            var cloneMan = man.Clone();
            Assert.Equal(man.ToString(), cloneMan.ToString());
        }

        [Fact]
        public void TestWoManPrototype()
        {
            var womman = new Woman("Yevhenii");
            var cloneWoman = womman.Clone();
            Assert.Equal(womman.ToString(), cloneWoman.ToString());
        }
    }
}
