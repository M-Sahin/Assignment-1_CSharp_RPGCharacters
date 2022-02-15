using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_CSharp_RPGCharacters
{
    public class Hero
    {
        private string name;
        private int level;
        private Attributes PrimaryAttributes;
        private Attributes TotalAttributes;

        public Hero()
        {

        }
        public Hero(string name)
        {
            this.name = name;
            this.level = 1;
        }



    }
}
