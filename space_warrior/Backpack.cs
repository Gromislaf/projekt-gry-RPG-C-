using System;
using System.Collections.Generic;
using System.Text;

namespace space_warrior
{
    public class Backpack
    {
        public Weapon Details { get; set; }
       

        public Backpack(Weapon details )
        {
            Details = details;
           
        }
        
    }
}
