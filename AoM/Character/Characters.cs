using System;
using static System.Net.Mime.MediaTypeNames;

namespace Age_Of_Magic
{

    partial class Character
    {
        public static string _personClass;
        public static int _damage;

        public Character()
        {
            _balance = 1000; //Default balance
            _maxHealth = 1000; //Default max health
            _currentHealth = _maxHealth;
            _level = 1;
            _currentXp = 0;
            _nextLevelXP = 200;
        }

        public void SetClass(int playType)
        {
            if (playType == 1)
            {
                _personClass = "Human";
                _defaultDamage = 80;

            }
            else if (playType == 2)
            {
                _personClass = "Mage";
                _defaultDamage = 70;
            }
            else if (playType == 3)
            {
                _personClass = "Demon";
                _defaultDamage = 90;
            }
        }

        public void GetPlayerClass()
        {
            Console.WriteLine($"Вы выбрали класс: {_personClass}");
        }

        public static void GetInventory()
        {
            ShowInventory.ShowCharacterStats();
            ShowInventory.GetItems();
        }
    }
}

