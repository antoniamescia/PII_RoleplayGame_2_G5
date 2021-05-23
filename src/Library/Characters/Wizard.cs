using System.Collections.Generic;

namespace RoleplayGame
{
    public class Wizard : IMagicalCharacter
    {
        private int health = 100;

        public Wizard(string name)
        {
            this.Name = name;
            this.Items = new List<IItem>();
        }

        public string Name { get; set; }

        public List<IItem> Items
        {
            get;
            private set;
        }

        public int AttackValue
        {
            get
            {
                int attackValue = 0;
                foreach (IItem item in this.Items)
                {
                    if (typeof(IAttackItem).IsInstanceOfType(item))
                    {
                        attackValue += ((IAttackItem)item).AttackValue;
                    }
                    else if (typeof(IMagicAttackItem).IsInstanceOfType(item))
                    {
                        attackValue += ((IMagicAttackItem)item).AttackValue;
                    }
                }
                return attackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                int defenseValue = 0;
                foreach (IItem item in this.Items)
                {
                    if (typeof(IDefenseItem).IsInstanceOfType(item))
                    {
                        defenseValue += ((IDefenseItem)item).DefenseValue;
                    }
                    else if (typeof(IMagicDefenseItem).IsInstanceOfType(item))
                    {
                        defenseValue += ((IMagicDefenseItem)item).DefenseValue;
                    }
                }
                return defenseValue;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            if (this.health > 0)    // impide que un personaje se cure despues de muerto
            {
                this.Health = 100;
            }
        }

        public void AddItem(IItem item)
        {
            this.Items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.Items.Remove(item);
        }
    }
}