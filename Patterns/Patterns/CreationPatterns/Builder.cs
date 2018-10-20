using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Human
    {
        public int BeautyPercent;
        public int CleverPercent;

        public override string ToString()
        {
            return $"Human with {BeautyPercent}% beauty and {CleverPercent}% intellect";
        }
    }

    public abstract class HumanBuilder
    {
        public Human human { get; private set; }

        public void CreateHuman()
        {
            human = new Human();
        }

        public abstract void SetCleverPercent();
        public abstract void SetBeautyPercent();
    }

    class Creator
    {
        public Human CreateHuman(HumanBuilder builder)
        {
            builder.CreateHuman();
            builder.SetBeautyPercent();
            builder.SetCleverPercent();
            return builder.human;
        }
    }

    public class WomanBuilder : HumanBuilder
    {
        public override void SetBeautyPercent()
        {
            human.BeautyPercent = 90;
        }

        public override void SetCleverPercent()
        {
            human.CleverPercent = 10;
        }
    }

    public class ManBuilder : HumanBuilder
    {
        public override void SetBeautyPercent()
        {
            human.BeautyPercent = 10;
        }

        public override void SetCleverPercent()
        {
            human.CleverPercent = 90;
        }
    }
}
