using System;

namespace space_warrior
{
    class Program
    {
        static void Main(string[] args)
        {
            Player _player = new Player(0,1,20,20);
            //_player.BP.Add(new Backpack(Things.WeaponByID(Things.WEAPON_ID_BOLTER)));
            Weapon bolter = new Weapon(1, "Bolter", 3, 5);

            Console.WriteLine("Poziom życia:{0}/{1} Doświadczenie:{2} Poziom: {3}", _player.CurrentHP, _player.MaxHP, _player.EXP, _player.Lvl);
            Console.WriteLine("Obecnie używasz broni {0} zadającej {1}-{2} obrażeń",bolter.Name, bolter.MinimumDamage, bolter.MaximumDamage);
            Console.ReadKey();
        }
    }
}
