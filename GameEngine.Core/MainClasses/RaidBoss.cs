using GameEngine.Core.Common;

namespace GameEngine.Core.MainClasses {
    /// <summary>
    ///     Base class for all raid bosses
    /// </summary>
    public class RaidBoss : Monster {
        public RaidBoss(string name, char shortName, int hp, int gold, Coordinates coordinates) : base(name, shortName, hp, gold, coordinates) {
        }
    }
}