using System;
using System.Net;

namespace space_warrior
{




  

        class Program
        {
            static void Main(string[] args)
            {
                Player _player = new Player(0, 1, 30, 30);
                _player.BP.Add(new Backpack(Things.WeaponByID(Things.WEAPON_ID_BOLTER)));




            Console.WriteLine("Witaj w grze SPACE WARRIOR");
            Console.WriteLine();
            Console.WriteLine("Twój oddział padł ofiarą ataku znacznych sił nieprzyjaciela, w ferworze walki odłączyłeś się od swoich kompanów, Twoją jedyną szansą na przetrwanie jest przebić się przez hordy przeciwników i dołączyc do reszty oddziału ");
            Console.WriteLine();
            Console.WriteLine("Toje aktualne statystyki: Poziom życia:{0}/{1} Doświadczenie:{2} Poziom: {3}", _player.CurrentHP, _player.MaxHP, _player.EXP, _player.Lvl);
            Console.WriteLine();
            do
            {
                Console.WriteLine("Wybierz broń: \nBolter: wciśnij 1 \nMiecz Łańcucowy : wciśnij 2 \nKarabin Plazmowy: Wciśnij 3");
            
            
                int a = int.Parse(Console.ReadLine());
                a--;
                Console.WriteLine(Things.Weapons[a]);
                Console.WriteLine();

                Console.WriteLine("Przeciwnik Naciera!");
                Console.WriteLine();
                Random generator = new Random();
                int enemy = generator.Next(3);
                Console.WriteLine(Things.Enemies[enemy]);

                do
                {
                    int damageToEnemy = RandomGen.NumberBetween(Things.Weapons[a].MinimumDamage, Things.Weapons[a].MaximumDamage);

                    Things.Enemies[enemy].CurrentHP -= damageToEnemy;

                    Console.WriteLine();
                    Console.WriteLine("Zadałeś " + Things.Enemies[enemy].Name + " następującą liczbę obrażeń " + damageToEnemy);
                    Console.WriteLine();
                    Console.WriteLine(Things.Enemies[enemy]);
                    Console.WriteLine();
                    if (Things.Enemies[enemy].CurrentHP > 0)
                    {
                        _player.CurrentHP = _player.CurrentHP - Things.Enemies[enemy].Attack;
                        Console.WriteLine(Things.Enemies[enemy].Name + " zadał Ci następującą liczbę obrażeń: " + Things.Enemies[enemy].Attack);
                        Console.WriteLine();
                        Console.WriteLine("Aktualny poziom życia:{0}/{1} Doświadczenie:{2} Poziom: {3}", _player.CurrentHP, _player.MaxHP, _player.EXP, _player.Lvl);
                    }



                   


                } while (Things.Enemies[enemy].CurrentHP > 0 && _player.CurrentHP > 0);

                if (Things.Enemies[enemy].CurrentHP <= 0)
                {
                    Console.WriteLine("Pokonałeś wroga");
                    Console.WriteLine();
                    Console.WriteLine("Zdobywasz 500 pkt doświadczenia.");
                    Console.WriteLine();
                    _player.EXP = _player.EXP + 500;
                    Console.WriteLine("Aktualny poziom życia:{0}/{1} Doświadczenie:{2} Poziom: {3}", _player.CurrentHP, _player.MaxHP, _player.EXP, _player.Lvl);
                }
                if (_player.EXP > 1600)
                { _player.Lvl = 3; }
                else if (_player.EXP > 800)
                { _player.Lvl = 2; }

                if (_player.Lvl == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Udało Ci się przedrzeć do reszty twojego oddziału, WYGRAŁEŚ ");
                }
            } while (_player.Lvl < 3);

            //Console.WriteLine(Things.Enemies[enemy]);
            Console.WriteLine("Poziom życia:{0}/{1} Doświadczenie:{2} Poziom: {3}", _player.CurrentHP, _player.MaxHP, _player.EXP, _player.Lvl);
            Console.ReadKey();
            }
        }
    } 
