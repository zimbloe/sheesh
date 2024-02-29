using NUnit.Framework;
using ConsoleApp1;
using System;

namespace TestProject1
{
    public class Tests
    {

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            //Arange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            //Act
            axe.Attack(dummy);

            //Assert
            Assert.AreEqual(9, axe.DurabilityPoints, "Axe Durability does not change after attack.");
        }

        [Test]
        public void BrokenAxeCantAttack()
        {
            //Arange
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(10, 10);

            //Act
            axe.Attack(dummy);
            axe.Attack(dummy);

            //Assert
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual(ex.Message, "Axe is broken.");
        }

        [Test]
        public void DummyLosesHealthIfAttacked()
        {

        }
    }
}