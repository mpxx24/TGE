using System;
using Localization.Helpers;

namespace GameEngine.Helpers {
    public class GameRunner {
        public static void Run() {
            ConsoleKey key;

            var map = Creator.CreateMap(24, 50, true);
            Console.WriteLine(Creator.GetMapAsString(map));

            do {
                key = Console.ReadKey().Key;
                switch (key) {
                    case ConsoleKey.UpArrow:
                        map = MapUpdater.MoveCharacter(map, Direction.Up);
                        Console.WriteLine(Creator.GetMapAsString(map));
                        break;
                    case ConsoleKey.DownArrow:
                        map = MapUpdater.MoveCharacter(map, Direction.Down);
                        Console.WriteLine(Creator.GetMapAsString(map));
                        break;
                    case ConsoleKey.LeftArrow:
                        map = MapUpdater.MoveCharacter(map, Direction.Left);
                        Console.WriteLine(Creator.GetMapAsString(map));
                        break;
                    case ConsoleKey.RightArrow:
                        map = MapUpdater.MoveCharacter(map, Direction.Right);
                        Console.WriteLine(Creator.GetMapAsString(map));
                        break;
                }
            } while (key != ConsoleKey.Escape);
        }
    }
}