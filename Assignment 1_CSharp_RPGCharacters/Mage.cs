using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_CSharp_RPGCharacters
{
    public class Mage : Hero
    {

        //base attributes of character plus equipable items
        public Mage(string name) : base(name)
        {
            PrimaryAttributes = new PrimaryAttributes(1, 1, 8);
            UpdatedAttributes = new PrimaryAttributes() { dexterity = 1, intelligence = 5, strength = 1 };
            CompatibleWeapons = new WeaponType[] { WeaponType.STAFF, WeaponType.WAND };
            CompatibleArmor = new ArmorType[] {ArmorType.CLOTH };
        }

        public override double TotalAttributes()
        {


            double totalAttributes = this.attributes.intelligence;
            foreach (var armour in Equipment.Select(x => x.Value).OfType<Armor>())
            {
                totalAttributes += armour.ArmorAttributes.intelligence;
            }
            return totalAttributes;
        }

    }
       
}
