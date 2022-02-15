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
        private WeaponType WeaponType { get; set; }
        private int damage;
        private double attackSpeed { get; set; }
        private double weaponDPS { get; set; }
        public Weapon()
        {
        }
            public Weapon(string name, int level, Inventory itemSlot, WeaponType weaponType, int damage, double attackSpeed, double weaponDPS)
        {
            
            this.WeaponType = weaponType;
            this.damage = damage;
            this.attackSpeed = attackSpeed;
            this.weaponDPS = weaponDPS;
        }
        
        

    }
}

