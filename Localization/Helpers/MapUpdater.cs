namespace Localization.Helpers {
    public class MapUpdater {
        public static Map MoveCharacter(Map map, Direction direction, char charakterShortName) {
            var updatedMap = map;
            var height = map.MapTable.GetLength(0);
            var width = map.MapTable.GetLength(1);

            var indexY = 0;
            var indexX = 0;

            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) {
                    if (map.MapTable[i, j].Equals(charakterShortName)) {
                        indexY = i;
                        indexX = j;
                    }
                }
            }

            if (direction == Direction.Left && indexX == 1
                || direction == Direction.Up && indexY == 1
                || direction == Direction.Right && indexX == width - 2
                || direction == Direction.Down && indexY == height - 2) {
                return updatedMap;
            }

            map.MapTable[indexY, indexX] = ' ';

            switch (direction) {
                case Direction.Up:
                    map.MapTable[indexY - 1, indexX] = charakterShortName;
                    break;
                case Direction.Down:
                    map.MapTable[indexY + 1, indexX] = charakterShortName;
                    break;
                case Direction.Left:
                    map.MapTable[indexY, indexX - 1] = charakterShortName;
                    break;
                case Direction.Right:
                    map.MapTable[indexY, indexX + 1] = charakterShortName;
                    break;
            }

            return updatedMap;
        }
    }
}