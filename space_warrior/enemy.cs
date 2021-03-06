﻿using System;
using System.Collections.Generic;
using System.Text;

namespace space_warrior
{
   public class Enemy : Being
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; }
        public int RewardEXP { get; set; }
      
        public List<Weaponloot> LootTable { get; set; }

        public Enemy(int iD, string name, int attack, int rewardEXP, int currentHP, int maxHP) : base(currentHP, maxHP)
        {
            ID = iD;
            Name = name;
            Attack = attack;
            RewardEXP = rewardEXP;
           
            LootTable = new List<Weaponloot>();
        }

        public override string ToString()
        {
            return "Walczysz z: " + Name + " pozostało mu: " + CurrentHP + " punktów życia";
        }
    }
}
