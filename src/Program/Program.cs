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

            Dwarf gimli = new Dwarf("Gimli");
            Axe axe = new Axe();
            Helmet helmet = new Helmet();
            Shield shield = new Shield();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            // List<ICharacter> characters = new List<ICharacter>{gandalf, gimli};
            // foreach(ICharacter character in characters)
            // {
            //     Console.WriteLine($"{character.Name}");
            // }

            // List<IAttackItem> attackItems = new List<IAttackItem>{gandalf.Staff, gandalf.SpellsBook, gimli.Axe};
            // foreach(IAttackItem attackItem in attackItems)
            // {
            //     Console.WriteLine($"{attackItem.AttackValue}");
            // }

            

        }
    }
}
