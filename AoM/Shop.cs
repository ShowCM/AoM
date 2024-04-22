using System;

namespace Age_Of_Magic
{
    class Shop : Character
    {
        private string[] _swords;
        private string[] _magical;
        private string[] _demonic;
        private int[] _weaponPrice;
        private string[] inventoryWeapons;

        private string[] _armor;
        private int[] _armorPrice;
        private string[] inventoryArmor;

        private string[] ShoppingItems;
        private int[] ShoppingPrice;

        int countWeapon = 0;
        int countArmor = 0;

        public Shop()
        {
            _weaponPrice = new int[] { 1000, 700, 500, 100 };
            _swords = new string[] { "Меч Короля Артура", "Молот Грома", "Лук Судьбы", "Боевой Клинок" };
            _magical = new string[] { "Жезл Молний", "Клинок Огня", "Жезл Иллюзий", "Свиток Знаний" };
            _demonic = new string[] { "Меч Тьмы", "Пожиратель Душ", "Лук Тени", "Кнут Иссушения" };

            inventoryWeapons = new string[_swords.Length];

            _armor = new string[] { "Квантовая Броня", "Эфирная Броня", "Плазменная Броня", "Титановая Броня", "Энергетическая Броня", "Магнитная Броня" };
            _armorPrice = new int[] { 30000, 15000, 5000, 1000, 600, 200 };

            inventoryArmor = new string[_armor.Length];
        }

        public void GetShopItems(int shopOption, int weaponsOption)
        {
            if(shopOption == 1)
            {
                if(weaponsOption == 1)
                {
                    ShoppingItems = _swords;
                    ShoppingPrice = _weaponPrice;
                }
                else if(weaponsOption == 2)
                {
                    ShoppingItems = _magical;
                    ShoppingPrice = _weaponPrice;
                }
                else if(weaponsOption == 3)
                {
                    ShoppingItems = _demonic;
                    ShoppingPrice = _weaponPrice;
                }
            }
            else if(shopOption == 2)
            {
                ShoppingItems = _armor;
                ShoppingPrice = _armorPrice;
            }

            for (int i = 0; i < ShoppingItems.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {ShoppingPrice[i]}Gold - {ShoppingItems[i]}");
            }
        }

        /// <summary>
        /// Покупка предмета в магазине
        /// </summary>
        /// <param name="item"></param>
        public void BuyItem(int item)
        {
            if(ShoppingItems.Length >= item && item > 0 && ShoppingItems == _swords || ShoppingItems == _magical || ShoppingItems == _demonic)
            {
                for (int i = countWeapon; i < countWeapon + 1; i++)
                {
                    if (_balance >= ShoppingPrice[item - 1])
                    {
                        inventoryWeapons[i] = ShoppingItems[item - 1];
                        WithdrawBuy(item);
                    }
                    else
                    {
                        DefaultComands.LowBalance(_balance);
                    }
                }
                countWeapon++;
                ShowInventory.SetInventoryWeapons(ref inventoryWeapons);
            }
            else if(ShoppingItems.Length >= item && item > 0 && ShoppingItems == _armor)
            {
                for (int i = countArmor; i < countArmor + 1; i++)
                {
                    if (_balance >= ShoppingPrice[item - 1])
                    {
                        inventoryArmor[i] = ShoppingItems[item - 1];
                        WithdrawBuy(item);
                    }
                    else
                    {
                        DefaultComands.LowBalance(_balance);
                    }
                }
                countArmor++;
                ShowInventory.SetInventoryArmor(ref inventoryArmor);
            }
            else if(ShoppingItems.Length < item || item < 1)
            {
                Console.Clear();
                Console.WriteLine("Некорректный ввод.");
                GetInventory();
            }
        }

        /// <summary>
        /// Уменьшение денег при покупке в магазине
        /// </summary>
        /// <param name="item"></param>
        public void WithdrawBuy(int item)
        {
            _balance = _balance - ShoppingPrice[item - 1];
            BoughtItem(item, ShoppingItems, ShoppingPrice);
        }

        /// <summary>
        /// Вывод купленного предмета
        /// </summary>
        /// <param name="item"></param>
        /// <param name="_swords"></param>
        /// <param name="_swordsPrice"></param>
        public static void BoughtItem(int item, string[] ShoppingItems, int[] ShoppingPrice)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Вы купили {ShoppingItems[item - 1]} за {ShoppingPrice[item - 1]}Gold");
            //Console.WriteLine("\x1b[0m");
            Console.ResetColor();
        }
    }
}

