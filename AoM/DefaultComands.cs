using System;
namespace Age_Of_Magic
{
    class DefaultComands
    {
        public static void Enter()
        {
            Console.WriteLine("\x1b[0m");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Для продолжения нажмите Enter...");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine();
        }

        public static void Hello()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\x1b[1mВыберите класс персонажа:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\x1b[1m1 - Человек");
            Console.ResetColor();
            Console.WriteLine("\x1b[0mУниверсальный класс, обладающий сбалансированными характеристиками. ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\x1b[1m2 - Маг");
            Console.ResetColor();
            Console.WriteLine("\x1b[0mКласс, специализирующийся на использовании магии для атаки, защиты и исцеления.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\x1b[1m3 - Демон");
            Console.ResetColor();
            Console.WriteLine("\x1b[0mМогущественные существа из иных миров, обладающие магическими способностями и силой.");
        }

        public static void ChoiseItemToBuy()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\x1b[1mВыберите предмет для покупки");
            Console.ResetColor();
            Console.WriteLine("\x1b[0m");
        }

        public static void LowBalance(int _balance)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\x1b[1mНе хватает денег. Баланс: {_balance}");
            Console.ResetColor();
        }

        public static void Escape()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\x1b[1m0 - Выйти");
            Console.ResetColor();
            Console.WriteLine("\x1b[0m");
        }
    }
}

