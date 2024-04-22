using System;

namespace Age_Of_Magic
{
    class ShowInventory : Character 
    {
        public static string[] weaponInventory = new string[10];
        public static string[] armorInventory = new string[10];

        /// <summary>
        /// Информация о персонаже. Класс, баланс и статы
        /// </summary>
        public static void ShowCharacterStats()
        {
            UpdateNextLevelXP();
            Console.WriteLine("                \\\\Инвентарь//");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write($"Ваш класс: {_personClass}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"              {_balance} Gold");
            Console.ResetColor();
            Console.WriteLine($"Уровень: {_level} {_currentXp}/{_nextLevelXP}XP");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\x1b[1mHealth ♥ ");
            Console.Write($"{_currentHealth}");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"\x1b[1mMax Health: ");
            Console.Write($"♥ {_maxHealth}");
            Console.ResetColor();
            Console.WriteLine("\x1b[0m");
            Console.WriteLine();

            Console.WriteLine($"Урон: {_damage}");
            //Console.WriteLine($"Сила: {_power}");
            //Console.WriteLine($"Ловкость: {_dexterity}");
            //Console.WriteLine($"Интеллект: {_intelligence}");
            //Console.WriteLine($"Выностивость: {_stamina}");
            //Console.WriteLine();
        }

        /// <summary>
        /// Предметы в инвентаре
        /// </summary>
        public static void GetItems()
        {
            GetWeaponInventory();
            GetArmorInventory();
            //Дописать другие предметы
        }

        public static void SetInventoryWeapons(ref string[] inventoryWeapons)
        {
            for (int i = 0; i < inventoryWeapons.Length; i++)
            {
                if (weaponInventory[i] == null && inventoryWeapons[i] != null)
                {
                    weaponInventory[i] = inventoryWeapons[i];
                }
            }
        }

        public static void SetInventoryArmor(ref string[] inventoryArmor)
        {
            for (int i = 0; i < inventoryArmor.Length; i++)
            {
                if (armorInventory[i] == null && inventoryArmor[i] != null)
                {
                    armorInventory[i] = inventoryArmor[i];
                }
            }
        }

        public static void GetWeaponInventory()
        {
            if (weaponInventory[0] != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Оружие:");
                Console.ResetColor();
                for (int i = 0; i < weaponInventory.Length; i++)
                {
                    if (weaponInventory[i] != null)
                    {
                        Console.WriteLine($"{i + 1}. {weaponInventory[i]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("У вас нет оружия. Зайдите в магазин.");
            }
        }

        public static void GetArmorInventory()
        {
            if (armorInventory[0] != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Броня:");
                Console.ResetColor();
                for (int i = 0; i < armorInventory.Length; i++)
                {
                    if (armorInventory[i] != null)
                    {
                        Console.WriteLine($"{i + 1}. {armorInventory[i]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("У вас нет брони. Зайдите в магазин.");
            }
        }
    }
}

