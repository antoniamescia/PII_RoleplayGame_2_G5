using System;

namespace RoleplayGame
{
    public interface IAttackItem : IPhysicalItem
    {
        int AttackValue { get; }
    }
}
