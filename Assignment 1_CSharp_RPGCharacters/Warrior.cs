using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_CSharp_RPGCharacters
{
    public class Warrior : Hero
    {

        //base attributes of character plus equipable items
        public Warrior(string name) : base(name)
        {
            PrimaryAttributes = new PrimaryAttributes(5, 2, 1);
            UpdatedAttributes = new PrimaryAttributes() { dexterity = 2, intelligence = 1, strength = 3 };
            CompatibleWeapons = new WeaponType[] { WeaponType.AXE, WeaponType.SWORD, WeaponType.HAMMER };
            CompatibleArmor = new ArmorType[] { ArmorType.PLATE, ArmorType.MAIL };
        }
        public override double TotalAttributes()
        {


            double totalAttributes = this.attributes.strength;
            foreach (var armour in Equipment.Select(x => x.Value).OfType<Armor>())
            {
                totalAttributes += armour.ArmorAttributes.strength;
            }
            return totalAttributes;
        }

    }
}
