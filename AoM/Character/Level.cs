using System;
namespace Age_Of_Magic
{
	partial class Character
    {
		public static int _level { get; set; }
		public static int _currentXp { get; set; }
		public static int _nextLevelXP { get; set; }

		public static void UpdateNextLevelXP()
		{
			if (_currentXp >= _nextLevelXP)
			{
				_level++;
				_currentXp = _currentXp - _nextLevelXP;
				_nextLevelXP = _nextLevelXP + 50;
				UpdateNextLevelXP();
			}
			UpdateDamage();
		}

		public void GetXP()
		{
			_currentXp = _currentXp + 200;
		}
	}
}

