using System;

namespace RoleplayGame
{
    public interface IMagicAttackItem : IMagicItem
    {
        int AttackValue { get; }
    }
}
