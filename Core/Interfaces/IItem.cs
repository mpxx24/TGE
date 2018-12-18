using Core.Helpers;
using Core.MainClasses;

namespace Core.Interfaces {

    /// <summary>
    ///     Base interface for <see cref="Item" />
    /// </summary>
    public interface IItem {
        string Name { get; set; }

        int Value { get; set; }

        ItemRarity.Rarity Rarity { get; set; }

        float Durability { get; set; }
    }

}