using System;
namespace Age_Of_Magic
{
	partial class Character
    {
        public static int _balance { get; set; }

        public void CheatCode()
        {
            Console.WriteLine("Введите читкод:");
            Console.WriteLine("/setbalance");
            Console.WriteLine("/heal");
            DefaultComands.Escape();

            string cheatcode = Console.ReadLine()!;

            if (cheatcode == "/setbalance")
            {
                _balance = _balance + 10000;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\x1b[1mУспешно");
                Console.ResetColor();
                Console.WriteLine($"\x1b[0mБаланс: {_balance}");
                Console.WriteLine();
            }
            else if (cheatcode == "/heal")
            {
                _currentHealth = _maxHealth;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\x1b[1mУспешно");
                Console.ResetColor();
                Console.WriteLine($"\x1b[0mЗдоровье: {_currentHealth}");
                Console.WriteLine();
            }
            else if (cheatcode == "0")
            {
                Console.Clear();
                GetInventory();
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверно. Повторите еще раз");
                Console.ResetColor();
                CheatCode();
            }
        }

    }
}

