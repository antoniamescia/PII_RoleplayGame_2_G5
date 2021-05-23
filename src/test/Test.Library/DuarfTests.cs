using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class DwarfTests
    {
        private Dwarf gimli;

        [SetUp]
        public void Setup()
        {
            this.gimli = new Dwarf("Gimli");
            Axe axe = new Axe();
            Helmet helmet = new Helmet();
            Shield shield = new Shield();
            gimli.AddItem(axe);
            gimli.AddItem(helmet);
            gimli.AddItem(shield);
        }

        [Test]
        public void Health_Is_Modified_By_Attack()      //Prueba que el metodo ReceiveAttack modifica la vida
        {
            int initialLife = gimli.Health;
            gimli.ReceiveAttack(99);

            Assert.AreNotEqual(initialLife, gimli.Health);
        }

        [Test]
        public void Health_Doesnt_Drop_Below_Zero()     //Prueba que la vida no puede bajar de cero
        {
            gimli.ReceiveAttack(200);

            Assert.AreEqual(gimli.Health, 0);
        }

        [Test]
        public void Attack_Doesnt_Heal()                //Prueba que el metodo ReceiveAttack no cura si el ataque es menor a la defensa 
        {
            int initialLife = gimli.Health;
            gimli.ReceiveAttack(10);

            Assert.AreEqual(initialLife, gimli.Health);
        }

        [Test]
        public void Healyh_Is_Modified_By_Cure()        //Prueba que el metodo Cure modifica la vida
        {
            gimli.ReceiveAttack(99);
            int actualLife = gimli.Health;
            gimli.Cure();

            Assert.AreNotEqual(actualLife, gimli.Health);
        }

        [Test]
        public void Character_Doesnt_Revive()           //Prueba que el personaje no puede revivir 
        {
            gimli.ReceiveAttack(200);
            int actualHealt = gimli.Health;
            gimli.Cure();

            Assert.AreEqual(actualHealt, gimli.Health);
        }
    }
}