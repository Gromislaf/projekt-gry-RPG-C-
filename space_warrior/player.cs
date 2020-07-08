using System;
using System.Collections.Generic;
using System.Text;

namespace space_warrior
{
   public class player : being
    {
            public int EXP { get; set; }
            public int Lvl { get; set; }

        public player(int eXP, int lvl, int currentHP, int maxHP) : base(currentHP, maxHP)
        {
            EXP = eXP;
            Lvl = lvl;
        }
    }

}

