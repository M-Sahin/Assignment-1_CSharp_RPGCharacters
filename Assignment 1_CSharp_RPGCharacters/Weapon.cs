using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_CSharp_RPGCharacters
{
    public enum WeaponType
    {
        AXE, BOW, DAGGER, HAMMER, STAFF, SWORD, WAND
    }

    public class Weapon : Item
    {
        public WeaponType WeaponType { get; set; }

        public int damage;
        public double attackSpeed { get; set; }
        public double weaponDPS { get; set; }
        public class WeaponAttributes
        {
            public int Damage { get; set; }
            public double AttackSpeed { get; set; }
        }
        public Weapon()
        {
        }
            public Weapon(string name, int level, Slot itemSlot, WeaponType weaponType, int damage, double attackSpeed, double weaponDPS)
        {
            
            this.WeaponType = weaponType;
            this.damage = damage;
            this.attackSpeed = attackSpeed;
            this.weaponDPS = weaponDPS;
        }
        public double WeaponDamage()
        {
            return attackSpeed * weaponDPS;
        }
        
        

    }
}

