using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_CSharp_RPGCharacters
{
   
    public class Item
    {
        public string ItemName { get; set; }
        public int ItemLevel { get; set; }
        public Slot ItemSlot { get; set; }
        public Item()
        {

        }
        public Item(string name, int level, Slot slot)
        {
            this.ItemName = name;
            this.ItemLevel = level;
            this.ItemSlot = slot;
        }
    }
}
