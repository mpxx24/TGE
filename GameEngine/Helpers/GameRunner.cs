using System;
using System.Threading;
using GameEngine.Core.Common;
using GameEngine.Core.MainClasses;

namespace GameEngine.Helpers {
    public class GameRunner {
        public static void Run() {
            var mainCharacter = new Character("mpx", 'M', 100, 0, new Coordinates(3, 3));
            var npc = new NPC("Shop", '$', 0, 1000, new Coordinates(1, 16));
            var enemy = new Monster("Wolf", 'w', 0, 20, new Coordinates(6, 8));

            var map = Creator.CreateMap(10, 20, true);
            map.AddCharacterOnTheMap(mainCharacter);
            map.AddCharacterOnTheMap(npc);
            map.AddCharacterOnTheMap(enemy);

            Console.Write(Creator.GetMapAsString(map));

            do {
                while (!Console.KeyAvailable) {
                    Thread.Sleep(150);
                    var key = Console.ReadKey().Key;

                    switch (key) {
                        case ConsoleKey.UpArrow:
                            map = MapUpdater.MoveCharacter(map, Direction.Up, mainCharacter.ShortName);
                            break;
                        case ConsoleKey.DownArrow:
                            map = MapUpdater.MoveCharacter(map, Direction.Down, mainCharacter.ShortName);
                            break;
                        case ConsoleKey.LeftArrow:
                            map = MapUpdater.MoveCharacter(map, Direction.Left, mainCharacter.ShortName);
                            break;
                        case ConsoleKey.RightArrow:
                            map = MapUpdater.MoveCharacter(map, Direction.Right, mainCharacter.ShortName);
                            break;
                    }

                    map = enemy.ChaseCharacter(map, mainCharacter.ShortName);
                    UpdateMap(map);
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static void UpdateMap(Map newMap) {
            Console.Clear();
            Console.Write(Creator.GetMapAsString(newMap));
        }
    }
}