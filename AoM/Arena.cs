using System;
using Microsoft.VisualBasic.FileIO;

namespace Age_Of_Magic
{
	class Arena : Character
	{
        private static string arenaWeapon;
        private static string arenaArmor;

        public Arena()
		{

		}

        public void SetArenaWeaponInventory(int item)
        {
            if (ShowInventory.weaponInventory[item - 1] != null)
            {
                arenaWeapon = ShowInventory.weaponInventory[item - 1];
                Console.Clear();
                Console.WriteLine($"В руке {arenaWeapon}");
            }
        }

        public void SetArenaArmorInventory(int item)
        {
            if (ShowInventory.armorInventory[item - 1] != null)
            {
                arenaArmor = ShowInventory.armorInventory[item - 1];
                Console.Clear();
                Console.WriteLine($"Надел {arenaArmor}");
            }
        }

        public void GetArenaWeaponInventory()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Снаряжение:");
            Console.ResetColor();
            if (arenaWeapon != null)
            {
                Console.WriteLine($"  {arenaWeapon}");
            }
            else
            {
                Console.WriteLine("Только кулаки");
            }

            if (arenaArmor != null) //Для брони
            {
                Console.WriteLine($"  {arenaArmor}");
            }
            else
            {
                Console.WriteLine("Брони нет");
            }
        }
    }
}

