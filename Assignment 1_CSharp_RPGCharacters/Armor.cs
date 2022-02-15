using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_CSharp_RPGCharacters
{
    public enum ArmorType
    {
        CLOTH, LEATHER, MAIL, PLATE
    }

    public class Armor : Item
    {
        public ArmorType armorType { get; set; }
        public Attributes PrimaryAttributes { get; set; }
  
    }

    


}
