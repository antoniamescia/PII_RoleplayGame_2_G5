using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public interface IPhysicalCharacter : ICharacter
    {
        List<IPhysicalItem> Items { get; }
        void AddItem(IPhysicalItem item);
        void RemoveItem(IPhysicalItem item);
    }
}
