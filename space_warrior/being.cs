using System;
using System.Collections.Generic;
using System.Text;

namespace space_warrior
{
    public class Being
    {
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }

        public Being(int currentHP, int maxHP)
        {
            CurrentHP = currentHP;
            MaxHP = maxHP;
        }
    }
}
