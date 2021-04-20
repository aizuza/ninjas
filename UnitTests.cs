using System;
using NUnit.Framework;

namespace Ninjas
{
    [TestFixture]
    class UnitTests
    {
        [Test, Description("Player can defeat an enemy")]
        public void TestPlayerDefeatEnemy()
        {
            Player player = new Player();
            Enemy enemy = new Enemy();

            // Unity style
            // Health health = enemy.GetComponent<Health>();
            // Console.WriteLine($"health => {health}");

            // Attack nothing
            bool success = player.Attack(null);
            Assert.That(success, Is.EqualTo(false));

            Assert.That(enemy.health.health, Is.EqualTo(40));
            Assert.That(enemy.health.IsAlive(), Is.EqualTo(true));
            success = player.Attack(enemy.health);
            Assert.That(success, Is.EqualTo(true));
            Assert.That(enemy.health.health, Is.EqualTo(10));
            Assert.That(enemy.health.IsAlive(), Is.EqualTo(true));
            
            success = player.Attack(enemy.health);
            Assert.That(success, Is.EqualTo(true));
            Assert.That(enemy.health.health, Is.EqualTo(0));
            Assert.That(enemy.health.IsAlive(), Is.EqualTo(false));

            success = player.Attack(enemy.health);
            Assert.That(success, Is.EqualTo(false));
        }

        [Test, Description("Player can defeat a balloon")]
        public void TestPlayerDefeatBalloon()
        {
            Player player = new Player();
            Balloon balloon = new Balloon();

            Assert.That(balloon.health.health, Is.EqualTo(1));
            Assert.That(balloon.health.IsAlive(), Is.EqualTo(true));

            bool success = player.Attack(balloon.health);
            Assert.That(success, Is.EqualTo(true));
            Assert.That(balloon.health.health, Is.EqualTo(0));
            Assert.That(balloon.health.IsAlive(), Is.EqualTo(false));
        }

        [Test, Description("Player can defeat a barrel")]
        public void TestPlayerDefeatBarrel()
        {
            Player player = new Player();
            Barrel barrel = new Barrel();

            Assert.That(barrel.health.health, Is.EqualTo(200));
            Assert.That(barrel.health.IsAlive(), Is.EqualTo(true));

            bool success = player.Attack(barrel.health);
            Assert.That(success, Is.EqualTo(true));
            Assert.That(barrel.health.health, Is.EqualTo(170));
            Assert.That(barrel.health.IsAlive(), Is.EqualTo(true));

            player.Attack(barrel.health);
            player.Attack(barrel.health);
            player.Attack(barrel.health);
            
            player.Attack(barrel.health);
            player.Attack(barrel.health);
            player.Attack(barrel.health);

            Assert.That(barrel.health.health, Is.EqualTo(0));
            Assert.That(barrel.health.IsAlive(), Is.EqualTo(false));
        }
    }
}