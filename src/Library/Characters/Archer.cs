using System.Collections.Generic;

namespace RoleplayGame
{
    public class Archer : IPhysicalCharacter
    {
        private List<IPhysicalItem> items;
        private int health = 100;

        public Archer(string name)
        {
            this.Name = name;
            this.items = new List<IPhysicalItem>();
        }

        public string Name { get; set; }

        public List<IPhysicalItem> Items
        {
            get;
        }

        public int AttackValue
        {
            get
            {
                int attackValue = 0;
                foreach (IPhysicalItem item in this.Items)
                {
                    if (typeof(IAttackItem).IsInstanceOfType(item))
                    {
                        attackValue += ((IAttackItem)item).AttackValue;
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
                foreach (IPhysicalItem item in this.Items)
                {
                    if (typeof(IDefenseItem).IsInstanceOfType(item))
                    {
                        defenseValue += ((IDefenseItem)item).DefenseValue;
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

        public void AddItem(IPhysicalItem item)
        {
            this.Items.Add(item);
        }

        public void RemoveItem(IPhysicalItem item)
        {
            this.Items.Remove(item);
        }
    }
}