using System.Collections.Generic;
using GameEngine.Core.Common;
using GameEngine.Core.Interfaces;

namespace GameEngine.Core.MainClasses {
    /// <summary>
    ///     Base class for all characters
    /// </summary>
    public class Character : ICharacters {
        public Character(string name, char shortName, int hp, int gold, Coordinates coordinates) {
            this.Name = name;
            this.ShortName = shortName;
            this.HP = hp;
            this.Gold = gold;
            this.Coordinates = coordinates;
            this.Inventory = new List<Item>();
        }

        private List<Item> Inventory { get; }

        public Coordinates Coordinates { get; set; }

        public char ShortName { get; set; }

        public string Name { get; set; }

        // ReSharper disable once InconsistentNaming
        public int HP { get; set; }

        public int Gold { get; set; }

        public void AddItem(Item item) {
            this.Inventory.Add(item);
        }
    }
}