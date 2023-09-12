using NUnit.Framework;

namespace RobotFactory.Tests
{
    public class Tests
    {
        Factory factory;
        private string name = "Techno";
        private int capacity = 3;
        

        [SetUp]
        

        public void Setup()
        {
            factory = new Factory(name, capacity);
        }

        [Test]
        public void DoesConstructorWorkCorrectly()
        {
            Assert.AreEqual("Techno", factory.Name);
            Assert.AreEqual(3,factory.Capacity);
        }
        [Test]
        public void DoesProduceRobotWorkCorrectlyWithLessCount()
        {
            string result=factory.ProduceRobot("Robocop",30.40,3);
            Assert.AreEqual(1,factory.Robots.Count);
            Assert.AreEqual($"Produced --> Robot model: {"Robocop"} IS:" +
                $" {3}, Price: {30.40:F2}", result);

        }

        [Test]
        public void DoesProduceRobotWorkCorrectlyWithMoreCount()
        {
            Factory factory = new Factory("Pesho", 0);
            string result = factory.ProduceRobot("Kupper", 30, 1);
            Assert.AreEqual("The factory is unable to produce more robots " +
                "for this production day!", result);
        }

    }
}