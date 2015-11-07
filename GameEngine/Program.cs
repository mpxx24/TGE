using System;
using Localization.Helpers;

namespace GameEngine {

    public static class Program {
        private static void Main() {
            var map = Creator.GetMap(24, 50, true);
            Console.WriteLine(map);

            Console.ReadLine();
        }
    }

}