using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.BehaviourPatterns
{
    public abstract class Day
    {
        public void SpendDay()
        {
            WakeUp();
            DecideWhatToDo();
            DoSmth();
            GoToBed();
        }

        public abstract void WakeUp();
        public abstract void DecideWhatToDo();
        public abstract void DoSmth();
        public abstract void GoToBed();
    }

    public class ChilDay : Day
    {
        public override void DecideWhatToDo()
        {
            Console.WriteLine("I will play with toys");
        }

        public override void DoSmth()
        {
            Console.WriteLine("I am playing with toys");
        }

        public override void GoToBed()
        {
            Console.WriteLine("Good night, mum");
        }

        public override void WakeUp()
        {
            Console.WriteLine("Good morning, mom");
        }
    }
}
