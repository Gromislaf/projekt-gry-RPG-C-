using System;
using System.Collections.Generic;
using System.Text;

namespace space_warrior
{
    public static class Things
    {
        public static readonly List<Weapon> Weapons = new List<Weapon>();
        public static readonly List<Enemy> Enemies = new List<Enemy>();


        public const int WEAPON_ID_BOLTER = 1;
        public const int WEAPON_ID_CHAINSWORD = 2;
        public const int WEAPON_ID_PLASMAGUN = 3;


        public const int ENEMY_ID_ORC = 1;
        public const int ENEMY_ID_CHAOSWARRIOR = 2;
        public const int ENEMY_ID_TYRANID = 3;



        static Things()
        {
            PopulateWeapons();
            PopulateEnemies();

        }

        private static void PopulateWeapons()
        {
            Weapons.Add(new Weapon(WEAPON_ID_BOLTER, "Bolter", 3, 5));
            Weapons.Add(new Weapon(WEAPON_ID_CHAINSWORD, "Chainsword", 4, 4));
            Weapons.Add(new Weapon(WEAPON_ID_PLASMAGUN, "Plasmagun", 0, 8));

        }

        private static void PopulateEnemies()
        {
            Enemy orc = new Enemy(ENEMY_ID_ORC, "Orc", 3, 4, 8, 8);
            orc.LootTable.Add(new Weaponloot(WeaponByID(WEAPON_ID_BOLTER), 75));

            Enemy chaoswarrior = new Enemy(ENEMY_ID_CHAOSWARRIOR, "Chaos Warrior", 4, 5, 10, 10);
            chaoswarrior.LootTable.Add(new Weaponloot(WeaponByID(WEAPON_ID_CHAINSWORD), 50));

            Enemy tyranid = new Enemy(ENEMY_ID_TYRANID, "Tyranid", 5, 4, 4, 4);
            orc.LootTable.Add(new Weaponloot(WeaponByID(WEAPON_ID_PLASMAGUN), 30));


            Enemies.Add(orc);
            Enemies.Add(chaoswarrior);
            Enemies.Add(tyranid);
        }



        public static Weapon WeaponByID(int id)
        {
            foreach (Weapon weapon in Weapons)
            {
                if (weapon.ID == id)
                {
                    return weapon;
                }
            }

            return null;
        }
    }
}
      
       
