using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class WizardTests
    {
        private Wizard gandalf;

        [SetUp]
        public void Setup()
        {
            this.gandalf = new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = new SpellsBook();
            gandalf.SpellsBook.Spells = new Spell[] { new Spell() };

        }

        [Test]
        public void Health_Is_Modified_By_Attack()      //Prueba que el metodo ReceiveAttack modifica la vida
        {
            int initialLife = gandalf.Health;
            gandalf.ReceiveAttack(180);

            Assert.AreNotEqual(initialLife, gandalf.Health);
        }

        [Test]
        public void Health_Doesnt_Drop_Below_Zero()     //Prueba que la vida no puede bajar de cero
        {
            gandalf.ReceiveAttack(300);

            Assert.AreEqual(gandalf.Health, 0);
        }

        [Test]
        public void Attack_Doesnt_Heal()                //Prueba que el metodo ReceiveAttack no cura si el ataque es menor a la defensa 
        {
            int initialLife = gandalf.Health;
            gandalf.ReceiveAttack(1);

            Assert.AreEqual(initialLife, gandalf.Health);
        }

        [Test]
        public void Healyh_Is_Modified_By_Cure()        //Prueba que el metodo Cure modifica la vida
        {
            gandalf.ReceiveAttack(200);
            int actualLife = gandalf.Health;
            gandalf.Cure();

            Assert.AreNotEqual(actualLife, gandalf.Health);
        }

        [Test]
        public void Character_Doesnt_Revive()           //Prueba que el personaje no puede revivir 
        {
            gandalf.ReceiveAttack(200000000);
            int actualHealt = gandalf.Health;
            gandalf.Cure();

            Assert.AreEqual(actualHealt, gandalf.Health);
        }
    }
}