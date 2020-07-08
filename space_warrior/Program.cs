using System;

namespace space_warrior
{
    class Program
    {
        static void Main(string[] args)
        {
            player _player = new player(0,1,10,10);

            Console.WriteLine("Poziom życia:{0}/{1} Doświadczenie:{2} Poziom: {3}", _player.CurrentHP, _player.MaxHP, _player.EXP, _player.Lvl);
            Console.ReadKey();
        }
    }
}
