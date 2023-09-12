using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Axe axe;

        [SetUp]
        public void SetUp()
        {
            int attacktPoints = 15;
            int durabilityPoints = 8;
            axe = new Axe(attacktPoints, durabilityPoints);

        }
        [Test]
        public void Does_Constructor_Set_AttacktPoints()
        {
         
            Assert.AreEqual(axe.AttackPoints, 15);
        }
        [Test]
        public void Does_Constructor_Set_DurabilityPoints()
        {
            Assert.AreEqual(axe.DurabilityPoints, 8);
        }

        [Test]
        public void Does_Attackt_Command_Throw_Invalid_Exception_If_Is_Zero_Durabilyti_Points()
        {
            axe = new Axe(14, 0);
            Dummy dummy = new Dummy(5, 7);
            
            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            });
        }
        [Test]
        public void Does_Attackt_Command_Throw_Invalid_Exception_If_Is_Below_Zero_Durabilyti_Points()
        {
            axe = new Axe(2, -6);
            Dummy dummy = new Dummy(5, 7);

            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            });
        }
        [Test]
        public void Does_Axe_Loses_DirabiltyPoint_When_Attackts()
        {
            
            Dummy dummy = new Dummy(5, 7);

            axe.Attack(dummy);

            Assert.AreEqual(7, axe.DurabilityPoints);
          
        }
    }
}