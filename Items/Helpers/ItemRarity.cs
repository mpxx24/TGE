using Items.MainClasses;

namespace Items.Helpers {

    /// <summary>
    ///     Class representing <see cref="Item"></see> rarity
    /// </summary>
    public static class ItemRarity {
        public enum Rarity {
            Normal = 0,

            Average = 1,

            High = 2,

            VeryHigh = 3,

            Heroic = 4,

            Legendary = 5
        }
    }

}