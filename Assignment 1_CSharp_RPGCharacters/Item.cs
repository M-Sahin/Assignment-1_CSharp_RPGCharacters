using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_CSharp_RPGCharacters
{
   
    public class Item
    {
        private string ItemName { get; set; }
        private int ItemLevel { get; set; }
        private Item ItemSlot { get; set; }
        public Item()
        {

        }
        public Item(string name, int level, Item itemSlot)
        {
            this.ItemName = name;
            this.ItemLevel = level;
            this.ItemSlot = itemSlot;
        }
    }
}
