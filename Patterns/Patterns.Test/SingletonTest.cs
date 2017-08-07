using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Patterns.Test
{
    public class SingletonTest
    {
        [Theory(DisplayName = "Create singleton")]
        [InlineData("Hanna")]
        public void CreateSingleton(string name)
        {
            Hanna hanna = new Hanna();
            hanna.Create("Hanna");
            Assert.True(hanna.Soul.HumanName == name);

            hanna.Create("Hanna2");
            Assert.True(hanna.Soul.HumanName == name);

            hanna.Soul = Soul.GetInstance("Hanna3");
            Assert.True(hanna.Soul.HumanName == name);

            Hanna hanna22 = new Hanna();
            hanna22.Create("Hanna22");
            Assert.True(hanna22.Soul.HumanName == name);

        }

        [Theory(DisplayName = "Test without Thread")]
        [InlineData("Hanna", "Hanna2")]
        public void WithoutThreadTest(string name, string testName)
        {
            Hanna hanna2 = new Hanna();
            hanna2.Create(testName);
            Assert.True(hanna2.Soul.HumanName == testName);
            Assert.False(hanna2.Soul.HumanName == name);
        }

        [Theory(DisplayName = "Test with Thread")]
        [InlineData("Hanna", "Hanna2")]
        public void ThreadTest(string name, string testName)
        {
            (new Thread(() =>
            {
                Hanna hanna = new Hanna();
                hanna.Soul = Soul.GetInstance(name);
            })).Start();

            Hanna hanna2 = new Hanna();
            hanna2.Create(testName);
            Assert.False(hanna2.Soul.HumanName == testName);
            Assert.True(hanna2.Soul.HumanName == name);
        }
    }
}
