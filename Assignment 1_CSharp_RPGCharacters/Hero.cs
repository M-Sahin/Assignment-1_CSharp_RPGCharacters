using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_CSharp_RPGCharacters
{
    public abstract class Hero
    {
        public string name;
        public int level;
        public PrimaryAttributes PrimaryAttributes { get; set; }
        public PrimaryAttributes attributes { get; set; }
        public PrimaryAttributes UpdatedAttributes { get; set; }
        public PrimaryAttributes TotalPrimaryAttributes { get; set; }

        protected Dictionary<Slot, Item> Equipment { get; set; }

        protected ArmorType[] CompatibleArmor;

        protected WeaponType[] CompatibleWeapons;
        public double HeroDamage { get; set; }
        public Dictionary<Slot, Item> Equipped { get; set; }


        public Hero(string name)
        {
            this.name = name;
            level = 1;
            Equipment = new Dictionary<Slot, Item>();
            TotalPrimaryAttributes = PrimaryAttributes;

        }

        /// <summary>
        /// Method for increasing hero level
        /// </summary>
        public void LevelUp()
        {
            attributes += UpdatedAttributes;
            level++;
        }
        public string EquipItem(Armor ItemToBeEquipped)
        {
            if (ItemToBeEquipped.ItemSlot == Slot.WEAPON)
            {
                throw new InvalidArmorException("Cant equip this armor.");
            }
            else if (!(CompatibleArmor.Contains(ItemToBeEquipped.ItemType)))
            {
                throw new InvalidArmorException("Cant equip this type of armor.");
            }
            else if (ItemToBeEquipped.ItemLevel > level)
            {
                throw new InvalidArmorException("Get a higher level first! Kill more trolls!");
            }
            else
            {
                Equipped[ItemToBeEquipped.ItemSlot] = ItemToBeEquipped;
                return "You have equipped a new piece of armor.";
            }
        }
        public string EquipItem(Weapon ItemToBeEquipped)
        {
            if (ItemToBeEquipped.ItemSlot != Slot.WEAPON)
            {
                throw new InvalidWeaponException("Cant equip this weapon.");
            }
            else if (!(CompatibleWeapons.Contains(ItemToBeEquipped.WeaponType)))
            {
                throw new InvalidWeaponException("Cant equip this type of weapon.");
            }
            else if (ItemToBeEquipped.ItemLevel > level)
            {
                throw new InvalidWeaponException("Get a higher level first! Kill more trolls!");
            }
            else
            {
                Equipped[ItemToBeEquipped.ItemSlot] = ItemToBeEquipped;
                return "You have equipped a new weapon. May it guide you well, young Padawan.";
            }
        }

        public abstract double TotalAttributes();

            public void Stats()
            {
            int totalStrength = this.attributes.strength;
            int totalDexterity = this.attributes.dexterity;
            int totalIntelligence = this.attributes.intelligence;
            foreach (var Item in Equipment.Select(x => x.Value).OfType<Armor>())
            {
                totalStrength += Item.ArmorAttributes.strength;
                totalIntelligence += Item.ArmorAttributes.intelligence;
                totalStrength += Item.ArmorAttributes.strength;
            }
            
            StringBuilder stats = new StringBuilder("", 200);
            stats.AppendFormat("----STATS----{0}", Environment.NewLine);
            stats.AppendFormat("Name: {0} (level: {1}){2}", this.name, this.level, Environment.NewLine);
            stats.AppendFormat("Strength: {0}{1}", totalStrength, Environment.NewLine);
            stats.AppendFormat("Intelligence: {0}{1}", totalIntelligence, Environment.NewLine);
            stats.AppendFormat("Dexterity: {0}{1}", totalDexterity, Environment.NewLine);
            stats.AppendFormat("Damage: {0}", this.HeroDPS());
            Console.WriteLine(stats);
            }
            public double HeroDPS()
            {
            var EquippedWeapon = Equipment.Values.OfType<Weapon>().SingleOrDefault();
            double HeroDamage = 1.0 + TotalAttributes()/ 100.0;
            if (EquippedWeapon != null)
                HeroDamage *= EquippedWeapon.WeaponDamage();
            return HeroDamage;
            }
       
        
        

    }

        
       

       
        

}

