namespace Patterns
{
    public interface IPerson
    {
        IPerson Clone();
    }

    public class Man : IPerson
    {
        private string WifeName;

        public Man(string name)
        {
            WifeName = name;
        }

        public IPerson Clone()
        {
            return new Man(WifeName);
        }

        public override string ToString()
        {
            return $"Name of my wife is {WifeName}";
        }
    }

    public class Woman : IPerson
    {
        private string HusbandName;

        public Woman(string name)
        {
            HusbandName = name;
        }

        public IPerson Clone()
        {
            return new Woman(HusbandName);
        }

        public override string ToString()
        {
            return $"Name of my husband is {HusbandName}";
        }
    }
}
