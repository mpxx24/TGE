using GameEngine.Core.Common;

namespace GameEngine.Core.MainClasses {

    /// <summary>
    ///     Base class for all monsters
    /// </summary>
    public class Monster : Character {
        public Monster(string name, char shortName, int hp, int gold, Coordinates coordinates) : base(name, shortName, hp, gold, coordinates) {
        }
    }

}