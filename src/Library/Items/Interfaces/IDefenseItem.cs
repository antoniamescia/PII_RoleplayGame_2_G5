using System;

namespace RoleplayGame 
{
    public interface IDefenseItem : IPhysicalItem
    {
        int DefenseValue { get; }
    }
}