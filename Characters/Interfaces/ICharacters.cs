using System.Collections.Generic;
using Characters.MainClasses;
using Items.MainClasses;

namespace Characters.Interfaces {

    /// <summary>
    ///     Base interface for <see cref="Character"></see> class
    /// </summary>
    public interface ICharacters {
        string Name { get; set; }

        // ReSharper disable once InconsistentNaming
        int HP { get; set; }

        int Gold { get; set; }

        List<Item> Inventory { get; set; }
    }

}