using NUnit.Framework;
using RoleplayGame;

/*
namespace Test.Library
{
    public class KnightTests
    {
        private Knight aragorn;

        [SetUp]
        public void Setup()
        {
            this.aragorn = new Knight("Aragorn");
            Sword sword = new Sword();
            Shield shield = new Shield();
            Armor armor = new Armor();
            aragorn.AddItem(sword);
            aragorn.AddItem(shield);
            aragorn.AddItem(armor);
        }

        [Test]
        public void Health_Is_Modified_By_Attack()      //Prueba que el metodo ReceiveAttack modifica la vida
        {
            int initialLife = aragorn.Health;
            aragorn.ReceiveAttack(99);

            Assert.AreNotEqual(initialLife, aragorn.Health);
        }

        [Test]
        public void Health_Doesnt_Drop_Below_Zero()     //Prueba que la vida no puede bajar de cero
        {
            aragorn.ReceiveAttack(200);

            Assert.AreEqual(aragorn.Health, 0);
        }

        [Test]
        public void Attack_Doesnt_Heal()                //Prueba que el metodo ReceiveAttack no cura si el ataque es menor a la defensa 
        {
            int initialLife = aragorn.Health;
            aragorn.ReceiveAttack(1);

            Assert.AreEqual(initialLife, aragorn.Health);
        }

        [Test]
        public void Healyh_Is_Modified_By_Cure()        //Prueba que el metodo Cure modifica la vida
        {
            aragorn.ReceiveAttack(99);
            int actualLife = aragorn.Health;
            aragorn.Cure();

            Assert.AreNotEqual(actualLife, aragorn.Health);
        }

        [Test]
        public void Character_Doesnt_Revive()           //Prueba que el personaje no puede revivir 
        {
            aragorn.ReceiveAttack(200);
            int actualHealt = aragorn.Health;
            aragorn.Cure();

            Assert.AreEqual(actualHealt, aragorn.Health);
        }
    }
}
*/