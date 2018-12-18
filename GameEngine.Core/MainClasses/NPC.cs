using GameEngine.Core.Common;

namespace GameEngine.Core.MainClasses {

    /// <summary>
    ///     Base class for all NPCs
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class NPC : Character {
        public NPC(string name, char shortName, int hp, int gold, Coordinates coordinates) : base(name, shortName, hp, gold, coordinates) {
        }
    }

}