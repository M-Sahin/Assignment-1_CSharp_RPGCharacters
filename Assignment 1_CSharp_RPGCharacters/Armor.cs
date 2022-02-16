using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_CSharp_RPGCharacters
{
    //Armortypes and attributes
    public enum ArmorType
    {
        CLOTH, LEATHER, MAIL, PLATE
    }

    public class Armor : Item
    {
        public PrimaryAttributes ArmorAttributes { get; set; }
        public ArmorType ItemType { get; set; }
    }
    

}

    



