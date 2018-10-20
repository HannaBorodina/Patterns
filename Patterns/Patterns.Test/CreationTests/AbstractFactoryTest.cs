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
            Assert.Contains(soulInfoVar, man.GetSoulInfo());
            Assert.Contains(bodyInfoVar, man.GetBodyInfo());
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
            Assert.Contains(soulInfoVar, woman.GetSoulInfo());
            Assert.Contains(bodyInfoVar, woman.GetBodyInfo());
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
            Assert.Contains(soulInfoVar, alien.GetSoulInfo());
            Assert.Contains(bodyInfoVar, alien.GetBodyInfo());
        }


    }

}
