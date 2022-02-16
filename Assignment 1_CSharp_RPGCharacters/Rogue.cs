using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_CSharp_RPGCharacters
{
    public class Rogue : Hero
    {
        private float experience;
        private string favoriteAttack;

        public Rogue(string name) : base(name)
        {
            PrimaryAttributes = new PrimaryAttributes(2, 6, 1);
            UpdatedAttributes = new PrimaryAttributes() { dexterity = 4, intelligence = 1, strength = 1 };
            CompatibleWeapons = new WeaponType[] { WeaponType.DAGGER, WeaponType.SWORD };
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
