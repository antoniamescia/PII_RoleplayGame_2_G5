using System;

namespace RoleplayGame
{
    public interface IMagicDefenseItem : IMagicItem
    {
        int DefenseValue { get; }
    }
}
