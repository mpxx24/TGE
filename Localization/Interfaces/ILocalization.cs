using System.Collections.Generic;
using Characters.MainClasses;

namespace Localization.Interfaces {

    /// <summary>
    ///     Base interface for <see cref="Localization" />
    /// </summary>
    public interface ILocalization {
        string Name { get; set; }

        List<char> Map { get; set; }

        // ReSharper disable once InconsistentNaming
        List<NPC> NPCs { get; set; }
    }

}