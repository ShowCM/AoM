using System;
namespace Age_Of_Magic
{
	partial class Character
    {
        public static int _defaultDamage;

        public static void UpdateDamage()
        {
            _damage = _defaultDamage + (_level * 8);
        }

        public void GetDamage()
        {
            _currentHealth = _currentHealth - 900;
        }

    }
}

