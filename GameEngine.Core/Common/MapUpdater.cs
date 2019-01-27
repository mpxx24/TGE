using System.Linq;
using GameEngine.Core.Helpers;

namespace GameEngine.Core.Common {
    public class MapUpdater {
        public static Map MoveCharacter(Map map, Direction direction, char characterShortName) {
            var oldCoordinates = map.GetCharacterCoordinates(characterShortName);

            Coordinates newPlaceOnTheMap;

            switch (direction) {
                case Direction.Up:
                    newPlaceOnTheMap = new Coordinates(oldCoordinates.X, oldCoordinates.Y - 1);
                    break;
                case Direction.Down:
                    newPlaceOnTheMap = new Coordinates(oldCoordinates.X, oldCoordinates.Y + 1);
                    break;
                case Direction.Left:
                    newPlaceOnTheMap = new Coordinates(oldCoordinates.X - 1, oldCoordinates.Y);
                    break;
                case Direction.Right:
                    newPlaceOnTheMap = new Coordinates(oldCoordinates.X + 1, oldCoordinates.Y);
                    break;
                default:
                    newPlaceOnTheMap = new Coordinates(0, 0);
                    break;
            }

            if (map.MapTable[newPlaceOnTheMap.Y, newPlaceOnTheMap.X] == ApplicationSettings.EmptyMapCharacter) {
                map.MapTable[oldCoordinates.Y, oldCoordinates.X] = ApplicationSettings.EmptyMapCharacter;
                map.MapTable[newPlaceOnTheMap.Y, newPlaceOnTheMap.X] = characterShortName;

                var characterToMove = map.CharactersOnTheMap.FirstOrDefault(x => x.ShortName == characterShortName);
                if (characterToMove != null) {
                    characterToMove.Coordinates = newPlaceOnTheMap;
                }
            }

            return map;
        }
    }
}