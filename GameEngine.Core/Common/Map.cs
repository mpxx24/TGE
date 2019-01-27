using System.Collections.Generic;
using GameEngine.Core.Exceptions;
using GameEngine.Core.Helpers;
using GameEngine.Core.MainClasses;

namespace GameEngine.Core.Common {
    public class Map {
        public char[,] MapTable { get; set; }

        private IList<ItemOnTheGround> itemsOnTheMap { get; } = new List<ItemOnTheGround>();

        public IList<Character> CharactersOnTheMap { get; } = new List<Character>();

        public void AddCharacterOnTheMap(Character character) {
            this.CharactersOnTheMap.Add(character);
            var characterToUpdate = this.MapTable[character.Coordinates.X, character.Coordinates.Y];
            if (characterToUpdate == ApplicationSettings.EmptyMapCharacter) {
                this.MapTable[character.Coordinates.X, character.Coordinates.Y] = character.ShortName;
            }
            else {
                throw new FailedToUpdateMapException($"Failed to add character {character.ShortName} to the map. Expected empty tile but was {characterToUpdate}!");
            }
        }

        public void AddItemOnTheMap(ItemOnTheGround item) {
            this.itemsOnTheMap.Add(item);
            var characterToUpdate = this.MapTable[item.Coordinates.X, item.Coordinates.Y];
            if (characterToUpdate == ApplicationSettings.EmptyMapCharacter) {
                this.MapTable[item.Coordinates.X, item.Coordinates.Y] = item.ShortName;
            }
            else {
                throw new FailedToUpdateMapException($"Failed to add item {item.ShortName} to the map. Expected empty tile but was {characterToUpdate}!");
            }
            this.MapTable[item.Coordinates.X, item.Coordinates.Y] = item.ShortName;
        }

        public Coordinates GetCharacterCoordinates(char characterShortName) {
            var height = this.MapTable.GetLength(0);
            var width = this.MapTable.GetLength(1);

            var coordinates = new Coordinates(0, 0);

            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) {
                    if (this.MapTable[i, j].Equals(characterShortName)) {
                        coordinates.Y = i;
                        coordinates.X = j;
                    }
                }
            }

            return coordinates;
        }
    }
}