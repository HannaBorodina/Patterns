using Xunit;

namespace Patterns.Test
{
    public class AbstractFactoryTest
    {
        [Theory(DisplayName = "CreateMan")]
        [InlineData("185", "90%", "cat", "hair")]
        public void CreateMan(string height, string fooLove, string soulInfoVar, string bodyInfoVar)
        {
            Creature man = new Creature(new ManFactory());
            Assert.NotNull(man);
            var expected = typeof(Creature);
            Assert.IsType(expected, man);
            Assert.True(man.abstractBody.Height == height);
            Assert.True(man.abstractSoul.FootballLove == fooLove);
            Assert.True(man.GetSoulInfo().Contains(soulInfoVar));
            Assert.True(man.GetBodyInfo().Contains(bodyInfoVar));
        }

        [Theory(DisplayName = "CreateWoman")]
        [InlineData("165", "10%", "cat", "hair")]
        public void CreateWoman(string height, string fooLove, string soulInfoVar, string bodyInfoVar)
        {
            Creature woman = new Creature(new WomanFactory());
            Assert.NotNull(woman);
            var expected = typeof(Creature);
            Assert.IsType(expected, woman);
            Assert.True(woman.abstractBody.Height == height);
            Assert.True(woman.abstractSoul.FootballLove == fooLove);
            Assert.True(woman.GetSoulInfo().Contains(soulInfoVar));
            Assert.True(woman.GetBodyInfo().Contains(bodyInfoVar));
        }

        [Theory(DisplayName = "CreateAlien")]
        [InlineData("135", "0%", "cat", "hair")]
        public void CreateAlien(string height, string fooLove, string soulInfoVar, string bodyInfoVar)
        {
            Creature alien = new Creature(new AlianFactory());
            Assert.NotNull(alien);
            var expected = typeof(Creature);
            Assert.IsType(expected, alien);
            Assert.True(alien.abstractBody.Height == height);
            Assert.True(alien.abstractSoul.FootballLove == fooLove);
            Assert.True(alien.GetSoulInfo().Contains(soulInfoVar));
            Assert.True(alien.GetBodyInfo().Contains(bodyInfoVar));
        }


    }

}
