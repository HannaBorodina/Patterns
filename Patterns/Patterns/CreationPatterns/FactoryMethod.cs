using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Patterns.Test")]
namespace Patterns
{
        internal abstract class Wisdom
        {
            internal string Phrase { get; set; }
            public Wisdom(string phrase)
            {
                Phrase = phrase;
            }
        }

        internal abstract class God
        {
            private string Name { get; set; }

            public God(string name)
            {
                Name = Name;
            }

            public abstract Wisdom CreateWisdom();
        }

        internal class Christ : God
        {
            public Christ(string name) : base(name)
            {

            }

            public override Wisdom CreateWisdom()
            {
                return new ChristWisdom("Do not use God's name unnecessarily.");
            }
        }

        class ChristWisdom : Wisdom
        {
            public ChristWisdom(string phrase) : base (phrase)
            {
            }
        }

        class Buddha : God
        {
            public Buddha(string name) : base(name)
            {

            }

            public override Wisdom CreateWisdom()
            {
                return new BuddhaWisdom("The trouble is, you think you have time.");
            }
        }

        class BuddhaWisdom : Wisdom
        {
            public BuddhaWisdom(string phrase) : base(phrase)
            {
            }
        }
    }

