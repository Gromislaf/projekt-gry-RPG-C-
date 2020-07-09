using System;
using System.Collections.Generic;
using System.Text;

namespace space_warrior
{
    public class Weaponloot
    {
        public Weapon Details { get; set; }
        public int DropPercentage { get; set; }
       

        public Weaponloot(Weapon details, int dropPercentage)
        {
            Details = details;
            DropPercentage = dropPercentage;
           
        }
    }
}
