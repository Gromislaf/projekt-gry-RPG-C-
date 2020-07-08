using System;
using System.Collections.Generic;
using System.Text;

namespace space_warrior
{
   public class enemy : being
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Attack { get; set; }
        public int RewardEXP { get; set; }

        public enemy(int iD, string name, int attack, int rewardEXP, int currentHP, int maxHP) : base(currentHP, maxHP)
        {
            ID = iD;
            Name = name;
            Attack = attack;
            RewardEXP = rewardEXP;
        }
    }
}
