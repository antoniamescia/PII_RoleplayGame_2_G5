using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class ArcherTests
    {
        private Archer legolas;

        [SetUp]
        public void Setup()
        {
            this.legolas = new Archer("Legolas");
            Bow bow = new Bow();
            Helmet helmet = new Helmet();
            legolas.AddItem(bow);
            legolas.AddItem(helmet);
        }

        [Test]
        public void Health_Is_Modified_By_Attack()      //Prueba que el metodo ReceiveAttack modifica la vida
        {
            int initialLife = legolas.Health;
            legolas.ReceiveAttack(19);

            Assert.AreNotEqual(initialLife, legolas.Health);
        }

        [Test]
        public void Health_Doesnt_Drop_Below_Zero()     //Prueba que la vida no puede bajar de cero
        {
            legolas.ReceiveAttack(200);

            Assert.AreEqual(legolas.Health, 0);
        }

        [Test]
        public void Attack_Doesnt_Heal()                //Prueba que el metodo ReceiveAttack no cura si el ataque es menor a la defensa 
        {
            int initialLife = legolas.Health;
            legolas.ReceiveAttack(10);

            Assert.AreEqual(initialLife, legolas.Health);
        }

        [Test]
        public void Healyh_Is_Modified_By_Cure()        //Prueba que el metodo Cure modifica la vida
        {
            legolas.ReceiveAttack(19);
            int actualLife = legolas.Health;
            legolas.Cure();

            Assert.AreNotEqual(actualLife, legolas.Health);
        }

        [Test]
        public void Character_Doesnt_Revive()           //Prueba que el personaje no puede revivir 
        {
            legolas.ReceiveAttack(200);
            int actualHealt = legolas.Health;
            legolas.Cure();

            Assert.AreEqual(actualHealt, legolas.Health);
        }
    }
}