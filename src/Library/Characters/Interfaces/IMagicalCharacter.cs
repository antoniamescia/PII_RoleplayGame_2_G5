using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public interface IMagicalCharacter : ICharacter
    {
        List<IItem> Items { get; }
        void AddItem(IItem item);
        void RemoveItem(IItem item);
    }
}
