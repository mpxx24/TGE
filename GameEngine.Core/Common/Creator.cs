using System;
using System.Text;
using GameEngine.Core.Helpers;

namespace GameEngine.Core.Common {

    /// <summary>
    ///     Class for generating locations
    /// </summary>
    public static class Creator {
        /// <summary>
        ///     Creates the map.
        /// </summary>
        /// <param name="height">The height.</param>
        /// <param name="width">The width.</param>
        /// <param name="isRoom">if set to <c>true</c> [is room].</param>
        /// <returns></returns>
        public static Map CreateMap(int height, int width, bool isRoom) {
            var map = new Map();

            var mapTable = new char[height, width];

            if (!isRoom) {
                for (var i = 0; i < height; i++) {
                    for (var j = 0; j < width; j++) {
                        mapTable[i, j] = ApplicationSettings.WallMapCharacter;
                    }
                }
            }
            else {
                for (var i = 0; i < height; i++) {
                    for (var j = 0; j < width; j++) {
                        if (i == 0 || i == (height - 1) || j == 0 || j == (width - 1)) {
                            mapTable[i, j] = ApplicationSettings.WallMapCharacter;
                        }
                        else {
                            mapTable[i, j] = ApplicationSettings.EmptyMapCharacter;
                        }
                    }
                }
            }

            map.MapTable = mapTable;

            return map;
        }

        /// <summary>
        /// Gets the map.
        /// </summary>
        /// <param name="map">The map.</param>
        /// <returns></returns>
        public static string GetMapAsString(Map map) {
            var result = new StringBuilder();

            for (var i = 0; i < map.MapTable.GetLength(0); i++) {
                for (var j = 0; j < map.MapTable.GetLength(1); j++) {
                    result.Append(map.MapTable[i, j]);
                }
                result.Append(Environment.NewLine);
            }
            
            return result.ToString();
        }
    }
}