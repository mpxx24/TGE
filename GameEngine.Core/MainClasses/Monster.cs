using System;
using GameEngine.Core.Common;

namespace GameEngine.Core.MainClasses {
    /// <summary>
    ///     Base class for all monsters
    /// </summary>
    public class Monster : Character {
        public Monster(string name, char shortName, int hp, int gold, Coordinates coordinates) : base(name, shortName, hp, gold, coordinates) {
        }

        public Map ChaseCharacter(Map map, char shortName) {
            var characterToChaseCoordinates = map.GetCharacterCoordinates(shortName);

            var isXCoordinateCloserThanY = Math.Abs(characterToChaseCoordinates.X - this.Coordinates.X) < Math.Abs(characterToChaseCoordinates.Y - this.Coordinates.Y);
            var isCharAbove = characterToChaseCoordinates.Y < this.Coordinates.Y;
            var isCharRight = characterToChaseCoordinates.X > this.Coordinates.X;
            //var isCharTheSameRow = characterToChaseCoordinates.X == this.Coordinates.X;
            //var isCharTheSameColumn = characterToChaseCoordinates.Y == this.Coordinates.Y;

            if (isXCoordinateCloserThanY) {
                MapUpdater.MoveCharacter(map, isCharAbove ? Direction.Up : Direction.Down, this.ShortName);
            }
            else {
                MapUpdater.MoveCharacter(map, isCharRight ? Direction.Right : Direction.Left, this.ShortName);
            }
            
            return map;
        }
    }
}