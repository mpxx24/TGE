using GameEngine.Core.MainClasses;

namespace GameEngine.Core.Interfaces {
    /// <summary>
    ///     Base interface for <see cref="Character"></see> class
    /// </summary>
    public interface ICharacters {
        string Name { get; set; }

        // ReSharper disable once InconsistentNaming
        int HP { get; set; }

        int Gold { get; set; }
    }
}