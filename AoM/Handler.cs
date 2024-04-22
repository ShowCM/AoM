using System;

namespace Age_Of_Magic
{
    class Handler : Character
    {
        //private Character _character;
        private Shop _shop;
        //private Arena _arena;
        Arena _arena = new Arena();

        public Handler(int playType)
        {
            SetClass(playType);
            _shop = new Shop();
        }

        public void Menu()
        {
            Console.WriteLine("1 - Инвентарь");
            Console.WriteLine("2 - Магазин");
            Console.WriteLine("3 - Арена");
            Console.WriteLine("4 - Читкод");
            Console.WriteLine("5 - Get Damage");
            Console.WriteLine("6 - Get XP");
            Switches();
        }

        public void Switches()
        {
            int option;
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.Clear();
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                Switches();
                return;
            }
            if (option < 1 || option > 6)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 6.");
                Switches();
                return;
            }
            Console.Clear();
            switch (option)
            {
                case 1:
                    GetInventory();
                    DefaultComands.Enter();
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    Console.WriteLine("1 - Оружие");
                    Console.WriteLine("2 - Броня");
                    DefaultComands.Escape();

                    int shopOption;
                    if (!int.TryParse(Console.ReadLine(), out shopOption))
                    {
                        Console.Clear();
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                        Menu();
                    }
                    if (shopOption < 0 || shopOption > 3)
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 3.");
                        Menu();
                        return;
                    }
                    Console.Clear();

                    switch (shopOption)
                    {
                        case 1:
                            Console.WriteLine("1 - Человеческие Реликвии");
                            Console.WriteLine("2 - Магические Артефакты");
                            Console.WriteLine("3 - Адские Эфемеры");
                            DefaultComands.Escape();

                            int weaponsOption;
                            if (!int.TryParse(Console.ReadLine(), out weaponsOption))
                            {
                                Console.Clear();
                                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                                Menu();
                            }
                            if (weaponsOption < 0 || weaponsOption > 4)
                            {
                                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 4.");
                                Menu();
                                return;
                            }

                            Console.Clear();

                            switch (weaponsOption)
                            {
                                case 1:
                                    ShopItems(shopOption, weaponsOption);
                                    break;
                                case 2:
                                    ShopItems(shopOption, weaponsOption);
                                    break;
                                case 3:
                                    ShopItems(shopOption, weaponsOption);
                                    break;
                                case 0:
                                    Console.Clear();
                                    Menu();
                                    break;
                            }

                            break;
                        case 2:
                            ShopItems(shopOption, 2);
                            break;
                        case 0:
                            Console.Clear();
                            Menu();
                            break;
                    }
                    break;
                case 3:
                    ArenaSwitches();
                    break;
                case 4:
                    CheatCode();
                    Menu();
                    break;
                case 5:
                    GetDamage();
                    Console.WriteLine("Вы получили урон");
                    Menu();
                    break;
                case 6:
                    GetXP();
                    Console.WriteLine("Вы получили 200XP");
                    Menu();
                    break;
            }
        }

        public void ArenaSwitches()
        {
            Console.WriteLine("1 - Выбрать снаряжение");
            Console.WriteLine("2 - Снаряжение");
            Console.WriteLine("3 - Пойти в бой");
            DefaultComands.Escape();

            int option;
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.Clear();
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                ArenaSwitches();
            }
            if (option < 0 || option > 4)
            {
                Console.Clear();
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 4.");
                ArenaSwitches();
                return;
            }

            switch (option)
            {
                case 1:
                    Console.Clear();
                    ArenaItemsSwitch();
                    DefaultComands.Enter();
                    ArenaSwitches();
                    break;
                case 2:
                    Console.Clear();
                    _arena.GetArenaWeaponInventory();
                    DefaultComands.Enter();
                    Console.Clear();
                    ArenaSwitches();
                    break;
                case 3:
                    break;
                case 0:
                    Console.Clear();
                    Menu();
                    break;
            }
        }
        public void ArenaItemsSwitch()
        {
            Console.WriteLine("Возьмите снаряжение");
            Console.WriteLine("1 - Оружие");
            Console.WriteLine("2 - Броня");
            DefaultComands.Escape();

            int option;
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.Clear();
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                ArenaItemsSwitch();
            }
            if (option < 0 || option > 3)
            {
                Console.Clear();
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 3.");
                ArenaItemsSwitch();
                return;
            }
            switch (option)
            {
                case 1:
                    Console.Clear();
                    ShowInventory.GetWeaponInventory();

                    int item;
                    if (!int.TryParse(Console.ReadLine(), out item))
                    {
                        Console.Clear();
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                        ArenaItemsSwitch();
                    }
                    _arena.SetArenaWeaponInventory(item);
                    break;
                case 2:
                    Console.Clear();
                    ShowInventory.GetArmorInventory();

                    int item1;
                    if (!int.TryParse(Console.ReadLine(), out item1))
                    {
                        Console.Clear();
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                        ArenaItemsSwitch();
                    }
                    _arena.SetArenaArmorInventory(item1);
                    break;
                case 0:
                    Console.Clear();
                    ArenaSwitches();
                    break;
            }
        }

        public void ShopItems(int shopOption, int weaponsOption)
        {
            DefaultComands.ChoiseItemToBuy();
            _shop.GetShopItems(shopOption, weaponsOption);

            int item1 = int.Parse(Console.ReadLine()!);
            _shop.BuyItem(item1);

            DefaultComands.Enter();
            Menu();
        }
    }
}

