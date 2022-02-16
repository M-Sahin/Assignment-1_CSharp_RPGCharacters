using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_CSharp_RPGCharacters
{
    public class Ranger : Hero
    {
        //base attributes of character plus equipable items
        public Ranger(string name) : base(name)
        {
            PrimaryAttributes = new PrimaryAttributes(1, 7, 1);
            UpdatedAttributes = new PrimaryAttributes() { dexterity = 5, intelligence = 1, strength = 1 };
            CompatibleWeapons = new WeaponType[] { WeaponType.BOW};
            CompatibleArmor = new ArmorType[] { ArmorType.LEATHER, ArmorType.MAIL };
        }
        public override double TotalAttributes()
        {


            double totalAttributes = this.attributes.dexterity;
            foreach (var armour in Equipment.Select(x => x.Value).OfType<Armor>())
            {
                totalAttributes += armour.ArmorAttributes.dexterity;
            }
            return totalAttributes;
        }

    }
}
