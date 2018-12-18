using GameEngine.Core.Helpers;
using GameEngine.Core.Interfaces;

namespace GameEngine.Core.MainClasses {

    /// <summary>
    ///     Base class for intems
    /// </summary>
    public class Item : IItem {
        public float Durability { get; set; }

        public string Name { get; set; }

        public char ShortName { get; set; }

        public int Value { get; set; }

        public ItemRarity.Rarity Rarity { get; set; }
    }

}