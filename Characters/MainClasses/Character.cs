using System.Collections.Generic;
using Characters.Interfaces;
using Items.MainClasses;

namespace Characters.MainClasses {

    /// <summary>
    ///     Base class for all characters
    /// </summary>
    public class Character : ICharacters {
        public string Name { get; set; }

        // ReSharper disable once InconsistentNaming
        public int HP { get; set; }

        public int Gold { get; set; }

        public List<Item> Inventory { get; set; }
    }

}