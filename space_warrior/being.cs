using System;
using System.Collections.Generic;
using System.Text;

namespace space_warrior
{
    public class being
    {
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }

        public being(int currentHP, int maxHP)
        {
            CurrentHP = currentHP;
            MaxHP = maxHP;
        }
    }
}
