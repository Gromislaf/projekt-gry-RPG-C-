using System;
using System.Collections.Generic;
using System.Text;

namespace space_warrior
{
    public static class RandomGen
    {
        
        
            private static Random _generator = new Random();

            public static int NumberBetween(int minimumValue, int maximumValue)
            {
                return _generator.Next(minimumValue, maximumValue + 1);
            }
        }
    }

