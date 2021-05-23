using System;
using System.Collections.Generic;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[] { new Spell() };

            Wizard gandalf = new Wizard("Gandalf");
            Staff staff = new Staff();
            SpellsBook spellsBook = book;
            gandalf.AddItem(spellsBook);
            gandalf.AddItem(staff);

            Dwarf gimli = new Dwarf("Gimli");
            Axe axe = new Axe();
            Helmet helmet = new Helmet();
            Shield shield = new Shield();
            gimli.AddItem(axe);
            gimli.AddItem(helmet);
            gimli.AddItem(shield);

            Archer legolas = new Archer ("Legolas");
            Bow bow = new Bow();
            Shield legolasShield = new Shield();
            Helmet legolasHelmet = new Helmet();
            legolas.AddItem(bow);
            legolas.AddItem(legolasShield);
            legolas.AddItem(legolasHelmet);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            legolas.RemoveItem(legolasHelmet);

            gandalf.ReceiveAttack(legolas);
            Console.WriteLine($"Legolas attacks Gandalf with ⚔️ {legolas.AttackValue}");

            Console.WriteLine($"Gandalf has ❤️ {gandalf.Health}");

            legolas.ReceiveAttack(gimli);
            Console.WriteLine($"Gimli attacks Legolas with ⚔️ {gimli.AttackValue}");
            Console.WriteLine($"Legolas has ❤️ {legolas.Health}");


        }
    }
}
