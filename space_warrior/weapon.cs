using System;
using System.Collections.Generic;
using System.Text;

namespace space_warrior
{
    public class weapon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

        public weapon(int iD, string name, int minimumDamage, int maximumDamage)
        {
            ID = iD;
            Name = name;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
