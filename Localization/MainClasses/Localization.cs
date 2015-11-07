using System.Collections.Generic;
using Characters.MainClasses;
using Localization.Interfaces;

namespace Localization.MainClasses {

    /// <summary>
    ///     Base class for all Localizations
    /// </summary>
    public class Localization : ILocalization {
        public string Name { get; set; }

        public List<char> Map { get; set; }

        public List<NPC> NPCs { get; set; }
    }

}