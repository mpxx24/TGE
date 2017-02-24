using System;
using System.Text;

namespace Localization.Helpers {

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
        public static char[,] CreateMap(int height, int width, bool isRoom) {
            var map = new char[height, width];

            if (!isRoom) {
                for (var i = 0; i < height; i++) {
                    for (var j = 0; j < width; j++) {
                        map[i, j] = '#';
                    }
                }
            }
            else {
                for (var i = 0; i < height; i++) {
                    for (var j = 0; j < width; j++) {
                        if (i == 1 || i == (height - 1) || j == 0 || j == (width - 1)) {
                            map[i, j] = '#';
                        }
                        else {
                            map[i, j] = '-';
                        }
                    }
                }
            }

            map[3, 3] = 'M';

            return map;
        }

        /// <summary>
        /// Gets the map.
        /// </summary>
        /// <param name="map">The map.</param>
        /// <returns></returns>
        public static string GetMapAsString(char[,] map) {
            var result = new StringBuilder();

            for (var i = 0; i < map.GetLength(0); i++) {
                for (var j = 0; j < map.GetLength(1); j++) {
                    result.Append(map[i, j]);
                }
                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }
    }
}