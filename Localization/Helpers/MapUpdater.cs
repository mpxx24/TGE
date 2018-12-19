using GameEngine.Core.Common;
using GameEngine.Core.Helpers;

namespace Localization.Helpers {
    public class MapUpdater {
        public static Map MoveCharacter(Map map, Direction direction, char characterShortName) {
            var height = map.MapTable.GetLength(0);
            var width = map.MapTable.GetLength(1);

            var indexY = 0;
            var indexX = 0;

            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) {
                    if (map.MapTable[i, j].Equals(characterShortName)) {
                        indexY = i;
                        indexX = j;
                    }
                }
            }

            //walls
            if (direction == Direction.Left && indexX == 1
                || direction == Direction.Up && indexY == 1
                || direction == Direction.Right && indexX == width - 2
                || direction == Direction.Down && indexY == height - 2) {
                return map;
            }


            Coordinates newPlaceOnTheMap;

            switch (direction) {
                case Direction.Up:
                    newPlaceOnTheMap = new Coordinates(indexX, indexY - 1);
                    break;
                case Direction.Down:
                    newPlaceOnTheMap = new Coordinates(indexX, indexY + 1);
                    break;
                case Direction.Left:
                    newPlaceOnTheMap = new Coordinates(indexX - 1, indexY);
                    break;
                case Direction.Right:
                    newPlaceOnTheMap = new Coordinates(indexX + 1, indexY);
                    break;
                default:
                    newPlaceOnTheMap = new Coordinates(0, 0);
                    break;
            }

            if (map.MapTable[newPlaceOnTheMap.Y, newPlaceOnTheMap.X] == ApplicationSettings.EmptyMapCharacter) {
                map.MapTable[indexY, indexX] = ApplicationSettings.EmptyMapCharacter;
                map.MapTable[newPlaceOnTheMap.Y, newPlaceOnTheMap.X] = characterShortName;
            }

            return map;
        }
    }
}