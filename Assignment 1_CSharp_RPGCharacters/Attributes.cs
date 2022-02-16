using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_CSharp_RPGCharacters
{
    public class PrimaryAttributes
    {
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int intelligence { get; set; }
        


        public PrimaryAttributes(int strength, int dexterity, int intelligence)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }

        public PrimaryAttributes()
        {
            strength = 0;
            dexterity = 0;
            intelligence = 0; 
        }
        
        //
        public static PrimaryAttributes operator+ (PrimaryAttributes attributes, PrimaryAttributes UpdatedAttributes)
        {
            attributes.strength += UpdatedAttributes.strength;
            attributes.dexterity += UpdatedAttributes.dexterity;
            attributes.intelligence += UpdatedAttributes.intelligence;
            return attributes;
        }


    }
}
