using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Patterns.Test")]
namespace Patterns
{
    class Hanna
    {
        public Soul Soul { get; set; }
        public void Create(string name)
        {
            Soul = Soul.GetInstance(name);
        }
    }

    class Soul
    {
        private static Soul _instance;
        private static object _syncRoot = new object();
        public string HumanName { get; set; }

        private Soul(string name)
        {
            HumanName = name;
        }

        public static Soul GetInstance(string name)
        {
            if (_instance == null)
                lock (_syncRoot)
                {
                    if (_instance == null)
                        _instance = new Soul(name);
                }
            return _instance;
        }
    }
}
