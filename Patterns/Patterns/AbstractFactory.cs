using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Patterns.Test")]
namespace Patterns
{
    abstract class AbstractFactory
    {
        public abstract AbstractBody CreateBody();
        public abstract AbstractSoul CreateSoul();
    }
    abstract class AbstractBody
    {
        public string Height { get; set; }
        public string Hair { get; set; }
        public string Beauty { get; set; }

        public AbstractBody(string height, string hair, string beauty)
        {
            Height = height;
            Hair = hair;
            Beauty = beauty;
        }
    }
    abstract class AbstractSoul
    {
        public string CatLove { get; set; }
        public string FootballLove { get; set; }
        public string TravelLove { get; set; }

        public AbstractSoul(string catLove, string footballLove, string travelLove)
        {
            CatLove = catLove;
            FootballLove = footballLove;
            TravelLove = travelLove;
        }
    }

    class ManFactory : AbstractFactory
    {
        public override AbstractSoul CreateSoul()
        {
            return new ManSoul("20%", "90%", "50%");
        }

        public override AbstractBody CreateBody()
        {
            return new ManBody("185", "black", "50%");
        }
    }

    class WomanFactory : AbstractFactory
    {
        public override AbstractSoul CreateSoul()
        {
            return new WomanSoul("90%", "10%", "50%");
        }

        public override AbstractBody CreateBody()
        {
            return new WomanBody("165", "white", "100%");
        }
    }

    class AlianFactory : AbstractFactory
    {
        public override AbstractSoul CreateSoul()
        {
            return new AlienSoul("100%", "0%", "100%");
        }

        public override AbstractBody CreateBody()
        {
            return new AlienBody("135", "no hair", "10%");
        }
    }

    class ManSoul : AbstractSoul
    {
        public ManSoul(string catLove, string footballLove,
            string travelLove) : base(catLove, footballLove, travelLove) { }
    }

    class WomanSoul : AbstractSoul
    {
        public WomanSoul(string catLove, string footballLove,
            string travelLove) : base(catLove, footballLove, travelLove) { }
    }

    class AlienSoul : AbstractSoul
    {
        public AlienSoul(string catLove, string footballLove,
    string travelLove) : base(catLove, footballLove, travelLove) { }
    }

    class ManBody : AbstractBody
    {
        public ManBody(string height, string hair,
    string beauty) : base(height, hair, beauty) { }
    }

    class WomanBody : AbstractBody
    {
        public WomanBody(string height, string hair,
    string beauty) : base(height, hair, beauty) { }
    }

    class AlienBody : AbstractBody
    {
        public AlienBody(string height, string hair,
    string beauty) : base(height, hair, beauty) { }
    }

    class Creature
    {
        internal AbstractSoul abstractSoul;
        internal AbstractBody abstractBody;

        public Creature(AbstractFactory factory)
        {
            abstractSoul = factory.CreateSoul();
            abstractBody = factory.CreateBody();
        }

        internal string GetSoulInfo()
        {
            return "cat love - " + abstractSoul.CatLove + " , " + 
                "footbal love - " + abstractSoul.FootballLove + " , " + 
                "travel love - " + abstractSoul.TravelLove;
        }

        internal string GetBodyInfo()
        {
            return "height - " + abstractBody.Height + " , "+
                "hair - " + abstractBody.Hair + " ,  " +
                "beauty - " + abstractBody.Beauty;
        }
    }
}
