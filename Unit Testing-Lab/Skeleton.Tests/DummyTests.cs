using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {

        private Dummy dummy;
        private int experince=0;
        [SetUp]
        public void Setup()
        {

            int health = 10;
            int experince = 7;
            this.experince = experince;
            this.dummy = new Dummy(health, experince);


        }
        [Test]
        public void Is_Healt_Set_Correctly_In_Constructor()
        { 

            Assert.That(10,Is.EqualTo(dummy.Health));
        }
        [Test]
        public void Is_Dead_Dummy_If_Hes_Healt_Is_Zero()
        {
            Dummy dummy = new Dummy(0, 9);
            bool isDead = dummy.IsDead();
            Assert.AreEqual(true, isDead);

        }
        [Test]
        public void Is_Dead_Dummy_If_Hes_Healt_Is_Below_Zero()
        {
            Dummy dummy = new Dummy(-1, 9);
            bool isDead = dummy.IsDead();
            Assert.AreEqual(true, isDead);

        }
        [Test]
        public void Is_Alive_Dummy_If_Hes_Healt_Is_Below_Or_Zero()
        {
            bool isDead = dummy.IsDead();
            Assert.AreEqual(false, isDead);

        }
        [Test]
        public void Does_Dummy_Zero_Heath_Throw_Invalid_Exception_When_His_Take_Attack()
        {
            Dummy dummy=new Dummy(0,9);
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.TakeAttack(5);
            });
        }
        [Test]
        public void Does_Dummy_Is_Below_Zero_Heath_Throw_Invalid_Exception_When_His_Take_Attack()
        {
            Dummy dummy = new Dummy(-2, 9);
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.TakeAttack(5);
            });
        }
        [Test]
        public void Does_Dummy_Take_Attackt_When_Is_Not_Dead()
        {
            dummy.TakeAttack(5);
            Assert.AreEqual(5, dummy.Health);
        }
        [Test]
        public void Does_Dummy_Throw_Invalid_Exception_When_He_Is_Not_Dead()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.GiveExperience();
            });
        }
        [Test]
        public void Does_Dummy_Return_Experince_When_He_Is_Dead_And_Hes_Helath_IsZero()
        {
            Dummy dummy = new Dummy(0, experince);
            dummy.GiveExperience();
            Assert.AreEqual(7, experince);
        }
        [Test]
        public void Does_Dummy_Return_Experince_When_He_Is_Dead_And_Hes_Helath_Is_Below_Zero()
        {
            Dummy dummy = new Dummy(-4, experince);
            dummy.GiveExperience();
            Assert.AreEqual(7, experince);
        }

    }
}