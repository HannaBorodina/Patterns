using Xunit;

namespace Patterns.Test
{
    public class DecoratorTest
    {
        [Theory(DisplayName ="Test Decorator methods with small house")]
        [InlineData]
        public void TryDecoratorWithSmallHouse()
        {
            House house = new SmallWoodenHouse();
            var smallHouseCost = house.GetCost();

            house = new SwimmingPool(house);
            var smallHouseCostWithSwimmingPool = house.GetCost();
            Assert.True(smallHouseCost < smallHouseCostWithSwimmingPool);

        }

        [Theory(DisplayName = "Test Decorator methods with big house")]
        [InlineData]
        public void TryDecoratorWithBigHouse()
        {
            House house = new BigCoolHouse();
            var bigHouseCost = house.GetCost();

            house = new Garden(house);
            var bigHouseCostWithGarden = house.GetCost();
            Assert.True(bigHouseCost < bigHouseCostWithGarden);

        }
    }
}
