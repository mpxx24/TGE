using System.Collections.Generic;
using GameEngine.Core.MainClasses;

namespace Localization.Helpers {
    public class Map {
        public char[,] MapTable { get; set; }

        private IList<ItemOnTheGround> itemsOnTheMap { get; } = new List<ItemOnTheGround>();

        private IList<Character> charactersOnTheMap { get; } = new List<Character>();

        public void AddCharacterOnTheMap(Character character) {
            this.charactersOnTheMap.Add(character);
            this.MapTable[character.Coordinates.X, character.Coordinates.Y] = character.ShortName;
        }

        public void AddItemOnTheMap(ItemOnTheGround item) {
            this.itemsOnTheMap.Add(item);
            this.MapTable[item.CurrentCoordinates.X, item.CurrentCoordinates.Y] = item.ShortName;
        }
    }
}