using System;
using Age_Of_Magic;

namespace Age_Of_Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в Age Of Magic");

            DefaultComands.Enter();
            DefaultComands.Hello();

            SendPlayerType();
        }

        public static void SendPlayerType()
        {
            int playType;
            if (!int.TryParse(Console.ReadLine(), out playType))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 3.");
                SendPlayerType();
                return;
            }

            if (playType < 1 || playType > 3)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 3.");
                SendPlayerType();
                return;
            }

            InitHandler(playType);
        }

        public static void InitHandler(int playType)
        {
            Handler handler = new Handler(playType);
            Console.Clear();
            handler.GetPlayerClass();
            handler.Menu();
        }

    }
}
