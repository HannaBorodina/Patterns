using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Patterns.Test")]
namespace Patterns
{
    abstract class House
    {
        public decimal Cost { get; set; }

        public abstract decimal GetCost();
    }

    class SmallWoodenHouse : House
    {
        public override decimal GetCost()
        {
            return 10000;
        }
    }

    class BigCoolHouse : House
    {
        public override decimal GetCost()
        {
            return 100000000000;
        }
    }

    abstract class HouseDecorator : House
    {
        protected House house;
        public HouseDecorator(House house)
        {
            this.house = house;
        }
    }

    class SwimmingPool : HouseDecorator
    {
        public SwimmingPool(House house) : base(house) { }

        public override decimal GetCost()
        {
            return house.GetCost() + 2000;
        }
    }

    class Garden : HouseDecorator
    {
        public Garden(House house) : base(house) { }

        public override decimal GetCost()
        {
            return house.GetCost() + 3000;
        }
    }
}
