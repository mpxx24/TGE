using Characters.Helpers;

namespace Localization.Helpers {
    public class MapUpdater {
        public static char[,] MoveCharacter(char[,] map, Direction direction) {
            var updatedMap = map;
            var width = map.GetLength(0);
            var height = map.GetLength(1);

            var indexY = 0;
            var indexX = 0;

            for (var i = 0; i < width; i++) {
                for (var j = 0; j < height; j++) {
                    if (map[i, j].Equals('M')) {
                        indexY = i;
                        indexX = j;
                    }
                }
            }

            map[indexY, indexX] = '-';

            switch (direction) {
                case Direction.Up:
                    map[indexY - 1, indexX] = 'M';
                    break;
                case Direction.Down:
                    map[indexY + 1, indexX] = 'M';
                    break;
                case Direction.Left:
                    map[indexY, indexX - 1] = 'M';
                    break;
                case Direction.Right:
                    map[indexY, indexX + 1] = 'M';
                    break;
            }

            MainCharacterHelper.PositionX = indexX;
            MainCharacterHelper.PositionY = indexY;

            return updatedMap;
        }
    }
}