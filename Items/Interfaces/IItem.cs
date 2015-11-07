﻿using Items.Helpers;
using Items.MainClasses;

namespace Items.Interfaces {

    /// <summary>
    ///     Base interface for <see cref="Item" />
    /// </summary>
    public interface IItem {
        string Name { get; set; }

        int Value { get; set; }

        ItemRarity.Rarity Rarity { get; set; }

        float Durability { get; set; }
    }

}