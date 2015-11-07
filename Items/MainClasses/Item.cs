﻿using Items.Helpers;
using Items.Interfaces;

namespace Items.MainClasses {

    /// <summary>
    ///     Base class for intems
    /// </summary>
    public class Item : IItem {
        public float Durability { get; set; }

        public string Name { get; set; }

        public int Value { get; set; }

        public ItemRarity.Rarity Rarity { get; set; }
    }

}