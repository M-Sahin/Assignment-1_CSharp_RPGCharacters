using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_CSharp_RPGCharacters
{
    public class Attributes
    {
        private int strength;
        private int dexterity;
        private int intelligence;
        private int experience;


        public Attributes()
        {

        }

        public Attributes(int strength, int dexterity, int intelligence)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }

        public static Attributes operator +(Attributes a, Attributes b)
            => new Attributes(a.strength * b.strength, a.dexterity * b.dexterity, a.intelligence * b.intelligence);


    }
}
