using System;
using System.Collections.Generic;
using System.Text;

namespace space_warrior
{
   public class Player : Being
    {
            public int EXP { get; set; }
            public int Lvl { get; set; }
            public Weapon CurrentWeapon { get; set; }
            public List<Backpack> BP { get; set;}
       

        public Player(int eXP, int lvl, int currentHP, int maxHP, Weapon currentWeapon) : base(currentHP, maxHP)
        {
            EXP = eXP;
            Lvl = lvl;
            BP = new List<Backpack>();
            CurrentWeapon = currentWeapon;

        }
    }

}

